﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGP.Models
{
    internal class LinhaProcesso
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Texto      { get; set; }

        public int? ProcessoId { get; set; }
        public int? FuncionarioId { get; set; }

    }
}

