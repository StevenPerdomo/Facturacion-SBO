using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class TermPagosBL
    {
        Contexto _contexto;

        public BindingList<TermPago> ListaTermPago { get; set; }

        public TermPagosBL()
        {
            _contexto = new Contexto();
            ListaTermPago = new BindingList<TermPago>();
        }

        public BindingList<TermPago> ObtenerTermPago()
        {
            _contexto.TermPagos.Load();
            ListaTermPago = _contexto.TermPagos.Local.ToBindingList();


            return ListaTermPago;
        }
    }

    public class TermPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
  }

