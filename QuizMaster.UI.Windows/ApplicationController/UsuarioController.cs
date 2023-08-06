using QuizMaster.Apli.Aplication.EntityServices;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ApplicationController
{
    public class UsuarioController
    {
        private UsuarioServices servicesUsuario;

        public UsuarioController()
        {
            servicesUsuario = new UsuarioServices();
        }

        public bool InsertarUsuarios(UsuarioViewModel nuevoUsuario)
        {
            Usuarios nuevo = new Usuarios();
            try
            {
                nuevo.IDUsuario = nuevoUsuario.IDUsuario;
                nuevo.NombreUsuario = nuevoUsuario.NombreUsuario;
                nuevo.Contraseña = nuevoUsuario.Contraseña;
                nuevo.Rol = nuevoUsuario.Rol;
                nuevo.esProfesor = nuevoUsuario.esProfesor;
                servicesUsuario.InsertarUsuario(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario: " + ex.Message);
            }
        }

        public bool ActualizarUsuarios(UsuarioViewModel nuevoUsuario)
        {
            Usuarios nuevo = new Usuarios();
            try
            {
                nuevo.IDUsuario = nuevoUsuario.IDUsuario;
                nuevo.NombreUsuario = nuevoUsuario.NombreUsuario;
                nuevo.Contraseña = nuevoUsuario.Contraseña;
                nuevo.Rol = nuevoUsuario.Rol;
                nuevo.esProfesor = nuevoUsuario.esProfesor;
                servicesUsuario.ActualizarUsuario(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario: " + ex.Message);
            }
        }


        public IEnumerable<UsuarioViewModel> ListarUsuarios() 
        {
            var listaUsuarios = servicesUsuario.ListarUsuarios();
            List<UsuarioViewModel> resultadoEnvio = new List<UsuarioViewModel>();
            try
            {
                foreach (Usuarios item in listaUsuarios)
                {
                    resultadoEnvio.Add(new UsuarioViewModel
                    {
                        IDUsuario = item.IDUsuario,
                        NombreUsuario = item.NombreUsuario,
                        Contraseña = item.Contraseña,
                        Rol = item.Rol,
                        esProfesor = item.esProfesor,
                    });
                }
                return resultadoEnvio;
            }
            catch(Exception ex) 
            {
                throw new Exception("Error al listar Usuarios: " + ex.Message);

            }
        }



    }
}
