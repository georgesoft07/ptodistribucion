using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity;

namespace CapaPresentacion
{
    class Program
    {
        static void Main(string[] args)
        {

            BDDISTRIBUCIONEntities db = new BDDISTRIBUCIONEntities();
            RUTA rutas1 = new RUTA();
            rutas1.CODIGO ="6";
            rutas1.CODEMPRESA = "01";
            rutas1.DESCRIPCION = "fff";
            db.RUTA.Add(rutas1);
            db.SaveChanges();

        }
    }
}
