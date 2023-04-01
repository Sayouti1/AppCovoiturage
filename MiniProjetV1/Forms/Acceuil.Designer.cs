namespace MiniProjetV1.Forms
{
    partial class Acceuil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLastOffre = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IdOffre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvMesReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastOffre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les dernieres offres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(339, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes Reservations";
            // 
            // dgvLastOffre
            // 
            this.dgvLastOffre.AllowUserToAddRows = false;
            this.dgvLastOffre.AllowUserToDeleteRows = false;
            this.dgvLastOffre.AllowUserToResizeColumns = false;
            this.dgvLastOffre.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvLastOffre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLastOffre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLastOffre.ColumnHeadersHeight = 35;
            this.dgvLastOffre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOffre,
            this.Depart,
            this.Arrive,
            this.DateDepart,
            this.Heure,
            this.Prix,
            this.PlaceDisponible,
            this.DatePublication});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLastOffre.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLastOffre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvLastOffre.Location = new System.Drawing.Point(53, 85);
            this.dgvLastOffre.MultiSelect = false;
            this.dgvLastOffre.Name = "dgvLastOffre";
            this.dgvLastOffre.ReadOnly = true;
            this.dgvLastOffre.RowHeadersVisible = false;
            this.dgvLastOffre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLastOffre.RowTemplate.DividerHeight = 1;
            this.dgvLastOffre.RowTemplate.Height = 41;
            this.dgvLastOffre.RowTemplate.ReadOnly = true;
            this.dgvLastOffre.Size = new System.Drawing.Size(801, 160);
            this.dgvLastOffre.TabIndex = 4;
            this.dgvLastOffre.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvLastOffre.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvLastOffre.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLastOffre.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLastOffre.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLastOffre.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLastOffre.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLastOffre.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvLastOffre.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvLastOffre.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLastOffre.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLastOffre.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLastOffre.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLastOffre.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvLastOffre.ThemeStyle.ReadOnly = true;
            this.dgvLastOffre.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvLastOffre.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLastOffre.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLastOffre.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLastOffre.ThemeStyle.RowsStyle.Height = 41;
            this.dgvLastOffre.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvLastOffre.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // IdOffre
            // 
            this.IdOffre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdOffre.DataPropertyName = "IdOffre";
            this.IdOffre.Frozen = true;
            this.IdOffre.HeaderText = "Offre ID";
            this.IdOffre.MinimumWidth = 6;
            this.IdOffre.Name = "IdOffre";
            this.IdOffre.ReadOnly = true;
            this.IdOffre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdOffre.Visible = false;
            this.IdOffre.Width = 62;
            // 
            // Depart
            // 
            this.Depart.DataPropertyName = "Depart";
            this.Depart.HeaderText = "Depart";
            this.Depart.MinimumWidth = 6;
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            // 
            // Arrive
            // 
            this.Arrive.DataPropertyName = "Arrive";
            this.Arrive.HeaderText = "Destination";
            this.Arrive.MinimumWidth = 6;
            this.Arrive.Name = "Arrive";
            this.Arrive.ReadOnly = true;
            // 
            // DateDepart
            // 
            this.DateDepart.DataPropertyName = "DateDepart";
            this.DateDepart.HeaderText = "Date de depart";
            this.DateDepart.MinimumWidth = 6;
            this.DateDepart.Name = "DateDepart";
            this.DateDepart.ReadOnly = true;
            // 
            // Heure
            // 
            this.Heure.DataPropertyName = "Heure";
            this.Heure.HeaderText = "Heure";
            this.Heure.MinimumWidth = 6;
            this.Heure.Name = "Heure";
            this.Heure.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix DH";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Visible = false;
            // 
            // PlaceDisponible
            // 
            this.PlaceDisponible.DataPropertyName = "Places Disponibles";
            this.PlaceDisponible.HeaderText = "Places Disponibles";
            this.PlaceDisponible.MinimumWidth = 6;
            this.PlaceDisponible.Name = "PlaceDisponible";
            this.PlaceDisponible.ReadOnly = true;
            this.PlaceDisponible.Visible = false;
            // 
            // DatePublication
            // 
            this.DatePublication.DataPropertyName = "DatePublication";
            this.DatePublication.HeaderText = "Date Publication";
            this.DatePublication.MinimumWidth = 6;
            this.DatePublication.Name = "DatePublication";
            this.DatePublication.ReadOnly = true;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Crimson;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.DarkOrange;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Image = global::MiniProjetV1.Properties.Resources.car__2_;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton2.ImageOffset = new System.Drawing.Point(4, 3);
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(50, 45);
            this.guna2GradientButton2.Location = new System.Drawing.Point(890, 121);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(318, 47);
            this.guna2GradientButton2.TabIndex = 7;
            this.guna2GradientButton2.Text = "Consulter les offres";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.TextOffset = new System.Drawing.Point(40, 0);
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // dgvMesReservations
            // 
            this.dgvMesReservations.AllowUserToAddRows = false;
            this.dgvMesReservations.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvMesReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMesReservations.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMesReservations.ColumnHeadersHeight = 34;
            this.dgvMesReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.resDepart,
            this.resDestination,
            this.resDate,
            this.resPlaces,
            this.resAuthor});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesReservations.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMesReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvMesReservations.Location = new System.Drawing.Point(316, 331);
            this.dgvMesReservations.Name = "dgvMesReservations";
            this.dgvMesReservations.ReadOnly = true;
            this.dgvMesReservations.RowHeadersVisible = false;
            this.dgvMesReservations.RowHeadersWidth = 51;
            this.dgvMesReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMesReservations.RowTemplate.DividerHeight = 1;
            this.dgvMesReservations.RowTemplate.Height = 28;
            this.dgvMesReservations.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesReservations.Size = new System.Drawing.Size(983, 113);
            this.dgvMesReservations.TabIndex = 8;
            this.dgvMesReservations.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise;
            this.dgvMesReservations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvMesReservations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMesReservations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMesReservations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMesReservations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMesReservations.ThemeStyle.BackColor = System.Drawing.Color.Cornsilk;
            this.dgvMesReservations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvMesReservations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.dgvMesReservations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMesReservations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMesReservations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMesReservations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMesReservations.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvMesReservations.ThemeStyle.ReadOnly = true;
            this.dgvMesReservations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.dgvMesReservations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMesReservations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMesReservations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMesReservations.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMesReservations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            this.dgvMesReservations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "offreID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Offre ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // resDepart
            // 
            this.resDepart.DataPropertyName = "Depart";
            this.resDepart.HeaderText = "Depart";
            this.resDepart.MinimumWidth = 6;
            this.resDepart.Name = "resDepart";
            this.resDepart.ReadOnly = true;
            // 
            // resDestination
            // 
            this.resDestination.DataPropertyName = "Arrive";
            this.resDestination.HeaderText = "Destination";
            this.resDestination.MinimumWidth = 6;
            this.resDestination.Name = "resDestination";
            this.resDestination.ReadOnly = true;
            // 
            // resDate
            // 
            this.resDate.DataPropertyName = "DateDepart";
            this.resDate.HeaderText = "Date";
            this.resDate.MinimumWidth = 6;
            this.resDate.Name = "resDate";
            this.resDate.ReadOnly = true;
            // 
            // resPlaces
            // 
            this.resPlaces.DataPropertyName = "PlacesReserves";
            this.resPlaces.HeaderText = "Places reserves";
            this.resPlaces.MinimumWidth = 6;
            this.resPlaces.Name = "resPlaces";
            this.resPlaces.ReadOnly = true;
            // 
            // resAuthor
            // 
            this.resAuthor.DataPropertyName = "FullName";
            this.resAuthor.HeaderText = "Offre De";
            this.resAuthor.MinimumWidth = 6;
            this.resAuthor.Name = "resAuthor";
            this.resAuthor.ReadOnly = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.MediumBlue;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.ImageOffset = new System.Drawing.Point(4, 3);
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(50, 45);
            this.guna2GradientButton1.Location = new System.Drawing.Point(22, 369);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(266, 54);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.Text = "Consulter mon compte";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(40, 0);
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.dgvMesReservations);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.dgvLastOffre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Acceuil";
            this.Size = new System.Drawing.Size(1316, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastOffre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLastOffre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOffre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePublication;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMesReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn resPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn resAuthor;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}
