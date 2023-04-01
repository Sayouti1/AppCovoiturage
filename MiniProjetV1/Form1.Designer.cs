using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MiniProjetV1
{
    partial class Form1
    {
        public static int Username = 0;
        public static string FullName = "";
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnAcceuil = new System.Windows.Forms.Button();
            this.btnDemandes = new System.Windows.Forms.Button();
            this.btnOffres = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbTopUp = new System.Windows.Forms.PictureBox();
            this.pnlTopUp = new System.Windows.Forms.Panel();
            this.NbrTopUp = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.BtnTopUP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Container = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopUp)).BeginInit();
            this.pnlTopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbrTopUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTopUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.btnAcceuil);
            this.menuPanel.Controls.Add(this.btnDemandes);
            this.menuPanel.Controls.Add(this.btnOffres);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 50);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1316, 45);
            this.menuPanel.TabIndex = 1;
            // 
            // btnAcceuil
            // 
            this.btnAcceuil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcceuil.FlatAppearance.BorderSize = 0;
            this.btnAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceuil.ForeColor = System.Drawing.Color.Black;
            this.btnAcceuil.Location = new System.Drawing.Point(0, -4);
            this.btnAcceuil.Name = "btnAcceuil";
            this.btnAcceuil.Size = new System.Drawing.Size(366, 55);
            this.btnAcceuil.TabIndex = 0;
            this.btnAcceuil.Text = "Acceuil";
            this.btnAcceuil.UseVisualStyleBackColor = false;
            this.btnAcceuil.Click += new System.EventHandler(this.btnAcceuil_Click);
            // 
            // btnDemandes
            // 
            this.btnDemandes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDemandes.BackColor = System.Drawing.Color.White;
            this.btnDemandes.FlatAppearance.BorderSize = 0;
            this.btnDemandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemandes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandes.ForeColor = System.Drawing.Color.Black;
            this.btnDemandes.Location = new System.Drawing.Point(925, -4);
            this.btnDemandes.Name = "btnDemandes";
            this.btnDemandes.Size = new System.Drawing.Size(379, 55);
            this.btnDemandes.TabIndex = 2;
            this.btnDemandes.Text = "Mon Compte";
            this.btnDemandes.UseVisualStyleBackColor = false;
            this.btnDemandes.Click += new System.EventHandler(this.btnDemandes_Click);
            // 
            // btnOffres
            // 
            this.btnOffres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOffres.BackColor = System.Drawing.Color.White;
            this.btnOffres.FlatAppearance.BorderSize = 0;
            this.btnOffres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffres.ForeColor = System.Drawing.Color.Black;
            this.btnOffres.Location = new System.Drawing.Point(387, -4);
            this.btnOffres.Name = "btnOffres";
            this.btnOffres.Size = new System.Drawing.Size(521, 55);
            this.btnOffres.TabIndex = 1;
            this.btnOffres.Text = "Offres";
            this.btnOffres.UseVisualStyleBackColor = false;
            this.btnOffres.Click += new System.EventHandler(this.btnOffres_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Controls.Add(this.lblSolde);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.pbTopUp);
            this.panel2.Controls.Add(this.pnlTopUp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 50);
            this.panel2.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(1083, 14);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(134, 26);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Deconnexion";
            this.BtnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSolde.Location = new System.Drawing.Point(369, 17);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(25, 20);
            this.lblSolde.TabIndex = 8;
            this.lblSolde.Text = "00";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(120, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 20);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "-------";
            // 
            // pbTopUp
            // 
            this.pbTopUp.Image = global::MiniProjetV1.Properties.Resources.icons8_add_credit_card_64__1_;
            this.pbTopUp.Location = new System.Drawing.Point(417, 8);
            this.pbTopUp.Name = "pbTopUp";
            this.pbTopUp.Size = new System.Drawing.Size(35, 40);
            this.pbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTopUp.TabIndex = 7;
            this.pbTopUp.TabStop = false;
            this.pbTopUp.Click += new System.EventHandler(this.pbTopUp_Click);
            // 
            // pnlTopUp
            // 
            this.pnlTopUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopUp.Controls.Add(this.NbrTopUp);
            this.pnlTopUp.Controls.Add(this.BtnTopUP);
            this.pnlTopUp.Controls.Add(this.label1);
            this.pnlTopUp.Location = new System.Drawing.Point(458, 3);
            this.pnlTopUp.Name = "pnlTopUp";
            this.pnlTopUp.Size = new System.Drawing.Size(286, 40);
            this.pnlTopUp.TabIndex = 0;
            this.pnlTopUp.Visible = false;
            // 
            // NbrTopUp
            // 
            this.NbrTopUp.BackColor = System.Drawing.Color.Transparent;
            this.NbrTopUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NbrTopUp.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.NbrTopUp.Location = new System.Drawing.Point(88, 11);
            this.NbrTopUp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbrTopUp.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbrTopUp.Name = "NbrTopUp";
            this.NbrTopUp.Size = new System.Drawing.Size(126, 22);
            this.NbrTopUp.TabIndex = 0;
            this.NbrTopUp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbrTopUp.Leave += new System.EventHandler(this.NbrTopUp_Leave);
            // 
            // BtnTopUP
            // 
            this.BtnTopUP.Image = global::MiniProjetV1.Properties.Resources.icons8_checkmark_60;
            this.BtnTopUP.Location = new System.Drawing.Point(230, 6);
            this.BtnTopUP.Name = "BtnTopUP";
            this.BtnTopUP.Size = new System.Drawing.Size(49, 32);
            this.BtnTopUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnTopUP.TabIndex = 0;
            this.BtnTopUP.TabStop = false;
            this.BtnTopUP.Click += new System.EventHandler(this.BtnTopUP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(316, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Solde :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(302, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProjetV1.Properties.Resources.eagle_15185;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(1240, 8);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(1276, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 95);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1316, 516);
            this.Container.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1316, 611);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covoiturage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopUp)).EndInit();
            this.pnlTopUp.ResumeLayout(false);
            this.pnlTopUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbrTopUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTopUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnAcceuil;
        private System.Windows.Forms.Button btnOffres;
        private System.Windows.Forms.Button btnDemandes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
       //public  System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbTopUp;
        private System.Windows.Forms.Panel pnlTopUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnTopUP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NbrTopUp;
        public static int UserSolde;
        public static Guna.UI2.WinForms.Guna2Button guna2Button1;
       // public System.Windows.Forms.Panel panelContainer;
        //public static System.Windows.Forms.Label lblSolde;
        private Guna.UI2.WinForms.Guna2Panel Container;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSolde;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
    }
}

