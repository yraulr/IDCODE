﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {

            return "Data Source=DESKTOP-NF73TQ1\\SQLEXPRESS;Initial Catalog=BD_PROYECTO;Integrated Security=SSPI;";
            //return "Data Source=(local);Initial Catalog=BD_PROYECTO;Integrated Security=SSPI;";

        }
    }
}