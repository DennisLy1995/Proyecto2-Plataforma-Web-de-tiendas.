﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPOJO
{
    public class CategoriaFavorita : BaseEntity
    {
        public int IdCategoria { get; set; }
        public string IdUsuario { get; set; }
    }
}
