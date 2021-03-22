using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {

        protected  override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Password = "123";
            usuarioAdmin.Rol = "Super Usuario";

            contexto.Usuarios.Add(usuarioAdmin);


            var categoria1 = new Categoria();
            categoria1.Descripcion = "Servicios";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Consumible";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Inventariable";
            contexto.Categorias.Add(categoria3);

            //tipo cliente
            var tipocliente1 = new TipoCliente();
            tipocliente1.Descripcion = "Credito";
            contexto.TipoClientes.Add(tipocliente1);

            var tipocliente2 = new TipoCliente();
            tipocliente2.Descripcion = "Contado";
            contexto.TipoClientes.Add(tipocliente2);


            //Termino de pago

            var termpago1 = new TermPago();
            termpago1.Descripcion = "30 dias";
            contexto.TermPagos.Add(termpago1);

            var termpago2 = new TermPago();
            termpago2.Descripcion = "45 dias";
            contexto.TermPagos.Add(termpago2);

            var termpago3 = new TermPago();
            termpago3.Descripcion = "60 dias";
            contexto.TermPagos.Add(termpago3);

            var termpago4 = new TermPago();
            termpago4.Descripcion = "Contado";
            contexto.TermPagos.Add(termpago4);


            base.Seed(contexto);

        }

    }
}
