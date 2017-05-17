namespace AirlinesApp
{
    partial class AppForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.RadioButton();
            this.flightBtn = new System.Windows.Forms.RadioButton();
            this.airportBtn = new System.Windows.Forms.RadioButton();
            this.airlineBtn = new System.Windows.Forms.RadioButton();
            this.airplaneBtn = new System.Windows.Forms.RadioButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.displayBtn);
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.flightBtn);
            this.panel1.Controls.Add(this.airportBtn);
            this.panel1.Controls.Add(this.airlineBtn);
            this.panel1.Controls.Add(this.airplaneBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 485);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose datatable";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 253);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 40);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 210);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(125, 37);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(12, 164);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(125, 40);
            this.displayBtn.TabIndex = 2;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.AutoSize = true;
            this.userBtn.Location = new System.Drawing.Point(12, 124);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(80, 17);
            this.userBtn.TabIndex = 1;
            this.userBtn.Text = "Passengers";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // flightBtn
            // 
            this.flightBtn.AutoSize = true;
            this.flightBtn.Location = new System.Drawing.Point(12, 101);
            this.flightBtn.Name = "flightBtn";
            this.flightBtn.Size = new System.Drawing.Size(55, 17);
            this.flightBtn.TabIndex = 1;
            this.flightBtn.Text = "Flights";
            this.flightBtn.UseVisualStyleBackColor = true;
            this.flightBtn.Click += new System.EventHandler(this.flightBtn_Click);
            // 
            // airportBtn
            // 
            this.airportBtn.AutoSize = true;
            this.airportBtn.Checked = true;
            this.airportBtn.Location = new System.Drawing.Point(12, 78);
            this.airportBtn.Name = "airportBtn";
            this.airportBtn.Size = new System.Drawing.Size(60, 17);
            this.airportBtn.TabIndex = 1;
            this.airportBtn.TabStop = true;
            this.airportBtn.Text = "Airports";
            this.airportBtn.UseVisualStyleBackColor = true;
            this.airportBtn.Click += new System.EventHandler(this.airportBtn_Click);
            // 
            // airlineBtn
            // 
            this.airlineBtn.AutoSize = true;
            this.airlineBtn.Location = new System.Drawing.Point(12, 55);
            this.airlineBtn.Name = "airlineBtn";
            this.airlineBtn.Size = new System.Drawing.Size(58, 17);
            this.airlineBtn.TabIndex = 1;
            this.airlineBtn.Text = "Airlines";
            this.airlineBtn.UseVisualStyleBackColor = true;
            this.airlineBtn.Click += new System.EventHandler(this.airlineBtn_Click);
            // 
            // airplaneBtn
            // 
            this.airplaneBtn.AutoSize = true;
            this.airplaneBtn.Location = new System.Drawing.Point(12, 32);
            this.airplaneBtn.Name = "airplaneBtn";
            this.airplaneBtn.Size = new System.Drawing.Size(68, 17);
            this.airplaneBtn.TabIndex = 0;
            this.airplaneBtn.Text = "Airplanes";
            this.airplaneBtn.UseVisualStyleBackColor = true;
            this.airplaneBtn.Click += new System.EventHandler(this.airplaneBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid.Location = new System.Drawing.Point(155, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(721, 485);
            this.dataGrid.TabIndex = 2;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirlinesApp.Properties.Resources.openflights_routedb_2048;
            this.ClientSize = new System.Drawing.Size(876, 485);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "AppForm";
            this.Text = "Airlines Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.RadioButton userBtn;
        private System.Windows.Forms.RadioButton flightBtn;
        private System.Windows.Forms.RadioButton airportBtn;
        private System.Windows.Forms.RadioButton airlineBtn;
        private System.Windows.Forms.RadioButton airplaneBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button editBtn;

    }
}

