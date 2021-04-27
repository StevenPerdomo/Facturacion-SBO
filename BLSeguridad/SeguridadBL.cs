using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;

namespace BLFacturacionSB
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public BindingList<Usuario> ListaUsuarios { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;

        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            _contexto.Usuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaUsuarios.ToList())
            {
                if (usuario.Id == id)
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;

                }
            }
            return false;
        }

        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = false;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un Usuario valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if(string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del usuario";
                resultado.Exitoso = false; 

            }
            return resultado;
        }


            public Usuario Autorizar(string usuario, string password)
             {

            var usuarios = _contexto.Usuarios.ToList();

            foreach (var UsuariosDB in usuarios)
            {
               if (usuario == UsuariosDB.Nombre && password == UsuariosDB.Password)
                {
                    return UsuariosDB;
                   }
                }
                    return null;
                }
                 
            }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public Usuario()
        {
            Rol = "Vendedores";
        }
    }

    
}
