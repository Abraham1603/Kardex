using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Kardex.Layers; //Podemos acceder a cada una de las clases dentro de la carpeta Layers
using System.Windows.Forms; //Puede tirar mensajitos

namespace Kardex.Layers
{
    class DAL //DAL - Data Acces Layer
    {
        dbConn conn = new dbConn();
        
        public DataTable ConsultaCarrera(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaCarrera " + carrera;
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public void ModificaCarrera(string carrera, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ModificaCarrera '" + carrera + "', '" + fechaalta + "', '" + fechabaja + "', '" + estatus + "'";
                conn.ExcQry(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void AltaCarrera(string carrera, DateTime fechaalta, bool estatus)
        {
            try
            {
                string query = "AltaCarrera " + carrera + "," + fechaalta + "," + estatus;
                conn.ExcQry(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
        public void BajaCarrera(string carrera)
        {
            try
            {
                string query = "BajaCarrera " + carrera;
                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public DataTable LoginValidation(string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "LoginMaestrosAlumnos '" + username + "'," + "'" + password + "'";
                dt = conn.ExcQryDt(query);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
            return dt;
        }

        public void AltaMateria(string materia)
        {
            try
            {
                string query = "AltaMateria " + materia;
                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void BajaMateria(string materia)
        {
            try
            {
                string query = "BajaMateria " + materia;
                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public DataTable ConsultaMateria(string materia)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro materia
                //Para ejecutarlo posteriormente.
                query = "ConsultaMateria " + materia;
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public void ModificaMateria(string materia, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {

                string query = "ModificaMateria '" + materia + "', '" + fechaalta + "', '" + fechabaja + "', '" + Convert.ToInt32(estatus) + "'";
                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

    }


}
