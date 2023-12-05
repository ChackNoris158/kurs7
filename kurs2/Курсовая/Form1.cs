using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;


namespace Курсовая
{
    public partial class Form1 : MaterialForm
    {
        
        static public string Who;
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme            
                (
                Primary.Teal900,
                Primary.Grey800,
                Primary.Amber900,
                Accent.LightGreen400,
                TextShade.WHITE
                );
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialTextBox21.Text == "1" & materialTextBox22.Text == "1")
            {
                Who = "Работник";
                Form2 a = new Form2();
                a.Show();
                Hide();


            }
            else if (materialTextBox21.Text == "2" & materialTextBox22.Text == "2")
            {
                Who = "Администратор";
                Form2 a = new Form2();
                a.Show();
                Hide();

            }
            else if(materialTextBox21.Text == "3" & materialTextBox22.Text == "3")
            {
                Form3 a = new Form3();
                Hide
                    ();
                a.Show();
            }
            else MessageBox.Show("Неверный логин или пароль!", "Попробуйте ещё раз");
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }
    }
}
