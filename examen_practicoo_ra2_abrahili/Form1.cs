using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_practicoo_ra2_abrahili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string matricula = txt_matricula.Text;
            string nombre = txt_nombre.Text;
            string direccion = txt_direccion.Text;
            string telefono = txt_telefono.Text;
            string email = txt_email.Text;
            string maestro = txt_maestro.Text;
            string generoS = cmb_genero.SelectedItem.ToString();
            string seccion = cmb_seccion.SelectedItem.ToString();
            string area = cmb_area.SelectedItem.ToString();
            string curso = cmb_curso.SelectedItem.ToString();
            

            object[] fila = new object[] { matricula, nombre, direccion, telefono,generoS, email, maestro,seccion,area,curso};

            dataGridView1.Rows.Add(fila);

           
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_matricula.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_maestro.Clear();

            cmb_genero.SelectedItem = null;
            cmb_seccion.SelectedItem = null;
            cmb_area.SelectedItem = null;
            cmb_curso.SelectedItem = null;


            txt_matricula.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           
          


            // Mostrar un cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Estas seguro de que deseas eliminar esta informacion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int indiceFilaSeleccionada = dataGridView1.SelectedRows[0].Index;


                    dataGridView1.Rows.RemoveAt(indiceFilaSeleccionada);
                }

                MessageBox.Show("ya a sido eliminado");

            }
            else
            {
                // Código a ejecutar si el usuario hace clic en "No" o cierra el cuadro de diálogo
                MessageBox.Show("ten cuidado");
            }




        }
    }
}
