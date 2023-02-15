using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

        }

        private void Draw(double[] X, double[] Y)
        {
            int size = pictureBoxMain.Size.Width;
            Bitmap bitmap = new Bitmap(size, size);
            for (int i = 0; i < X.Length; i++)
            {
                bitmap.SetPixel((int)(size * X[i]), (int)(size * Y[i]), Color.Black);
            }
            pictureBoxMain.Image = bitmap;

        }

        private void generate_Click(object sender, EventArgs e)
        {
            generateX();
            Draw(X1, X2);
            
        }



        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            double k = (y2 - y1) / (x2 - x1);
            double b = y1 - k * x1;
            int size = pictureBoxGraf1.Size.Width;
            Bitmap bitmap = new Bitmap(size, size);
            for (int i = 0; i < 100; i++)
            {
                Y1[i] = k * X1[i] + b;
                if (Y1[i] < 1 && Y1[i] > 0)
                {
                    bitmap.SetPixel((int)(X1[i] * size), (int)(Y1[i] * size), Color.Black);
                }
                dataGridView1["dY1", i].Value = Y1[i];

            }
            pictureBoxGraf1.Image = bitmap;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScrolChanged1(object sender, EventArgs e)
        {
            int size = pictureBoxGraf1.Size.Width;
            Bitmap bitmap = new Bitmap(size, size);
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
                if (y < 1 && y > 0)
                {
                    bitmap.SetPixel((int)(i * size), (int)(y * size), Color.Black);
                }
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxGraf1.Image = bitmap;
            for (int i = 0; i < X1.Length; i++)
            {
                Y1[i] = ur1.GetY(X1[i]);
                dataGridView1["dY1", i].Value = Y1[i];
            }
            ref double[] refX = ref SwitchXY(comboBoxX.SelectedIndex);
            ref double[] refY = ref SwitchXY(comboBoxY.SelectedIndex);
            Draw(refX, refY);
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            ref double[] refX = ref SwitchXY(comboBoxX.SelectedIndex);
            ref double[] refY = ref SwitchXY(comboBoxY.SelectedIndex);
            Draw(refX, refY);
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
        return y;
    }
}
