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
using PhysicsBallWinFormsLibrary;

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
        public static Random random = new Random();

        private List<Point> slicePoints = new List<Point>(); // Точки траектории разреза
        private bool isSlicing = false; // Флаг активного разреза

        public Graphics graphics;
        public Graphics sliceGraphics;

        public List<Ball> balls = new List<Ball>();

        public float G = 0.2f;

        public GameForm()
        {
            InitializeComponent();

            //// Включить двойную буферизацию для плавной анимации
            //this.DoubleBuffered = true;

            //// Для обработки событий мыши за пределами формы
            //this.Capture = true;

            graphics = CreateGraphics();
            sliceGraphics = CreateGraphics();
            paintSlice = new PaintEventArgs(sliceGraphics, new Rectangle());
            
            Ball.graphics = graphics;
            Ball.pen = new Pen(Color.Black);
            Ball.formPen = new Pen(BackColor);
            Ball.formBrush = new SolidBrush(BackColor);
            Ball.form = this;

            Fruit.ChangeScore = () => scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();
            Fruit.ChangeScoreNegative = () => scoreLabel.Text = (int.Parse(scoreLabel.Text) - 5).ToString();
            Bomb.ChangeScore = () => scoreLabel.Text = (int.Parse(scoreLabel.Text) - 5).ToString();

            switch (difficult) 
            {
                case Difficult.Easy: 
                    timer.Interval = 2000;
                    break;
                case Difficult.Middle: 
                    timer.Interval = 1000;
                    break;
                case Difficult.Hard: 
                    timer.Interval = 300;
                    break;
            }

            timer.Tick += CreateBall;

            timer.Start();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            user.Result = int.Parse(scoreLabel.Text);
            FileWorker.AddUser(user);
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
            for (int i = 0; i < balls.Count; i++)
            {
                // Проверка попадания точки в фрукт
                if ((balls[i] is Fruit || balls[i] is Bomb) && IsPointInBall(point, balls[i]))
                {
                    Fruit fruit = balls[i] as Fruit;
                    Bomb bomb = balls[i] as Bomb;

                    fruit?.Destroy();
                    bomb?.Destroy();

                    balls.Remove(balls[i]);
                    break;
                    // Логика разрубания фрукта
                    // Можно добавить визуальные эффекты
                }
            }
        }
        private bool IsPointInBall(Point point, Ball ball)
        {
            // Простая проверка расстояния (для круглых фруктов)
            float dx = point.X - ball.centerX;
            float dy = point.Y - ball.centerY;
            return (dx * dx + dy * dy) <= (ball.radius * ball.radius);
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            balls.ForEach(ball => ball.Show());

            if (isSlicing && slicePoints.Count > 1)
            {
                using (var pen = new Pen(Color.Coral, 4f))
                {
                    e.Graphics.DrawLines(pen, slicePoints.ToArray());
                }

                // Дополнительный эффект (опционально)
                using (var glowPen = new Pen(Color.FromArgb(80, 255, 255, 255), 10f))
                {
                    e.Graphics.DrawLines(glowPen, slicePoints.ToArray());
                }
            }
        }
        public void CreateBall(object sender, EventArgs e) 
        {
            int size = random.Next(30, 50);
            int x = random.Next(50, ClientSize.Width - 50 - size);
            int vx = random.Next(1, 4);

            if (x <= ClientSize.Width / 2)
                vx = -vx;

            if (random.Next(0, 4) == 0)
            {
                Bomb bomb = new Bomb(x, ClientSize.Height, size, vx, - random.Next(8, 15), G, Color.Black);
                bomb.Show();
                bomb.timer.Start();
                balls.Add(bomb);
            }
            else 
            {
                Fruit fruit = new Fruit(x, ClientSize.Height, size, vx, - random.Next(8, 15), G, Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                fruit.Show();
                fruit.timer.Start();
                balls.Add(fruit);
            }
        }
    }
}
