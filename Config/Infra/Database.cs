/* using System; */
/* using Microsoft.Extensions.Configuration; */
/* using System.IO; */

/* namespace HotelApi.Config.Infra */
/* { */
/* 	public class DatabaseConfig */
/* 	{ */
/* 		private IConfiguration config; */ 

/* 		public static string Load(string envName) */
/* 		{ */

/* 			var appRoot = Directory.GetCurrentDirectory(); */
/* 			var dotEnvFilePath = Path.Combine(appRoot, ".env"); */
/* 			/1* bool dotEnvFileExists = dotEnvFilePath.IsNullOrEmpty() is null ? false : true; *1/ */

/* 			Console.WriteLine(dotEnvFilePath); */
/* 			if(!dotEnvFilePath) */
/* 				return; */

/* 			foreach (var line in File.ReadAllLines(dotEnvFilePath)) */
/* 			{ */
/* 				var parts = line.Split( */
/* 					'=', */
/* 					StringSplitOptions.RemoveEmptyEntries */
/* 				); */

/* 				if(parts[0] == envName) */
/* 				{ */
/* 					return parts[1]; */
/* 				} */

/* 				Console.WriteLine(parts[0]); */
/* 				Console.WriteLine(parts[1]); */
/* 				Environment.SetEnvironmentVariable(parts[0], parts[1]); */
/* 			} */
/* 		} */

/* 		public static string GetDatabaseConnectionString() */ 
/* 		{ */
/* 			/1* string Host = config.GetValue<string>("Host"); *1/ */
/* 			/1* Load dotEnvs = Load *1/ */
/* 			string Host = "testando"; */
/* 			return Host; */

/* 		} */
/* 	} */
/* } */
