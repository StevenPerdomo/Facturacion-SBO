using System.ComponentModel;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente>  listaCliente { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            listaCliente = new BindingList<Cliente>();

      
        }

        public BindingList<Cliente> ObtenerClientes()
        {

            _contexto.Clientes.Load();
            listaCliente = _contexto.Clientes.Local.ToBindingList();

            return listaCliente;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
           
                _contexto.SaveChanges();

                resultado.Exitoso = true;
                return resultado;
                                        
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            listaCliente.Add(nuevoCliente);

        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in listaCliente)
            {
                if (cliente.Id == id)
                {
                    listaCliente.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                   }
                }
                
                    return false;
            }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cliente == null)
            {

                resultado.Mensaje = "Agregue un cliente Valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (cliente.RazonSocial == null)
            {
                resultado.Mensaje = "Ingrese una Descripcion";
                resultado.Exitoso = false;
            }
            if (cliente.RtnCliente == null)
            {
                resultado.Mensaje = "Ingrese RTN";
                resultado.Exitoso = false;
            }

            if (cliente.Nombrecont == null)
            {
                resultado.Mensaje = "Ingrese Contacto";
                resultado.Exitoso = false;
            }

            if (cliente.Telefono == null)
            {
                resultado.Mensaje = "Ingrese Contacto";
                resultado.Exitoso = false;
            }

            if (cliente.TipoClienteId == 0)
            {
                resultado.Mensaje = "Ingrese Contacto";
                resultado.Exitoso = false;
            }

            if (cliente.TermPagoId == 0)
            {
                resultado.Mensaje = "Ingrese Contacto";
                resultado.Exitoso = false;
            }

            resultado.Exitoso = true;
            return resultado;

        }
    }


 

    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RtnCliente  { get; set; }
        public string Nombrecont { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public double Saldo { get; set;}
        public bool Activo { get; set; }
        public int TermPagoId { get; set; }
        public TermPago Termpago { get; set; }
        public int TipoClienteId { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public Cliente()
        {
            Activo = true;
        }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }

}

