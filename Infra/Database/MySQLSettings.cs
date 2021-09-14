namespace HotelApi.Infra
{
	public class MySQLSettings
	{
		public string Host { get; set; }
		public string Port { get; set; }
		public string Database { get; set; }
		public string User { get; set; }
		public string Password { get; set; }
		public string ConnectionString 
		{
			get
			{
				return $"Server={Host};Port={Port};Database={Database};User={User};Password={Password};";
			}
		}
	}
}
