namespace MiniProjetV1.Forms
{
    partial class MonCompte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMesPassagers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.passOffreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPlacesReserves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passMontantPaye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMesReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMesOffres = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteOffre = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesPassagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesOffres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes Offres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mes passagers :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mes Reservations:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(11, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 10);
            this.panel1.TabIndex = 1;
            // 
            // dgvMesPassagers
            // 
            this.dgvMesPassagers.AllowUserToAddRows = false;
            this.dgvMesPassagers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvMesPassagers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMesPassagers.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesPassagers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesPassagers.ColumnHeadersHeight = 34;
            this.dgvMesPassagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passOffreId,
            this.passNom,
            this.passPrenom,
            this.passPlacesReserves,
            this.passMontantPaye});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesPassagers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMesPassagers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvMesPassagers.Location = new System.Drawing.Point(549, 69);
            this.dgvMesPassagers.Name = "dgvMesPassagers";
            this.dgvMesPassagers.ReadOnly = true;
            this.dgvMesPassagers.RowHeadersVisible = false;
            this.dgvMesPassagers.RowHeadersWidth = 51;
            this.dgvMesPassagers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMesPassagers.RowTemplate.DividerHeight = 1;
            this.dgvMesPassagers.RowTemplate.Height = 28;
            this.dgvMesPassagers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesPassagers.Size = new System.Drawing.Size(746, 180);
            this.dgvMesPassagers.TabIndex = 2;
            this.dgvMesPassagers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvMesPassagers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvMesPassagers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMesPassagers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMesPassagers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMesPassagers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMesPassagers.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dgvMesPassagers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvMesPassagers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvMesPassagers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMesPassagers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMesPassagers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMesPassagers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMesPassagers.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvMesPassagers.ThemeStyle.ReadOnly = true;
            this.dgvMesPassagers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvMesPassagers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMesPassagers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMesPassagers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMesPassagers.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMesPassagers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvMesPassagers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // passOffreId
            // 
            this.passOffreId.DataPropertyName = "offreID";
            this.passOffreId.HeaderText = "Offre ID";
            this.passOffreId.MinimumWidth = 6;
            this.passOffreId.Name = "passOffreId";
            this.passOffreId.ReadOnly = true;
            // 
            // passNom
            // 
            this.passNom.DataPropertyName = "Nom";
            this.passNom.HeaderText = "Nom";
            this.passNom.MinimumWidth = 6;
            this.passNom.Name = "passNom";
            this.passNom.ReadOnly = true;
            // 
            // passPrenom
            // 
            this.passPrenom.DataPropertyName = "Prenom";
            this.passPrenom.HeaderText = "Prenom";
            this.passPrenom.MinimumWidth = 6;
            this.passPrenom.Name = "passPrenom";
            this.passPrenom.ReadOnly = true;
            // 
            // passPlacesReserves
            // 
            this.passPlacesReserves.DataPropertyName = "PlacesReserves";
            this.passPlacesReserves.HeaderText = "Places reserves";
            this.passPlacesReserves.MinimumWidth = 6;
            this.passPlacesReserves.Name = "passPlacesReserves";
            this.passPlacesReserves.ReadOnly = true;
            // 
            // passMontantPaye
            // 
            this.passMontantPaye.DataPropertyName = "PrixTotal";
            this.passMontantPaye.HeaderText = "Montant Paye";
            this.passMontantPaye.MinimumWidth = 6;
            this.passMontantPaye.Name = "passMontantPaye";
            this.passMontantPaye.ReadOnly = true;
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
            this.dgvMesReservations.Location = new System.Drawing.Point(167, 375);
            this.dgvMesReservations.Name = "dgvMesReservations";
            this.dgvMesReservations.ReadOnly = true;
            this.dgvMesReservations.RowHeadersVisible = false;
            this.dgvMesReservations.RowHeadersWidth = 51;
            this.dgvMesReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMesReservations.RowTemplate.DividerHeight = 1;
            this.dgvMesReservations.RowTemplate.Height = 28;
            this.dgvMesReservations.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesReservations.Size = new System.Drawing.Size(983, 113);
            this.dgvMesReservations.TabIndex = 2;
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
            // dgvMesOffres
            // 
            this.dgvMesOffres.AllowUserToAddRows = false;
            this.dgvMesOffres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvMesOffres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMesOffres.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesOffres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMesOffres.ColumnHeadersHeight = 34;
            this.dgvMesOffres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesOffres.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMesOffres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMesOffres.Location = new System.Drawing.Point(0, 69);
            this.dgvMesOffres.Name = "dgvMesOffres";
            this.dgvMesOffres.ReadOnly = true;
            this.dgvMesOffres.RowHeadersVisible = false;
            this.dgvMesOffres.RowHeadersWidth = 51;
            this.dgvMesOffres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMesOffres.RowTemplate.DividerHeight = 1;
            this.dgvMesOffres.RowTemplate.Height = 28;
            this.dgvMesOffres.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesOffres.Size = new System.Drawing.Size(525, 129);
            this.dgvMesOffres.TabIndex = 2;
            this.dgvMesOffres.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMesOffres.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMesOffres.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMesOffres.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMesOffres.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMesOffres.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.dgvMesOffres.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMesOffres.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMesOffres.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMesOffres.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMesOffres.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMesOffres.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMesOffres.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvMesOffres.ThemeStyle.ReadOnly = true;
            this.dgvMesOffres.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMesOffres.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMesOffres.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMesOffres.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMesOffres.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMesOffres.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMesOffres.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMesOffres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesOffres_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdOffre";
            this.Column1.HeaderText = "IdOffre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Depart";
            this.Column2.HeaderText = "Depart";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Arrive";
            this.Column3.HeaderText = "Arrive";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateDepart";
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Places";
            this.Column5.HeaderText = "Places";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnDeleteOffre
            // 
            this.btnDeleteOffre.BorderRadius = 10;
            this.btnDeleteOffre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOffre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOffre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteOffre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteOffre.FillColor = System.Drawing.Color.Red;
            this.btnDeleteOffre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOffre.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOffre.Location = new System.Drawing.Point(151, 248);
            this.btnDeleteOffre.Name = "btnDeleteOffre";
            this.btnDeleteOffre.Size = new System.Drawing.Size(164, 38);
            this.btnDeleteOffre.TabIndex = 3;
            this.btnDeleteOffre.Text = "Supprimer l\'Offre";
            this.btnDeleteOffre.Click += new System.EventHandler(this.btnDeleteOffre_Click);
            // 
            // MonCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnDeleteOffre);
            this.Controls.Add(this.dgvMesReservations);
            this.Controls.Add(this.dgvMesOffres);
            this.Controls.Add(this.dgvMesPassagers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "MonCompte";
            this.Size = new System.Drawing.Size(1316, 510);
            this.Load += new System.EventHandler(this.Demandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesPassagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesOffres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMesPassagers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMesReservations;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMesOffres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn passOffreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn passNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPlacesReserves;
        private System.Windows.Forms.DataGridViewTextBoxColumn passMontantPaye;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn resPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn resAuthor;
        private Guna.UI2.WinForms.Guna2Button btnDeleteOffre;
    }
}
