using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using ConnectionLibrary.Models;

namespace ConnectionLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        // dzięki słowu this zwórci nam tam cały string
        public static string FullFilePath(this string fileName) // PrizeModel.csv
        {
            // D:\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName}";
        }

        // Otwórz plik
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];
                output.Add(p);


            }
            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellPhoneNumber }");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName   )
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModel(this List<string> lines , string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    //powinno znaleźć tylko jedną osobę
                    t.TeamMembers.Add(people.Where(x => x.id == int.Parse(id)).First());
                }

                //    p.PlaceName = cols[2];
                //    p.PrizeAmount = decimal.Parse(cols[3]);
                //    p.PrizePercentage = double.Parse(cols[4]);
                output.Add(t);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines, 
            string teamFileName, 
            string peopleFileName,
            string prizeFileName)
        {
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModel(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizesIds = cols[4].Split('|');

                foreach (string id in prizesIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.id == int.Parse(id)).First());
                }

                // TODO Capture Raounds information



                output.Add(tm);          
            }
            return output;
        }
        //SaveToTournamentFile
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                // $@" -> pozwala na łamanie wierszy w kodzie
                lines.Add($@"
                {tm.Id},
                {tm.TournamentName},
                {tm.EntryFee},
                {ConvertTeamListToString(tm.EnteredTeams)},
                {ConvertPrizeListToString(tm.Prizes)},
                {ConvertRoundListToString(tm.Rounds)},
                {ConvertRoundListToString(tm.Rounds)},
                ");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            // (rounds - id^id^id|id^id^id|id^id^id|)
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }
            // 2|4|5|6|
            foreach ( List<MatchupModel> r in rounds)
            {
                output += $"{ ConvertMatchupListToString(r) }|";
            }
            // usuń '|' z ostatniej osoby
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }
            // 2|4|5|6|
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.id }^";
            }
            // usuń '|' z ostatniej osoby
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }
            // 2|4|5|6|
            foreach (PrizeModel p in prizes)
            {
                output += $"{ p.id }|";
            }
            // usuń '|' z ostatniej osoby
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }
            // 2|4|5|6|
            foreach (TeamModel t in teams)
            {
                output += $"{ t.Id }|";
            }
            // usuń '|' z ostatniej osoby
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            
            if (people.Count == 0)
            {
                return "";
            }
            // 2|4|5|6|
            foreach(PersonModel p in people)
            {
                output +=$"{ p.id }|";
            }
            // usuń '|' z ostatniej osoby
            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}


