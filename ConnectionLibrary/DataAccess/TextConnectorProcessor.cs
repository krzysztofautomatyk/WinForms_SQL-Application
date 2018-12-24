using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using ConnectionLibrary.Models;

namespace ConnectionLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {
        // dzięki słowu this zwórci nam tam cały string
        public static string FullFilePath(this string fileName) // PrizeModel.csv
        {
            // D:\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName}}";
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

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach ( string line in lines )
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

    }
}