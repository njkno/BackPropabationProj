using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Backpropagation_proj01
{
    public partial class Form1 : Form
    {
        SolidBrush clickBrush = new SolidBrush(Color.Black);
        bool start = false;
        private bool isclick = false;
        public int RecLength = 200;
        public int RecNum = 20;
        public List<Point> points = new List<Point>();
        public TrainingModel TrainingModel;

        public Form1()
        {
            InitializeComponent();
            trainning_panel.BackColor = Color.White;
            textBox1.Text = "輸入幾格大小(n*n)";
            SettingAllOutputBtn();
            TrainingModel = new TrainingModel(RecNum*RecNum, 0, 10);
        }

        private void SettingAllOutputBtn()
        {
            Output0.Click += TrainningBtn;
            Output1.Click += TrainningBtn;
            Output2.Click += TrainningBtn;
            Output3.Click += TrainningBtn;
            Output4.Click += TrainningBtn;
            Output5.Click += TrainningBtn;
            Output6.Click += TrainningBtn;
            Output7.Click += TrainningBtn;
            Output8.Click += TrainningBtn;
            Output9.Click += TrainningBtn;
        }

        private void Trainningpanel_MouseUp(object sender, MouseEventArgs e)
        {
            isclick = false;
            Graphics g = trainning_panel.CreateGraphics();
            var point = e.Location;
            point.X = point.X / 10 * 10;
            point.Y = point.Y / 10 * 10;
            g.FillRectangle(clickBrush, new Rectangle(point.X, point.Y, 10, 10));
            points.Add(point);
        }

        private void Trainningpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isclick)
            {
                Graphics g = trainning_panel.CreateGraphics();
                var point = e.Location;
                point.X = point.X / 10 * 10;
                point.Y = point.Y / 10 * 10;
                g.FillRectangle(clickBrush, new Rectangle(point.X, point.Y, 10, 10));
                points.Add(point);
            }
        }

        private void Trainningpanel_MouseDown(object sender, MouseEventArgs e)
        {
            isclick = true;
            Graphics g = trainning_panel.CreateGraphics();
            var point = e.Location;
            point.X = point.X / 10 * 10;
            point.Y = point.Y / 10 * 10;
            g.FillRectangle(clickBrush, new Rectangle(point.X, point.Y, 10, 10));
            points.Add(point);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = true;
            if (textBox1.Text != "")
            {
                RecLength = Convert.ToInt32(textBox1.Text);
                trainning_panel.Height = RecLength;
                trainning_panel.Width = RecLength;
                var g = trainning_panel.CreateGraphics();
                var pen = new Pen(Color.Black, 1);

                for (int i = 0; i < RecLength; i = i + 10)
                {
                    g.DrawLine(pen, i, 0, i, RecLength);
                    g.DrawLine(pen, 0, i, RecLength, i);
                }
            }
        }

        private void ShowMe_Click(object sender, EventArgs e)
        {
            points = points.Distinct().ToList();

            foreach (var point in points)
            {
                richTextBox1.Text += $"X={point.X}  Y={point.Y}\n"; ;
            }
            richTextBox1.Text += "===================================\n";
            //richTextBox1.Text = Math.E.ToString();
        }

        private void Trainningpanel_Paint(object sender, PaintEventArgs e)
        {
            trainning_panel.Height = RecLength;
            trainning_panel.Width = RecLength;
            var g = trainning_panel.CreateGraphics();
            var pen = new Pen(Color.Black, 1);

            for (int i = 0; i < RecLength; i = i + 10)
            {
                g.DrawLine(pen, i, 0, i, RecLength);
                g.DrawLine(pen, 0, i, RecLength, i);
            }
        }

        private void TestingPanel_Paint(object sender, PaintEventArgs e)
        {
            trainning_panel.Height = RecLength;
            trainning_panel.Width = RecLength;
            var g = TestingPanel.CreateGraphics();
            var pen = new Pen(Color.Black, 1);

            for (int i = 0; i < RecLength; i = i + 10)
            {
                g.DrawLine(pen, i, 0, i, RecLength);
                g.DrawLine(pen, 0, i, RecLength, i);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void ClearMethod()
        {
            points.Clear();
            trainning_panel.Refresh();
            Trainningpanel_Paint(null, null);
        }
        private void TrainningBtn(object sender, EventArgs e)
        {
            var Trainningbutton = sender as Button;
            var intputNodes = CollectionInputNodes();
            var actualArray = new decimal[10];
            actualArray[Trainningbutton.Name.Last() - 48] = 1;
            if (Trainningbutton != null)
                TrainingModel.Trainning(intputNodes, actualArray);
            ClearMethod();
        }

        private Decimal[] CollectionInputNodes()
        {
            points = points.Distinct().ToList();
            var inputNodes = new decimal[RecNum*RecNum];
            for (int i = 0; i < RecNum; i++)
            {
                for (int j = 0; j < RecNum; j++)
                {
                    if (points.Any(x => x.X == j * 10 && x.Y == i * 10))
                    {
                        inputNodes[i * RecNum + j] = 1;
                    }
                }
            }

            return inputNodes;
        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            var ans = TrainingModel.OutputModel(CollectionInputNodes());
            for (var i = 0; i < ans.Length; i++)
            {
                var element = ans[i];
                AnswerBox.Text += i+"  "+element.ToString() + "\n";
            }
            AnswerBox.Text += "============================\n";
        }
    }
}


