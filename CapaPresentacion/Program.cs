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
            rutas1.CODIGO ="5";
            rutas1.CODEMPRESA = "01";
            rutas1.DESCRIPCION = "fff";
            db.RUTA.Add(rutas1);
            db.SaveChanges();

           
            TIPONEGOCIO tiponegocio1 = new TIPONEGOCIO();
            tiponegocio1.CODEMPRESA="01";
            tiponegocio1.CODIGO= "001";
            tiponegocio1.DESCRIPCION = "sdsfdfd";
            db.TIPONEGOCIO.Add(tiponegocio1);
            db.SaveChanges();
        }
    }
}
