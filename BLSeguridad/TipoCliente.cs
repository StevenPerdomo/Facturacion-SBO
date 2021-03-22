using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class TipoClientesBL
    {
        Contexto _contexto;

        public BindingList<TipoCliente> ListaTipoCliente { get; set; }

        public TipoClientesBL()
        {
            _contexto = new Contexto();
            ListaTipoCliente = new BindingList<TipoCliente>();
        }

        public BindingList<TipoCliente> ObtenerTipoCliente()
        {
            _contexto.TipoClientes.Load();
            ListaTipoCliente = _contexto.TipoClientes.Local.ToBindingList();


            return ListaTipoCliente;
        }
    }

    public class TipoCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}

