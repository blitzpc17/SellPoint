using CapaDatos;
using CapaDatos.ADO.Sistema;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Logicas.Sistema
{
    public class UsuarioLogica
    {
        private UsuariosADO contextoUsuario;
        private RolesADO contextoRol;
        private EstadoADO contextoEstado;


        public USUARIO ObjUsuario;
        public List<ESTADO> LstEstado;
        public List<ROL> LstRol;
        public List<clsUSUARIO> LstUsuario;
        public List<clsUSUARIO> LstUsuarioAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;


        public UsuarioLogica()
        {
            contextoUsuario = new UsuariosADO();
            contextoRol = new RolesADO();
            contextoEstado = new EstadoADO();
        }

        public void InstanciarUsuario()
        {
            ObjUsuario = new USUARIO();
        }

        public void ListarUsuarios()
        {
            LstUsuario = contextoUsuario.ListarUsuarios();
        }

        public void ListarCatalogos()
        {
            LstEstado = contextoEstado.Listar().Where(x=>x.Proceso=="USUARIO").ToList();
            LstRol = contextoRol.Listar();
        }

        public void Guardar()
        {
            if (ObjUsuario.Id == 0)
            {
                contextoUsuario.Insertar(ObjUsuario);
            }           

            contextoUsuario.Guardar();
        }       

        public USUARIO ObtenerUsuario(int id)
        {
            return contextoUsuario.Obtener(id);
        }

        public bool Filtrar(int column, string termino)
        {
            if (LstUsuarioAux == null) LstUsuarioAux = LstUsuario;

            switch (column)
            {
                case 1:
                    index = LstUsuarioAux.FindIndex(x => x.Alias.StartsWith(termino));
                    break;
                case 2:
                    index = LstUsuarioAux.FindIndex(x => x.Rol.ToString().StartsWith(termino));
                    break;
                case 3:
                    index = LstUsuarioAux.FindIndex(x => x.Estado.StartsWith(termino));
                    break;                


                default:
                    index = -1;
                    break;

            }

            return (index >= 0);

        }

        public void Ordenar(int column)
        {
            switch (column)
            {

                case 1:
                    LstUsuarioAux = LstUsuario.OrderBy(x => x.Alias).ThenBy(x=>x.Rol).ThenBy(x=>x.Estado).ToList();
                    break;
                case 2:
                    LstUsuarioAux = LstUsuario.OrderBy(x => x.Rol).ThenBy(x=>x.Estado).ThenBy(x=>x.Alias).ToList();
                    break;
                case 3:
                    LstUsuarioAux = LstUsuario.OrderBy(x => x.Estado).ThenBy(x=>x.Rol).ThenBy(x=>x.Alias).ToList();
                    break;                

                default:
                    LstUsuarioAux = LstUsuario.OrderBy(x => x.Alias).ThenBy(x => x.Rol).ThenBy(x => x.Estado).ToList();
                    break;

            }
        }


    }
}
