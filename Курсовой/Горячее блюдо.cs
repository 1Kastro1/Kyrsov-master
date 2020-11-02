using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой
{
    public partial class Горячее_блюдо : Form
    {
        public Горячее_блюдо()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

  
       
    

            private void button3_Click(object sender, EventArgs e)
            {
                Чуду fm = new Чуду();

                fm.Show();
            }

            

         

            private void button6_Click(object sender, EventArgs e)
            {
                Пироги fm = new Пироги();

                fm.Show();
            }

        private void Горячее_блюдо_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Меню fm = new Меню();

            fm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Горячее_блюдо fm = new Горячее_блюдо();

            fm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Десерты fm = new Десерты();

            fm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Напитки fm = new Напитки();

            fm.Show();
        }
    }
}
