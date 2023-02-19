using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace L1_визуализация_графика
{
    public partial class Form1 : Form
    {
        public double[] X1;
        public double[] Y1;
        public double[] X2;
        public double[] Y2;
        public Form1()
        {
            InitializeComponent();
            generateX();
            comboBoxX.SelectedIndex = 0;
            comboBoxY.SelectedIndex = 1;
            DrawGraf1();
            DrawGraf2();
        }

        public void generateX()
        {
            Random random = new Random();
            X1 = new double[(int)UpDownCout.Value];
            X2 = new double[(int)UpDownCout.Value];
            Y1 = new double[(int)UpDownCout.Value];
            Y2 = new double[(int)UpDownCout.Value];
            dataGridView1.Rows.Clear();
            for (int i = 0; i < UpDownCout.Value; i++)
            {
                X1[i] = random.NextDouble();
                X2[i] = random.NextDouble();
                dataGridView1.Rows.Add();
                dataGridView1["dX1", i].Value = X1[i];
                dataGridView1["dX2", i].Value = X2[i];
            }
            DrawGraf1();
            DrawGraf2();
        }

        private void Draw()
        {
            double[] refX = SwitchXY(comboBoxX.SelectedIndex);
            double[] refY = SwitchXY(comboBoxY.SelectedIndex);
            int size = pictureBoxMain.Size.Width;
            size--;
            Bitmap bitmap = new Bitmap(size, size);
            using (Graphics gXY = Graphics.FromImage(bitmap)) {
                gXY.Clear(Color.White);
                int[,] XYbar = new int[10, 10];

                for (int i = 0; i < refX.Length; i++)
                {
                    XYbar[(int)(refX[i] * 10), (int)(refY[i] * 10)]++;
                }
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        
                        Brush brush = new SolidBrush(Color.FromArgb(255-XYbar[x, y]*250/ refY.Length,
                           255-XYbar[x, y] * 250 / refY.Length,
                           255));
                        gXY.FillRectangle(brush, x * 20, y * 20, 20, 20);
                    }
                }
            }

            for (int i = 0; i < refX.Length; i++)
            {
                bitmap.SetPixel((int)(size * refX[i]), (int)(size * refY[i]), Color.Black);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxMain.Image = bitmap;

            int[] Xbar= new int[10];
            foreach (double x in refX)
            {
                Xbar[(int)(x*10)]++;
            }
            Graphics gX = pictureBoxX.CreateGraphics();
            gX.Clear(Color.White);
            for (int i=0; i<10; i++)
            {
                gX.FillRectangle(Brushes.Green, i * 20 + 1,0, 8,(float)((double)(Xbar[i]) / refX.Length) * 50);
            }

            int[] Ybar = new int[10];
            foreach (double y in refY)
            {
                Ybar[(int)(y * 10)]++;

            }
            Graphics gY = pictureBoxY.CreateGraphics();
            gY.Clear(Color.White);
            for (int i = 0; i < 10; i++)
            {
                gY.FillRectangle(Brushes.Green, 0, (10 - i) * 20 + 1, (float)((double)(Ybar[i]) / refY.Length) * 50, 8);
            }
            double meanX = refX.Sum() / refX.Length;
            double meanY = refX.Sum() / refY.Length;
            Xaverage.Text = meanX.ToString("F5");
            Yaverage.Text = meanY.ToString("F5");
            double XstdDev = Math.Sqrt(refX.Select(x => (x - meanX) * (x - meanX)).Sum() / (refX.Length - 1));
            double YstdDev = Math.Sqrt(refY.Select(y => (y - meanX) * (y - meanX)).Sum() / (refY.Length - 1));
            stdDevX.Text = XstdDev.ToString("F5");
            stdDevY.Text = YstdDev.ToString("F5");
            double Xmode = refX.GroupBy(x => x)
                          .OrderByDescending(g => g.Count())
                          .First()
                          .Key;
            double Ymode = refY.GroupBy(x => x)
                          .OrderByDescending(g => g.Count())
                          .First()
                          .Key;
            modeX.Text = Xmode.ToString("F5");
            modeY.Text = Ymode.ToString("F5");
            double Xmedian = refX.OrderBy(x => x).Skip((refX.Length - 1) / 2).Take(2 - refX.Length % 2).Average();
            double Ymedian = refY.OrderBy(x => x).Skip((refY.Length - 1) / 2).Take(2 - refY.Length % 2).Average();
            medianX.Text = Xmedian.ToString("F5");
            medianY.Text = Ymedian.ToString("F5");  
        }





        private void generate_Click(object sender, EventArgs e)
        {
            generateX();
            Draw();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScrolChanged1(object sender, EventArgs e)
        {
            DrawGraf1();
        }
        private void DrawGraf1()
        {
            int size = pictureBoxGraf1.Size.Width;
            Bitmap bitmap = new Bitmap(size, size);
            size--;
            LineUr ur1 = new LineUr(
                (double)(100 - vScrollBar1_0.Value) / 100d,
                (double)(100 - vScrollBar1_25.Value) / 100d,
                (double)(100 - vScrollBar1_50.Value) / 100d,
                (double)(100 - vScrollBar1_75.Value) / 100d,
                (double)(100 - vScrollBar1_100.Value) / 100d
                );
            for (double i = 0; i < 1; i += 0.001d)
            {
                double y = ur1.GetY(i);
                bitmap.SetPixel((int)(i * size), (int)(y * size), Color.Black);

            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxGraf1.Image = bitmap;
            for (int i = 0; i < X1.Length; i++)
            {
                Y1[i] = ur1.GetY(X1[i]);
                dataGridView1["dY1", i].Value = Y1[i];
            }
            if (comboBoxX.SelectedIndex == 2 || comboBoxY.SelectedIndex == 2)
            {
                Draw();
            }
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private ref double [] SwitchXY(int CB)
        {
            switch (CB)
            {
                case 0:
                    return ref X1;
                    break;
                case 1:
                    return ref X2;
                    break;
                case 2:
                    return ref Y1;
                    break;
                case 3:
                    return ref Y2;
                    break;
                default:
                    return ref X1;
            }
        }

        private void ScrolChanged2(object sender, EventArgs e)
        {
            DrawGraf2();
        }
        private void DrawGraf2()
        { 
                    int size = pictureBoxGraf2.Size.Width;
            Bitmap bitmap = new Bitmap(size, size);
            size--;
            LineUr ur2 = new LineUr(
                (double)(100 - vScrollBar2_0.Value) / 100d,
                (double)(100 - vScrollBar2_25.Value) / 100d,
                (double)(100 - vScrollBar2_50.Value) / 100d,
                (double)(100 - vScrollBar2_75.Value) / 100d,
                (double)(100 - vScrollBar2_100.Value) / 100d
                );
            for (double i = 0; i < 1; i += 0.001d)
            {
                double y = ur2.GetY(i);

                    bitmap.SetPixel((int)(i * size), (int)(y * size), Color.Black);
                
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxGraf2.Image = bitmap;
            for (int i = 0; i < X2.Length; i++)
            {
                Y2[i] = ur2.GetY(X2[i]);
                dataGridView1["dY2", i].Value = Y2[i];
            }
            if (comboBoxX.SelectedIndex ==3|| comboBoxY.SelectedIndex == 3)
            {
                Draw();
            }
        }


            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

public class LineUr
{
    double k1;
    double k2;
    double k3;
    double k4;
    double b1;
    double b2;
    double b3;
    double b4;
    public LineUr(double y1, double y2, double y3, double y4, double y5)
    {

        k1 = (y2 - y1) / (0.25 - 0);
        b1 = y1;

        k2 = (y3 - y2) / (0.5 - 0.25);
        b2 = y2 - k2 * 0.25;

        k3 = (y4 - y3) / (0.75 - 0.5);
        b3 = y3 - k3 * 0.5;

        k4 = (y5 - y4) / (1 - 0.75);
        b4 = y4 - k4 * 0.75;

    }
    public double GetY(double x)
    {
        double y;
        if (x < 0.25)
        {
            y = k1 * x + b1;
        }
        else if (x < 0.5)
        {
            y = k2 * x + b2;
        }
        else if (x < 0.75)
        {
            y = k3 * x + b3;
        }
        else
        {
            y = k4 * x + b4;
        }
        if (!(y < 1))
        {
            y =0.99999;
        }
        return y;
    }
}
