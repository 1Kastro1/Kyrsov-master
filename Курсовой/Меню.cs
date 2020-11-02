using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Горячее_блюдо fm = new Горячее_блюдо();
            fm.Location = new Point(0,0);

            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Чуду fm = new Чуду();
            fm.Location = new Point(0, 0);
            fm.Show();
            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Десерты  fm = new Десерты();

            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Напитки fm = new Напитки();

            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Пироги fm = new Пироги();

            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Меню_Load(object sender, EventArgs e)
        {

        }
    }
}
