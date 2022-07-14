using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKeyboardClick
{
    public partial class FormMouseTracer : Form
    {
        private bool dragging;
        private bool focused;

        private int originalX;
        private int originalY;

        private Point dropLocation;

        public FormMouseTracer()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setDropLocation(Point p)
        {
            this.dropLocation = p;
        }

        public bool isFocused()
        {
            return this.focused;
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
        }

        private void FormMouseTracer_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;

            this.Location = this.dropLocation;
        }

        private void FormMouseTracer_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                this.Top = this.Top + (e.Y - originalY);
                this.Left = this.Left + (e.X - originalX);
            }
                
        }

        private void FormMouseTracer_Activated(object sender, EventArgs e)
        {
            this.focused = true;
        }

        private void FormMouseTracer_Deactivate(object sender, EventArgs e)
        {
            this.focused = false;
        }
    }
}
