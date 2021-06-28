using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen_Parcial1
{
    public partial class Solicitud : Form
    {
        public Solicitud()
        {
            InitializeComponent();
            comboBox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_marca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea continuar sin guardar los cambios?", "Advertencia!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                guardar_datos();
            vaciar_datos();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar_datos();
        }

        private int checa_RadioBtn(ref int check){
            if (radioButton1.Checked == true) check = 1;
            if (radioButton2.Checked == true) check = 2;
            if (radioButton3.Checked == true) check = 3;
            
            return check;
        }

        private bool checa_CheckBox(ref bool check)
        {
            if (checkBox1.Checked == true) check = true;

            return check;
        }

        private void vaciar_datos(){
            textBox_nombre.Text = "";
            textBox_paterno.Text = "";
            textBox_materno.Text = "";
            comboBox_tipo.SelectedItem = null;
            comboBox_marca.SelectedItem = null;
            monthCalendar1.SetDate(monthCalendar1.TodayDate);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
        }

        private void guardar_datos()
        {
            string nom = textBox_nombre.Text;
            string ap_p = textBox_paterno.Text;
            string ap_m = textBox_materno.Text;
            string combotipo = comboBox_tipo.Text;
            string combomarca = comboBox_marca.Text;
            string fecha = monthCalendar1.SelectionStart.ToShortDateString();
            bool check_chbox = false;
            checa_CheckBox(ref check_chbox);
            int check_rdBtn = 0;
            checa_RadioBtn(ref check_rdBtn);

            SaveFileDialog dig = new SaveFileDialog();
            //Permite restringir el formato en que se va a guardar el archivo
            dig.Filter = "Archivo de texto|*.txt";

            DialogResult res = dig.ShowDialog();

            if (res == DialogResult.OK)
            {
                File.WriteAllText(dig.FileName, nom + "\n" + ap_p + "\n" + ap_m + "\n" +
                                                combotipo + "\n" + combomarca + "\n" + fecha + "\n" +
                                                check_chbox + "\n" + check_rdBtn);
            }
            vaciar_datos();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String lee;

            OpenFileDialog dig = new OpenFileDialog();

            dig.Filter = "Archivo de texto|*.txt";

            DialogResult res = dig.ShowDialog();

            if (res == DialogResult.OK)
            {
                lee = File.ReadAllText(dig.FileName);
                if (lee != null)
                {
                    lee_Datos(lee);
                }
                else MessageBox.Show("El archivo está vacío");
            }
        }

        private void lee_Datos(string file)
        {
            String[] data = file.Split('\n');

            textBox_nombre.Text = data[0];
            textBox_paterno.Text = data[1];
            textBox_materno.Text = data[2];
            comboBox_tipo.Text = data[3];
            comboBox_marca.Text = data[4];
            String[] fecha = data[5].Split('/');
            int day = Convert.ToInt32(fecha[0]);
            int month = Convert.ToInt32(fecha[1]);
            int year = Convert.ToInt32(fecha[2]);
            DateTime date = new DateTime (year, month, day);
            monthCalendar1.SetDate(date);

            string check_checkbox = data[6];
            if (check_checkbox == "True") checkBox1.Checked = true;

            string check_radBtn = data[7];
            if (check_radBtn == "1") radioButton1.Checked = true;
            if (check_radBtn == "2") radioButton2.Checked = true;
            if (check_radBtn == "3") radioButton3.Checked = true;
        }
    }
}
