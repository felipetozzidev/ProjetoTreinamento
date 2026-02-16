using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTreinamento.CrossCutting.Models
{
    public class AppSettings
    {
        public ConnectionSettings ConnectionSettings { get; set; } = new();
    }
}
