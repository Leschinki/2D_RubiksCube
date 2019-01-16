using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_RubiksCube
{
    public partial class _MainForm : Form
    {
        public int GRID_SIZE = 0;
        public int CELLSIZE = 0;
        public const int PANELSIZE = 1000;
        public const int MARGIN = 10;
        public const int BUTTONTHICKNESS = 50;
        public int[,] grid;
        public Bitmap[] BACKGROUND;
        Bitmap BACKGROUNDFULL;
        Startscreen start = new Startscreen();
        public Panel _panel;
        public _MainForm()
        {
            start.ShowDialog();
            if (start.DialogResult.Equals(DialogResult.Cancel))
                System.Environment.Exit(1);
            GRID_SIZE = start.GRIDSIZE;
            BACKGROUND = new Bitmap[GRID_SIZE * GRID_SIZE];
            InitializeComponent();
            grid = new int[GRID_SIZE, GRID_SIZE];
            CELLSIZE = PANELSIZE / GRID_SIZE;      
            BACKGROUNDFULL = new Bitmap(Image.FromFile(start.ImagePath), PANELSIZE, PANELSIZE);
            this.Size = new Size(PANELSIZE + 150, PANELSIZE + 150);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            setup();
        }

        private void setup()
        {
            CreateFormElements();
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    grid[j, i] = i * GRID_SIZE + j + 1;
                }
            }
            System.Drawing.Imaging.PixelFormat format = BACKGROUNDFULL.PixelFormat;
            Rectangle cloneRect;
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    cloneRect = new Rectangle(j * CELLSIZE, i * CELLSIZE, PANELSIZE / GRID_SIZE, PANELSIZE / GRID_SIZE);

                    BACKGROUND[i * GRID_SIZE + j] = BACKGROUNDFULL.Clone(cloneRect, format);
                }
            }

        }

        private void CreateFormElements()
        {
            Button verticalButton;
            Button horizontalButton;
            _panel = new Panel();
            _panel.Size = new Size(PANELSIZE, PANELSIZE);
            _panel.Location = new Point(MARGIN + BUTTONTHICKNESS, MARGIN + BUTTONTHICKNESS);
            _panel.Paint += new PaintEventHandler(OnPaint);
            this.Controls.Add(_panel);
            for (int i = 0; i < GRID_SIZE; i++)
            {
                verticalButton = new Button();
                verticalButton.Name = $"_btnRow{i}Left";
                verticalButton.Size = new Size(BUTTONTHICKNESS, PANELSIZE / GRID_SIZE);
                verticalButton.Location = new Point(MARGIN, MARGIN + i * (PANELSIZE / GRID_SIZE) + BUTTONTHICKNESS);
                verticalButton.Text = "<";
                verticalButton.Click += new EventHandler(MoveLeft);
                this.Controls.Add(verticalButton);
            }

            for (int i = 0; i < GRID_SIZE; i++)
            {
                verticalButton = new Button();
                verticalButton.Name = $"_btnRow{i}Right";
                verticalButton.Size = new Size(BUTTONTHICKNESS, PANELSIZE / GRID_SIZE);
                verticalButton.Location = new Point(MARGIN + PANELSIZE + BUTTONTHICKNESS, MARGIN + i * (PANELSIZE / GRID_SIZE) + BUTTONTHICKNESS);
                verticalButton.Text = ">";
                verticalButton.Click += new EventHandler(MoveRight);
                this.Controls.Add(verticalButton);
            }

            for (int j = 0; j < GRID_SIZE; j++)
            {
                horizontalButton = new Button();
                horizontalButton.Name = $"_btnColumn{j}Up";
                horizontalButton.Size = new Size(PANELSIZE / GRID_SIZE, BUTTONTHICKNESS);
                horizontalButton.Location = new Point(MARGIN + j * (PANELSIZE / GRID_SIZE) + BUTTONTHICKNESS, MARGIN);
                horizontalButton.Text = "+";
                horizontalButton.Click += new EventHandler(MoveUp);
                this.Controls.Add(horizontalButton);
            }

            for (int j = 0; j < GRID_SIZE; j++)
            {
                horizontalButton = new Button();
                horizontalButton.Name = $"_btnColumn{j}Down";
                horizontalButton.Size = new Size(PANELSIZE / GRID_SIZE, BUTTONTHICKNESS);
                horizontalButton.Location = new Point(MARGIN + j * (PANELSIZE / GRID_SIZE) + BUTTONTHICKNESS, MARGIN + PANELSIZE + BUTTONTHICKNESS);
                horizontalButton.Text = "-";
                horizontalButton.Click += new EventHandler(MoveDown);
                this.Controls.Add(horizontalButton);
            }
        }
        private void MoveUp(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int column = Convert.ToInt32(button.Name.Replace("_btnColumn", "").Replace("Up", ""));
            for (int i = 1; i < GRID_SIZE; i++)
            {
                Swap<int>(ref grid[column, i], ref grid[column, i - 1]);
            }
            _panel.Invalidate();
        }
        private void MoveDown(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int column = Convert.ToInt32(button.Name.Replace("_btnColumn", "").Replace("Down", ""));
            for (int i = GRID_SIZE - 1; i > 0; i--)
            {
                Swap<int>(ref grid[column, i], ref grid[column, i - 1]);
            }
            _panel.Invalidate();
        }
        private void MoveRight(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int row = Convert.ToInt32(button.Name.Replace("_btnRow", "").Replace("Right", ""));
            for (int i = GRID_SIZE-1; i > 0; i--)
            {
                Swap<int>(ref grid[i, row], ref grid[i-1, row]);
            }
            _panel.Invalidate();
        }
        private void MoveLeft(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int row = Convert.ToInt32(button.Name.Replace("_btnRow", "").Replace("Left", ""));
            for (int i = 1; i < GRID_SIZE; i++)
            {
                Swap<int>(ref grid[i, row], ref grid[i - 1, row]);
            }
            _panel.Invalidate();
        }
        private void drawGrid(Graphics gr, Pen pen)
        {

            for (int i = 0; i < GRID_SIZE + 1; i++)
            {
                gr.DrawLine(pen, 0, i * _panel.Height / GRID_SIZE, _panel.Width, i * _panel.Height / GRID_SIZE);
            }
            for (int j = 0; j < GRID_SIZE + 1; j++)
            {
                gr.DrawLine(pen, j * _panel.Width / GRID_SIZE, 0, j * _panel.Width / GRID_SIZE, _panel.Height);
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawGrid(gr, new Pen(Brushes.Black, 3));
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    gr.DrawImage(BACKGROUND[grid[i, j] - 1], i * CELLSIZE, j * CELLSIZE);
                    //gr.DrawString(grid[i, j].ToString(), Font, Brushes.Black, i * CELLSIZE + (CELLSIZE / 2), j * CELLSIZE + (CELLSIZE / 2));
                }
            }
        }
        private void Swap<T>(ref T a, ref T b)
        {
            var x = a;
            a = b;
            b = x;
        }
    }
}
