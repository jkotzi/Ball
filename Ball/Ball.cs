using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ball
{
    class Ball
    {
        private int m_X, m_Y;
        private int m_SpeedX, m_SpeedY;
        private int m_Size;

        public Ball()
        {
            m_X = 0;
            m_Y = 0;
            m_SpeedX = 2;
            m_SpeedY = 2;
            m_Size = 5;
        }

        public void Update(Form frm)
        {
            m_X += m_SpeedX;
            m_Y += m_SpeedY;

            if (m_X <= 0 || m_X >= frm.ClientSize.Width - m_Size)
                m_SpeedX = -m_SpeedX;

            if (m_Y <= 0 || m_Y >= frm.ClientSize.Height - m_Size)
                m_SpeedY = -m_SpeedY;
        }

        public void Draw(Graphics g)
        {
            Pen myPen = new Pen(Brushes.DeepSkyBlue);
            g.DrawEllipse(myPen, m_X, m_Y, m_Size, m_Size);
        }
    }
}
