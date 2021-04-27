using System.Linq;

namespace BLFacturacionSB
{
    public class SeguridadBL
    {
           Contexto _contexto;

            public SeguridadBL()
            {

                _contexto = new Contexto();
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
}
