﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeVisualizacaoDeValores.Model
{
    public class Contrac
    {
        /// <summary>
        /// Identity of ID class
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Property for get and set values in contract
        /// </summary>
        public int Value { get; set; }
        public DateTime DatInc { get; set; }
    }
}
