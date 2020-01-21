using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace TTT
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        public Form1()
        {
            InitializeComponent();
            w = glControl1.Width;
            h = glControl1.Height;
        }
        static int w = 0;
        static int h = 0;
        static int m = 10;
        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
                return;
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.SkyBlue);
            int w = glControl1.Width;
            int h = glControl1.Height;
            GL.MatrixMode(MatrixMode.Projection); 
            GL.LoadIdentity(); 
            GL.Ortho(0, w, 0, h, -1, 1); 
            GL.Viewport(0, 0, w, h); 
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview); 
            GL.LoadIdentity(); 
            GL.Color3(Color.Black);
            GL.Begin(BeginMode.Lines);
            GL.Vertex2(w/2, 0);
            GL.Vertex2(w/2, h);
            GL.Vertex2(0, h/2);
            GL.Vertex2(w, h/2);
            GL.End();
            GL.Begin(BeginMode.Lines);
            for (int i = 0; i < w / 2; i += 1 * m)
            {
                GL.Vertex2(w / 2 + i, h / 2 + 2);
                GL.Vertex2(w / 2 + i, h / 2 - 2);
                GL.Vertex2(w / 2 - i, h / 2 + 2);
                GL.Vertex2(w / 2 - i, h / 2 - 2);
            }
            for (int i = 0; i < h / 2; i += 1 * m)
            {
                GL.Vertex2(w / 2 + 2, h / 2 + i);
                GL.Vertex2(w / 2 - 2, h / 2 + i);
                GL.Vertex2(w / 2 + 2, h / 2 - i);
                GL.Vertex2(w / 2 - 2, h / 2 - i);
            }
            GL.End();
            /*GL.Begin(BeginMode.Points);
            GL.Color3(Color.Red);
            for (double i = -w / 2; i < w / 2; i += 0.005)
                GL.Vertex2(w / 2 + i*m, h / 2 + Math.Sin(i)*m);
            GL.End();*/ //по точкам
            GL.Begin(BeginMode.LineStrip);
            GL.Color3(Color.Red);
            int n;
            double a, b, dx, x, y;
            a = -1.415;
            b = 1.5;
            n = 100;
            dx = (b - a) / (n - 1);
            x = -50;
            y = 50;
            for (double i = -5000; i <= n; i++)
            {
                y = -x * (x - 7)/50+10;
                GL.Vertex2(w / 2 + x * m, h / 2 + y * m);
                x = x + dx;
            }
            GL.End();
            //-------------------------
            GL.Finish();
            glControl1.SwapBuffers();
        }
        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                m++;
                glControl1.Invalidate();
            }
            if (e.KeyCode == Keys.A) 
            {
                m--;
                glControl1.Invalidate();
            }
        }
    }
}
