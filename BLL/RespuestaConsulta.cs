﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
   public class RespuestaConsulta
    {
   
            public string Mensaje { get; set; }
            public IList<Persona> Personas { get; set; }
            public bool Error { get; set; }
        
    }
}
