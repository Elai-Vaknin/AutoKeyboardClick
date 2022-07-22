using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKeyboardClick
{
    public partial class FormMouseTracer : Form
    {
        private bool dragging;

        private int originalX;
        private int originalY;

        private Point dropLocation;
        private Func<int> callback;

        public FormMouseTracer()
        {
            InitializeComponent();
        }

        public FormMouseTracer(Func<int> fun)
        {
            InitializeComponent();

            callback = fun;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* Circular form */

            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();

            shape.AddEllipse(0, 0, this.Width, this.Height);

            this.Region = new System.Drawing.Region(shape);
        }

        public void setDropLocation(Point p)
        {
            this.dropLocation = p;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parameter = base.CreateParams;
                parameter.ExStyle |= 0x80; // Apply toolbar-property
                parameter.ExStyle |= 0x8000000; // Revoke acitvation
                return parameter;
            }
        }

        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }

      

        private void FormMouseTracer_MouseDown(object sender, MouseEventArgs e)
        {
            this.originalX = e.X;
            this.originalY = e.Y;
            this.dragging = true;
            this.TopMost = true;
        }

        private void FormMouseTracer_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
            this.TopMost = false;
            this.Location = this.dropLocation;

            callback();
        }

        private void FormMouseTracer_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                this.Top = this.Top + (e.Y - originalY);
                this.Left = this.Left + (e.X - originalX);
            }
                
        }
    }
}
