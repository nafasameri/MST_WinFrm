namespace MST_WinFrm
{
    partial class frmMST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMST));
            this.btnGetGraph = new System.Windows.Forms.Button();
            this.btnKruskal = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnSollin = new System.Windows.Forms.Button();
            this.pnlStatrt = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOfVertices = new System.Windows.Forms.TextBox();
            this.pnlShowGraph = new System.Windows.Forms.Panel();
            this.pnlKruskal = new System.Windows.Forms.Panel();
            this.pnlGetGraph = new System.Windows.Forms.Panel();
            this.btnSaveWeight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbToPoint = new System.Windows.Forms.ComboBox();
            this.cmbFromPoint = new System.Windows.Forms.ComboBox();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPrim = new System.Windows.Forms.Panel();
            this.pnlSollin = new System.Windows.Forms.Panel();
            this.pnlStatrt.SuspendLayout();
            this.pnlGetGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetGraph
            // 
            this.btnGetGraph.Location = new System.Drawing.Point(12, 16);
            this.btnGetGraph.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnGetGraph.Name = "btnGetGraph";
            this.btnGetGraph.Size = new System.Drawing.Size(110, 50);
            this.btnGetGraph.TabIndex = 0;
            this.btnGetGraph.Text = "Get Graph";
            this.btnGetGraph.UseVisualStyleBackColor = true;
            this.btnGetGraph.Click += new System.EventHandler(this.btnGetGraph_Click);
            // 
            // btnKruskal
            // 
            this.btnKruskal.Location = new System.Drawing.Point(12, 144);
            this.btnKruskal.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnKruskal.Name = "btnKruskal";
            this.btnKruskal.Size = new System.Drawing.Size(110, 50);
            this.btnKruskal.TabIndex = 2;
            this.btnKruskal.Text = "Kruskal";
            this.btnKruskal.UseVisualStyleBackColor = true;
            this.btnKruskal.Click += new System.EventHandler(this.btnKruskal_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(12, 208);
            this.btnPrim.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(110, 50);
            this.btnPrim.TabIndex = 3;
            this.btnPrim.Text = "Prim";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnSollin
            // 
            this.btnSollin.Location = new System.Drawing.Point(12, 272);
            this.btnSollin.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSollin.Name = "btnSollin";
            this.btnSollin.Size = new System.Drawing.Size(110, 50);
            this.btnSollin.TabIndex = 4;
            this.btnSollin.Text = "Sollin";
            this.btnSollin.UseVisualStyleBackColor = true;
            this.btnSollin.Click += new System.EventHandler(this.btnSolin_Click);
            // 
            // pnlStatrt
            // 
            this.pnlStatrt.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatrt.Controls.Add(this.btnOK);
            this.pnlStatrt.Controls.Add(this.label1);
            this.pnlStatrt.Controls.Add(this.txtNumOfVertices);
            this.pnlStatrt.Location = new System.Drawing.Point(0, 0);
            this.pnlStatrt.Name = "pnlStatrt";
            this.pnlStatrt.Size = new System.Drawing.Size(347, 193);
            this.pnlStatrt.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(122, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the number of vertices of the graph";
            // 
            // txtNumOfVertices
            // 
            this.txtNumOfVertices.BackColor = System.Drawing.Color.Tan;
            this.txtNumOfVertices.Location = new System.Drawing.Point(122, 76);
            this.txtNumOfVertices.Name = "txtNumOfVertices";
            this.txtNumOfVertices.Size = new System.Drawing.Size(100, 27);
            this.txtNumOfVertices.TabIndex = 0;
            // 
            // pnlShowGraph
            // 
            this.pnlShowGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlShowGraph.Location = new System.Drawing.Point(139, 14);
            this.pnlShowGraph.Name = "pnlShowGraph";
            this.pnlShowGraph.Size = new System.Drawing.Size(560, 507);
            this.pnlShowGraph.TabIndex = 4;
            this.pnlShowGraph.Visible = false;
            this.pnlShowGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseDown);
            this.pnlShowGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseMove);
            this.pnlShowGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseUp);
            // 
            // pnlKruskal
            // 
            this.pnlKruskal.Location = new System.Drawing.Point(139, 14);
            this.pnlKruskal.Name = "pnlKruskal";
            this.pnlKruskal.Size = new System.Drawing.Size(560, 507);
            this.pnlKruskal.TabIndex = 2;
            this.pnlKruskal.Visible = false;
            this.pnlKruskal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseDown);
            this.pnlKruskal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseMove);
            this.pnlKruskal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseUp);
            // 
            // pnlGetGraph
            // 
            this.pnlGetGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlGetGraph.Controls.Add(this.btnSaveWeight);
            this.pnlGetGraph.Controls.Add(this.label4);
            this.pnlGetGraph.Controls.Add(this.txtWeight);
            this.pnlGetGraph.Controls.Add(this.label3);
            this.pnlGetGraph.Controls.Add(this.label2);
            this.pnlGetGraph.Controls.Add(this.cmbToPoint);
            this.pnlGetGraph.Controls.Add(this.cmbFromPoint);
            this.pnlGetGraph.Location = new System.Drawing.Point(139, 14);
            this.pnlGetGraph.Name = "pnlGetGraph";
            this.pnlGetGraph.Size = new System.Drawing.Size(560, 507);
            this.pnlGetGraph.TabIndex = 7;
            this.pnlGetGraph.Visible = false;
            // 
            // btnSaveWeight
            // 
            this.btnSaveWeight.Location = new System.Drawing.Point(430, 436);
            this.btnSaveWeight.Name = "btnSaveWeight";
            this.btnSaveWeight.Size = new System.Drawing.Size(110, 50);
            this.btnSaveWeight.TabIndex = 6;
            this.btnSaveWeight.Text = "OK";
            this.btnSaveWeight.UseVisualStyleBackColor = true;
            this.btnSaveWeight.Click += new System.EventHandler(this.btnSaveWeight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(129, 158);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(371, 27);
            this.txtWeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // cmbToPoint
            // 
            this.cmbToPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToPoint.FormattingEnabled = true;
            this.cmbToPoint.Location = new System.Drawing.Point(129, 111);
            this.cmbToPoint.Name = "cmbToPoint";
            this.cmbToPoint.Size = new System.Drawing.Size(371, 28);
            this.cmbToPoint.TabIndex = 1;
            // 
            // cmbFromPoint
            // 
            this.cmbFromPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromPoint.FormattingEnabled = true;
            this.cmbFromPoint.Location = new System.Drawing.Point(129, 64);
            this.cmbFromPoint.Name = "cmbFromPoint";
            this.cmbFromPoint.Size = new System.Drawing.Size(371, 28);
            this.cmbFromPoint.TabIndex = 0;
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(12, 80);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(110, 50);
            this.btnShowGraph.TabIndex = 1;
            this.btnShowGraph.Text = "Show Graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlPrim
            // 
            this.pnlPrim.Location = new System.Drawing.Point(139, 14);
            this.pnlPrim.Name = "pnlPrim";
            this.pnlPrim.Size = new System.Drawing.Size(560, 507);
            this.pnlPrim.TabIndex = 9;
            this.pnlPrim.Visible = false;
            this.pnlPrim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseDown);
            this.pnlPrim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseMove);
            this.pnlPrim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseUp);
            // 
            // pnlSollin
            // 
            this.pnlSollin.Location = new System.Drawing.Point(139, 14);
            this.pnlSollin.Name = "pnlSollin";
            this.pnlSollin.Size = new System.Drawing.Size(560, 507);
            this.pnlSollin.TabIndex = 10;
            this.pnlSollin.Visible = false;
            this.pnlSollin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseDown);
            this.pnlSollin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseMove);
            this.pnlSollin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlShowGraph_MouseUp);
            // 
            // frmMST
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(350, 194);
            this.Controls.Add(this.pnlStatrt);
            this.Controls.Add(this.pnlKruskal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.btnSollin);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnKruskal);
            this.Controls.Add(this.btnGetGraph);
            this.Controls.Add(this.pnlShowGraph);
            this.Controls.Add(this.pnlGetGraph);
            this.Controls.Add(this.pnlPrim);
            this.Controls.Add(this.pnlSollin);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.692307F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmMST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MST";
            this.pnlStatrt.ResumeLayout(false);
            this.pnlStatrt.PerformLayout();
            this.pnlGetGraph.ResumeLayout(false);
            this.pnlGetGraph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetGraph;
        private System.Windows.Forms.Button btnKruskal;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnSollin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.Button btnSaveWeight;
        private System.Windows.Forms.Panel pnlShowGraph;
        private System.Windows.Forms.Panel pnlStatrt;
        private System.Windows.Forms.Panel pnlGetGraph;
        private System.Windows.Forms.Panel pnlKruskal;
        private System.Windows.Forms.Panel pnlPrim;
        private System.Windows.Forms.Panel pnlSollin;
        private System.Windows.Forms.TextBox txtNumOfVertices;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFromPoint;
        private System.Windows.Forms.ComboBox cmbToPoint;
    }
}

