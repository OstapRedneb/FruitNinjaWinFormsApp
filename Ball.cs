using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public class Ball
    {
        public static Graphics graphics;
        public static Form form;
        public static Pen pen;
        public static Pen formPen;
        public static Brush formBrush;

        public Timer timer;
        public Brush brush;
        public RectangleF rect;


        protected float x;
        protected float y;
        
        protected float centerX => x + radius;
        protected float centerY => y + radius;
        
        protected float radius;
        protected float size;
        
        protected float Vx;
        protected float Vy;

        protected float g;

        public Ball() : this(0, 0)
        { }
        public Ball(float x, float y) : this(x, y, 30) 
        { }
        public Ball(float x, float y, float size) : this(y, x, size, 0.1f, -5) 
        { }
        public Ball(float x, float y, float size, float vx, float vy) : this(y, x, size, vx, vy, 0) 
        { }
        public Ball(float x, float y, float size, float vx, float vy, float g) : this(x, y, size, vx, vy, g, Color.Black) 
        { }
        public Ball(float x, float y, float size, float vx, float vy, float g, Color color) 
        {
            (this.x, this.y) = (x, y);

            this.size = size;
            radius = size / 2;

            (Vx, Vy) = (vx, vy);

            this.g = g;

            brush = new SolidBrush(color);
            rect = new RectangleF(x, y, size, size);

            timer.Tick += MoveNext;
        }

        public void Show() 
        {
            graphics.FillEllipse(brush, rect);
            graphics.DrawEllipse(pen, rect);
        }
        public void Clear() 
        {
            graphics.FillEllipse(formBrush, rect);
            graphics.DrawEllipse(formPen, rect);
        }
        public virtual void Go() 
        {
            x += Vx;
            y += Vy;
        }
        public virtual void MoveNext(object sender, EventArgs e) 
        {
            Vy += g;
            Go();
            if (y > form.ClientSize.Height + 100)
                timer.Stop();
        }
    }
}
