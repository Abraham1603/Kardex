using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Kardex.Layers;

namespace Kardex.Layers
{
    class BL //Buisness Layer
    {
        DAL dal = new DAL();

        //CARRERA
        public DataTable ConsultaCarrera(string carrera)
        {
            
            if (carrera != "")
            {
                
                return dal.ConsultaCarrera(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }

            
        }

        public void ModificaCarrera(string carrera, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if(carrera == "")
            {
                MessageBox.Show("Favor de especificar la carrera a modificar", "Alerta", MessageBoxButtons.OK);
                
            }
            else
            {
                if (fechaalta > DateTime.Now)
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    if(fechabaja>DateTime.Now)
                    {
                        MessageBox.Show("La fecha de baja no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dal.ModificaCarrera(carrera, fechaalta, fechabaja, estatus);
                        MessageBox.Show("La carrera se modifico exitosamente", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void AltaCarrera (string carrera, DateTime fechaalta, bool estatus)
        {
            if(carrera == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la carrera", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                if(fechaalta > DateTime.Now)
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);

                }
                else
                {
                    dal.AltaCarrera(carrera, fechaalta, estatus);
                    MessageBox.Show("La carrera se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        public void BajaCarrera(string carrera)
        {
            if (carrera == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la carrera", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                dal.BajaCarrera(carrera);
                MessageBox.Show("La carrera se dio de baja correctamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        //MATERIA
        public void AltaMateria(string materia)
        {
            if (materia == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la Materia", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                /*if (fechaalta > DateTime.Now)
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);

                }
                else
                {*/
                    dal.AltaMateria(materia);
                    MessageBox.Show("La materia se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                //}
            }
        }

        public void BajaMateria(string materia)
        {
            if (materia == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la Materia", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                /*if (fechaalta > DateTime.Now)
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);

                }
                else
                {*/
                dal.BajaMateria(materia);
                MessageBox.Show("La materia se dio de baja correctamente", "Aviso", MessageBoxButtons.OK);
                //}
            }
        }

        public DataTable ConsultaMateria(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaMateria(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la materia.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void ModificaMateria(string materia, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (materia == "")
            {
                MessageBox.Show("Favor de especificar la materia a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                if (fechaalta > DateTime.Now)
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    if (fechabaja > DateTime.Now)
                    {
                        MessageBox.Show("La fecha de baja no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dal.ModificaMateria(materia, fechaalta, fechabaja, estatus);
                        MessageBox.Show("La materia se modifico exitosamente", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
        }
        public DataTable LoginValidation(string username, string password)
        {
            if(username == "")
            {
                MessageBox.Show("Es necesario especificar un nombre de usuario.", "Alerta", MessageBoxButtons.OK);
                return null;
            }
            else
            {
                if(password == "")
                {
                    MessageBox.Show("Es necesario especificar una contraseña", "Alerta", MessageBoxButtons.OK);
                    return null;
                }
                else
                {
                    return dal.LoginValidation(username, password);

                }
            }
            
        }
    }
}
