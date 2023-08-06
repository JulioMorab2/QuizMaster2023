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
    public class UsuariosController
    {
        UsuariosServices services;
        public UsuariosController() {

            services= new UsuariosServices();
        }

        public bool BuscarUsusarios(String nombre, String contraseña)
        {
            
            
            try
            {
                if(services.BuscarUsuario(nombre, contraseña))
                {  return true; }
                else { return false; }

               
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Ususario: " + ex.Message);
            }

        }
    }
}
