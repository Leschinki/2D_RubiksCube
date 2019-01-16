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
        public int CELLSIZE = 0;
        public int[,] grid;
        public Form1()
        {
            InitializeComponent();
            grid = new int[GRID_SIZE, GRID_SIZE];
            CELLSIZE = _panel.Height / GRID_SIZE;
            setup();
        }

        private void setup()
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    grid[j, i] = i * GRID_SIZE + j +1;
                }
            }
        }

        private void MoveUp(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "_btnColumn1Up":
                    Swap<int>(ref grid[0, 0], ref grid[0, 1]);
                    Swap<int>(ref grid[0, 1], ref grid[0, 2]);
                    break;
                case "_btnColumn2Up":
                    Swap<int>(ref grid[1, 0], ref grid[1, 1]);
                    Swap<int>(ref grid[1, 1], ref grid[1, 2]);
                    break;
                case "_btnColumn3Up":
                    Swap<int>(ref grid[2, 0], ref grid[2, 1]);
                    Swap<int>(ref grid[2, 1], ref grid[2, 2]);
                    break;
            }
            _panel.Invalidate();
        }
        private void MoveRight(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch(button.Name)
            {
                case "_btnRow1Right":
                    Swap<int>(ref grid[2, 0],ref grid[1, 0]);
                    Swap<int>(ref grid[1, 0], ref grid[0, 0]);
                    break;
                case "_btnRow2Right":
                    Swap<int>(ref grid[2, 1], ref grid[1, 1]);
                    Swap<int>(ref grid[1, 1], ref grid[0, 1]);
                    break;
                case "_btnRow3Right":
                    Swap<int>(ref grid[2, 2], ref grid[1, 2]);
                    Swap<int>(ref grid[1, 2], ref grid[0, 2]);
                    break;
            }
            _panel.Invalidate();
        }
        private void MoveDown(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "_btnColumn1Down":
                    Swap<int>(ref grid[0, 2], ref grid[0, 1]);
                    Swap<int>(ref grid[0, 1], ref grid[0, 0]);
                    break;
                case "_btnColumn2Down":
                    Swap<int>(ref grid[1, 2], ref grid[1, 1]);
                    Swap<int>(ref grid[1, 1], ref grid[1, 0]);
                    break;
                case "_btnColumn3Down":
                    Swap<int>(ref grid[2, 2], ref grid[2, 1]);
                    Swap<int>(ref grid[2, 1], ref grid[2, 0]);
                    break;
            }
            _panel.Invalidate();
        }
        private void MoveLeft(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "_btnRow1Left":
                    Swap<int>(ref grid[0, 0], ref grid[1, 0]);
                    Swap<int>(ref grid[1, 0], ref grid[2, 0]);
                    break;
                case "_btnRow2Left":
                    Swap<int>(ref grid[0, 1], ref grid[1, 1]);
                    Swap<int>(ref grid[1, 1], ref grid[2, 1]);
                    break;
                case "_btnRow3Left":
                    Swap<int>(ref grid[0, 2], ref grid[1, 2]);
                    Swap<int>(ref grid[1, 2], ref grid[2, 2]);
                    break;
            }
            _panel.Invalidate();
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
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    gr.DrawString(grid[i, j].ToString(), Font, Brushes.Black, i * CELLSIZE + (CELLSIZE / 2), j * CELLSIZE + (CELLSIZE / 2));
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
