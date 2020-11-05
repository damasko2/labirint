using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Уровень пройден");


            this.Close();
            //Hide();
        }

        private void MoveToStart()
        {
            Point stp = panel1.Location;
            stp.Offset(15, 15);

            Cursor.Position = PointToScreen(stp);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveToStart();
        }
    }
}
