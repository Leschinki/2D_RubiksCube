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
    public partial class Form1 : Form
    {
        public const int GRID_SIZE = 3;
        public int[,] grid;
        public Form1()
        {
            InitializeComponent();
            grid = new int[GRID_SIZE, GRID_SIZE];
        }

        private void setup()
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    grid[i, j] = i * GRID_SIZE + j;
                }
            }
        }

        private void MoveUp(object sender, EventArgs e)
        {

        }
        private void MoveRight(object sender, EventArgs e)
        {

        }
        private void MoveDown(object sender, EventArgs e)
        {

        }
        private void MoveLeft(object sender, EventArgs e)
        {

        }
        private void drawGrid(Graphics gr,Pen pen)
        {

            for (int i = 0; i < GRID_SIZE + 1; i++)
            {
                gr.DrawLine(pen, 0, i * _panel.Height / GRID_SIZE, _panel.Width, i * _panel.Height / GRID_SIZE);
            }
            for (int j = 0; j < GRID_SIZE + 1; j++)
            {
                gr.DrawLine(pen, j * _panel.Width / GRID_SIZE,0, j * _panel.Width / GRID_SIZE,_panel.Height);
            }
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawGrid(gr, new Pen(Brushes.Black, 3));
        }
    }
}
