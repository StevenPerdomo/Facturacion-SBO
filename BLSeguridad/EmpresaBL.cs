using System.ComponentModel;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLFacturacionSB
{
    public class EmpresaBL
    {
        Contexto _contexto;

       public BindingList<Empresa> ListaEmpresas { get; private set; }

        public EmpresaBL()
        {
            _contexto = new Contexto();
            ListaEmpresas = new BindingList<Empresa>();


        }

        public BindingList<Empresa> ObtenerEmpresas()
        {
            _contexto.Empresas.Load();
            ListaEmpresas = _contexto.Empresas.Local.ToBindingList();

            return ListaEmpresas;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarEmpresa(Empresa empresa)
        {

            var resultado = Validar(empresa);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarEmpresa()
        {
            var nuevaEmpresa = new Empresa();
            _contexto.Empresas.Add(nuevaEmpresa);

        }

        public bool EliminarEmpresa(int id)
        {
            foreach (var empresa in ListaEmpresas.ToList())
            {
                if (empresa.Id == id)
                {
                    ListaEmpresas.Remove(empresa);
                    _contexto.SaveChanges();
                    return true;
                }

            }

            return false;
        }

        private Resultado Validar(Empresa empresa)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (empresa.RTN == null)
            {

                resultado.Mensaje = "Favor Ingrese RTN";
                resultado.Exitoso = false;

                return resultado;
            }

            if (empresa.RazonSocial == null)
            {

                resultado.Mensaje = "Favor ingresa Razon Social";
                resultado.Exitoso = false;
            }

            if (empresa.Telefono == null)
            {

                resultado.Mensaje = "Favor ingrese # Telefonico";
                resultado.Exitoso = false;
            }

            if (empresa.Direccion == null)
            {

                resultado.Mensaje = "Favor Ingrese Direccion";
                resultado.Exitoso = false;
            }

            if (empresa.Correo == null)
            {

                resultado.Mensaje = "Favor ingrese Correo electronico";
                resultado.Exitoso = false;
            }

            resultado.Exitoso = true;
            return resultado;

        }
    }

    public class Empresa
    {
        public int Id { get; set; }
        public string RTN { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public byte[] ImagEmpresa { get; set; }

    }
}
