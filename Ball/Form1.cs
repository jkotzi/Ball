using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ball
{
    public partial class MainForm : Form
    {
        Ball m_Ball;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            m_Ball = new Ball();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            m_Ball.Draw(e.Graphics);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            m_Ball.Update(this);
            Invalidate();
        }
    }
}
