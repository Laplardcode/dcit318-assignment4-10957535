using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private Point? previousPoint = null;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            previousPoint = e.Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            previousPoint = null;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (previousPoint != null && e.Button == MouseButtons.Left)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint.Value, e.Location);
                }
                previousPoint = e.Location;
            }
        }
    }
}
