namespace ProjetoTreinamento.CrossCutting.Models
{
    public class ConnectionSettings
    {
        public string Server { get; set; } = string.Empty;
        public string Instance { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string GetConnectionString(string database)
        {
            return $"Server={Server}\\{Instance};Database={database};User ID={User};Password={Password};persist security info=True;MultipleActiveResultSets=True;Trusted_Connection=False;TrustServerCertificate=True;";
        }
    }
}
