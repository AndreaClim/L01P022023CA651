﻿using System.ComponentModel.DataAnnotations;

namespace L01P022023CA651.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }
        public string departamento { get; set; }
    }
}
