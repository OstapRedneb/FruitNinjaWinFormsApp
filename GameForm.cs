using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048ClassLibrary;

namespace FruitNinjaWinFormsApp
{
    public enum Difficult 
    {
        Easy,
        Middle,
        Hard
    }
    public partial class GameForm : Form
    {
        public static Difficult difficult = Difficult.Easy;
        public static User user;
        public static PaintEventArgs paintSlice;

        private List<Point> slicePoints = new List<Point>(); // Точки траектории разреза
        private bool isSlicing = false; // Флаг активного разреза

        public Graphics graphics;
        public Graphics sliceGraphics;
        public GameForm()
        {
            InitializeComponent();

            // Включить двойную буферизацию для плавной анимации
            this.DoubleBuffered = true;

            // Для обработки событий мыши за пределами формы
            this.Capture = true;

            graphics = CreateGraphics();
            sliceGraphics = CreateGraphics();
            paintSlice = new PaintEventArgs(sliceGraphics, new Rectangle());

            Ball.graphics = graphics;
            Ball.pen = new Pen(Color.Black);
            Ball.formPen = new Pen(BackColor);
            Ball.formBrush = new SolidBrush(BackColor);
            Ball.form = this;
            Fruit.ChangeScore = () => scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            user.Result = int.Parse(scoreLabel.Text);
            new MenuForm().Show();
            Hide();
        }

        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isSlicing = true;
                slicePoints.Clear();
                slicePoints.Add(e.Location); // Начальная точка

                // Для мгновенной реакции можно добавить проверку на фрукт здесь
                CheckFruitHit(e.Location);
            }
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSlicing)
            {
                slicePoints.Add(e.Location); // Добавляем точку траектории

                // Визуализация разреза (опционально)
                Invalidate();

                // Проверка пересечения с фруктами
                CheckFruitHit(e.Location);

                // Для плавности: ограничьте количество точек
                if (slicePoints.Count > 50) slicePoints.RemoveAt(0);
            }
        }

        private void GameForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isSlicing = false;

                // Финализация разреза
                if (slicePoints.Count > 2)
                {
                    ProcessSlice();
                    sliceGraphics.Clear(BackColor);
                }
            }
        }
        private void ProcessSlice()
        {
            OnPaint(paintSlice);
        }



        private void CheckFruitHit(Point point)
        {
            //foreach (var fruit in fruits)
            //{
            //    // Проверка попадания точки в фрукт
            //    if (IsPointInFruit(point, fruit))
            //    {
            //        fruit.Slice(); // Логика разрубания фрукта
            //                       // Можно добавить визуальные эффекты
            //    }
            //}
        }
        //private bool IsPointInFruit(Point point, Fruit fruit)
        //{
        //    // Простая проверка расстояния (для круглых фруктов)
        //    float dx = point.X - fruit.Center.X;
        //    float dy = point.Y - fruit.Center.Y;
        //    return (dx * dx + dy * dy) <= (fruit.Radius * fruit.Radius);
        //}



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (isSlicing && slicePoints.Count > 1)
            {
                using (var glowPen = new Pen(Color.FromArgb(100, 255, 255, 255), 4f))
                {
                    e.Graphics.DrawLines(glowPen, slicePoints.ToArray());
                }
            }
        }
    }
}
