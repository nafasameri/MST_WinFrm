using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MST_WinFrm
{
    public partial class frmMST : Form
    {
        private int NumOfVertices;
        Dictionary<int, Point> Vertices = new Dictionary<int, Point>();
        int[,] Weight;
        Label[,] l;
        bool[,] State;
        MST mst;

        public frmMST()
        {
            InitializeComponent();
        }

        #region Drag And Drop
        private bool draging = false;
        private Point dragingPoint;
        private int dragingPointIndex;
        private void PnlShowGraph_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var p in Vertices)
            {
                if (p.Value.X + 10 >= e.X && p.Value.X - 10 <= e.X)
                {
                    if (p.Value.Y + 10 >= e.Y && p.Value.Y - 10 <= e.Y)
                    {
                        Cursor = Cursors.SizeAll;
                        draging = true;
                        dragingPointIndex = p.Key;
                        return;
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void PnlShowGraph_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
            Cursor = Cursors.Default;
        }

        private void PnlShowGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                dragingPoint = Vertices[dragingPointIndex];
                dragingPoint.X = e.X;
                dragingPoint.Y = e.Y;
                Vertices[dragingPointIndex] = dragingPoint;
                if (sender == pnlShowGraph)
                    DrawGraph();
                if (sender == pnlPrim)
                    DrawTree(pnlPrim);
                if (sender == pnlKruskal)
                    DrawTree(pnlKruskal);
                if (sender == pnlSollin)
                    DrawTree(pnlSollin);
            }
        }
        #endregion

        #region Draw Graph
        private void SetLocationVertices()
        {
            Point[] points = new Point[15];
            points[0] = new Point(380, 30);
            points[1] = new Point(180, 30);
            points[2] = new Point(50, 180);
            points[3] = new Point(50, 330);
            points[4] = new Point(180, 460);
            points[5] = new Point(380, 460);
            points[6] = new Point(510, 330);
            points[7] = new Point(510, 180);
            points[8] = new Point(280, 90);
            points[9] = new Point(150, 150);
            points[10] = new Point(400, 150);
            points[11] = new Point(150, 350);
            points[12] = new Point(400, 350);
            points[13] = new Point(280, 420);
            points[14] = new Point(280, 255);

            /// Creat Vertices      
            for (int i = 0; i < NumOfVertices; i++)
                try { Vertices.Add(i, points[i]); } catch { }
        }
        
        private void DrawGraph()
        {
            Graphics g = pnlShowGraph.CreateGraphics();
            g.Clear(pnlShowGraph.BackColor);

            /// set weight edge in desgin
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (Weight[i, j] != 0)
                    {
                        pnlShowGraph.Controls.Add(l[i, j]);
                        l[i, j].BackColor = Color.Transparent;
                        l[i, j].Text = Weight[i, j].ToString();
                        l[i, j].Location = new Point((Vertices[i].X + Vertices[j].X) / 2, (Vertices[i].Y + Vertices[j].Y) / 2);
                        l[i, j].AutoSize = true;

                        /// draw lines
                        g.DrawLine(new Pen(Color.DarkCyan), Vertices[i], Vertices[j]);
                    }

            /// draw nodes and indexs
            foreach (var item in Vertices)
            {
                g.FillEllipse(new SolidBrush(Color.PaleVioletRed), item.Value.X - 10, item.Value.Y - 10, 20, 20);
                g.DrawString(item.Key.ToString(), new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.DarkViolet), item.Value);
            }
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            pnlShowGraph.Visible = true;
            pnlGetGraph.Visible = false;
            pnlSollin.Visible = false;
            pnlKruskal.Visible = false;
            pnlPrim.Visible = false;
            DrawGraph();
        }
        #endregion

        #region Draw Minimum Spanning Tree
        private void DrawTree(Control element)
        {
            Graphics g = element.CreateGraphics();
            g.Clear(element.BackColor);

            /// set weight edge in desgin
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (State[i, j])
                    {
                        element.Controls.Add(l[i, j]);
                        l[i, j].BackColor = Color.Transparent;
                        l[i, j].Text = Weight[i, j].ToString();
                        l[i, j].Location = new Point((Vertices[i].X + Vertices[j].X) / 2, (Vertices[i].Y + Vertices[j].Y) / 2);
                        l[i, j].AutoSize = true;

                        /// draw lines
                        g.DrawLine(new Pen(Color.DarkOrchid), Vertices[i], Vertices[j]);
                    }
            /// draw nodes and indexs
            foreach (var item in Vertices)
            {
                g.FillEllipse(new SolidBrush(Color.Olive), item.Value.X - 10, item.Value.Y - 10, 20, 20);
                g.DrawString(item.Key.ToString(), new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.DarkViolet), item.Value);
            }
        }
        #endregion

        #region Controls
        private void btnOK_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumOfVertices.Text, out NumOfVertices);
            MessageBox.Show("Successfull saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.ClientSize = new Size(700, 535);
            pnlStatrt.Visible = false;

            SetLocationVertices();
            State = new bool[NumOfVertices, NumOfVertices];
            Weight = new int[NumOfVertices, NumOfVertices];
            /// creat weight's edge
            l = new Label[NumOfVertices, NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                {
                    l[i, j] = new Label();
                    pnlShowGraph.Controls.Add(l[i, j]);
                }

            for (int i = 0; i < NumOfVertices; i++)
            {
                cmbFromPoint.Items.AddRange(new object[] { i });
                cmbToPoint.Items.AddRange(new object[] { i });
            }
        }

        private void btnGetGraph_Click(object sender, EventArgs e)
        {
            pnlGetGraph.Visible = true;
            pnlShowGraph.Visible = false;
            pnlSollin.Visible = false;
            pnlKruskal.Visible = false;
            pnlPrim.Visible = false;
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    Weight[i, j] = 0;
        }

        private void btnSaveWeight_Click(object sender, EventArgs e)
        {
            int.TryParse(txtWeight.Text, out Weight[cmbFromPoint.SelectedIndex, cmbToPoint.SelectedIndex]);
            //int.TryParse(txtWeight.Text, out Weight[cmbToPoint.SelectedIndex, cmbFromPoint.SelectedIndex]);
            cmbFromPoint.Text = string.Empty;
            cmbToPoint.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit this program?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnSolin_Click(object sender, EventArgs e)
        {
            pnlShowGraph.Visible = false;
            pnlGetGraph.Visible = false;
            pnlSollin.Visible = true;
            pnlKruskal.Visible = false;
            pnlPrim.Visible = false;
            mst = new MST(NumOfVertices, Weight);
            mst.Sollin(ref State);
            DrawTree(pnlSollin);
        }
        private void btnKruskal_Click(object sender, EventArgs e)
        {
            pnlShowGraph.Visible = false;
            pnlGetGraph.Visible = false;
            pnlSollin.Visible = false;
            pnlKruskal.Visible = true;
            pnlPrim.Visible = false;
            mst = new MST(NumOfVertices, Weight);
            mst.Kruskal(ref State);
            DrawTree(pnlKruskal);
        }
        private void btnPrim_Click(object sender, EventArgs e)
        {
            pnlShowGraph.Visible = false;
            pnlGetGraph.Visible = false;
            pnlSollin.Visible = false;
            pnlKruskal.Visible = false;
            pnlPrim.Visible = true;
            mst = new MST(NumOfVertices, Weight);
            mst.Prim(ref State);
            DrawTree(pnlPrim);
        }
        #endregion
    }
}