using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GestionDeProductos.Diseño
{
    public class Boton : Button
    {
        private int borderSize = 2;
        private int borderRaius=40;
        private Color borderColor = Color.LightBlue;

        [Category("Propiedades Boton Manual")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        
            }
        [Category("Propiedades Boton Manual")]
        public int BorderRaius {

            get
            {
                return borderRaius;
            }
            set
            {
                borderRaius = value;
                this.Invalidate();
            }

        }
        [Category("Propiedades Boton Manual")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }

        }

        [Category("Propiedades Boton Manual")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("Propiedades Boton Manual")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }



        public Boton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

     private GraphicsPath GetFigurePath(RectangleF rect,float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X , rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;


        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface= new RectangleF(0,0,this.Width,this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width, this.Height-1);

            if (BorderRaius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRaius)) 
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRaius-1F)) 
                using(Pen penSurface=new Pen(this.Parent.BackColor,2))
                using (Pen penBorder = new Pen(BorderColor,BorderSize))
                {
                    penBorder.Alignment=PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    pevent.Graphics.DrawPath(penSurface, pathBorder);

                    if (BorderSize >= 1)
                    
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
                else
                {
                   this.Region = new Region(rectSurface);

                if (BorderSize >= 1)
                {
                    using(Pen penBorder=new Pen(BorderColor,BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0,this.Width-1,this.Height-1);
                    }
                }

                
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged +=new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
                this.Invalidate();
        }
    }
   
}
