/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS ( SELECT * FROM DBO.People WHERE 
				FirstName = 'Krzysztof' and
				LastName = 'Wożniczak' and
				EmailAddress='k.wozniczak@xyz.pl' and
				CellphoneNumber='111222333' )
BEGIN 
	INSERT INTO DBO.People ( FirstName,LastName,EmailAddress,CellphoneNumber)
	VALUES ('Krzysztof','Wożniczak','k.wozniczak@xyz.pl','111222333')
END