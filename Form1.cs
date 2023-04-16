using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Mouse_move
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Coord_mouse(MouseEventArgs e)
        {
            return $"Coordinates: x= {e.X.ToString()}; y={e.Y.ToString()}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coord_mouse(e);
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
       
                string mes = "Вы нажали на внешнюю область";
                mes += $"\n {Coord_mouse(e)}";
                string caption = "Mouse click";
                MessageBox.Show(mes, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.X == 0 || e.Y == 0|| e.Y == 321|| e.X == 392)
            {
                string mes = "Вы нажали на границу внутренней области";
                mes += $"\n {Coord_mouse(e)}";
                string caption = "Mouse click";
                MessageBox.Show(mes, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mes = "Вы нажали на внутреннюю область";
                mes += $"\n {Coord_mouse(e)}";
                string caption = "Mouse click";
                MessageBox.Show(mes, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            
            Text = Coord_mouse(e);
        }
    }
}
