namespace JogoDaVelha
{
    partial class frmJogoDaVelha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogoDaVelha));
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.rdX = new System.Windows.Forms.RadioButton();
            this.rdY = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbQuemJoga = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(6, 7);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(41, 41);
            this.btn00.TabIndex = 0;
            this.btn00.TabStop = false;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(61, 7);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(41, 41);
            this.btn01.TabIndex = 1;
            this.btn01.TabStop = false;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(116, 7);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(41, 41);
            this.btn02.TabIndex = 2;
            this.btn02.TabStop = false;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(6, 61);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(41, 41);
            this.btn10.TabIndex = 3;
            this.btn10.TabStop = false;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(61, 62);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(41, 41);
            this.btn11.TabIndex = 4;
            this.btn11.TabStop = false;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(117, 62);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(41, 41);
            this.btn12.TabIndex = 5;
            this.btn12.TabStop = false;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(6, 118);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(41, 41);
            this.btn20.TabIndex = 6;
            this.btn20.TabStop = false;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(62, 118);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(41, 41);
            this.btn21.TabIndex = 7;
            this.btn21.TabStop = false;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(117, 118);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(41, 41);
            this.btn22.TabIndex = 8;
            this.btn22.TabStop = false;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // rdX
            // 
            this.rdX.AutoSize = true;
            this.rdX.Checked = true;
            this.rdX.Location = new System.Drawing.Point(6, 19);
            this.rdX.Name = "rdX";
            this.rdX.Size = new System.Drawing.Size(32, 17);
            this.rdX.TabIndex = 9;
            this.rdX.TabStop = true;
            this.rdX.Text = "X";
            this.rdX.UseVisualStyleBackColor = true;
            // 
            // rdY
            // 
            this.rdY.AutoSize = true;
            this.rdY.Location = new System.Drawing.Point(6, 42);
            this.rdY.Name = "rdY";
            this.rdY.Size = new System.Drawing.Size(33, 17);
            this.rdY.TabIndex = 10;
            this.rdY.Text = "O";
            this.rdY.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdY);
            this.groupBox1.Controls.Add(this.rdX);
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quem joga primeiro?";
            // 
            // txbQuemJoga
            // 
            this.txbQuemJoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuemJoga.ForeColor = System.Drawing.Color.Red;
            this.txbQuemJoga.Location = new System.Drawing.Point(8, 177);
            this.txbQuemJoga.Name = "txbQuemJoga";
            this.txbQuemJoga.ReadOnly = true;
            this.txbQuemJoga.Size = new System.Drawing.Size(149, 26);
            this.txbQuemJoga.TabIndex = 12;
            this.txbQuemJoga.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(181, 177);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(139, 26);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.Text = "Jogar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(178, 106);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(94, 13);
            this.lblLink.TabIndex = 15;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "golfetto.16mb.com";
            this.lblLink.VisitedLinkColor = System.Drawing.Color.Purple;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmJogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaVelha.Properties.Resources.ttt_board;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(329, 211);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txbQuemJoga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmJogoDaVelha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da velha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.RadioButton rdX;
        private System.Windows.Forms.RadioButton rdY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbQuemJoga;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

