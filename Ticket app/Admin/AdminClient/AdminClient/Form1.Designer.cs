namespace AdminClient
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddCity = new System.Windows.Forms.ToolStripMenuItem();
            this.mState = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeatState = new System.Windows.Forms.ToolStripMenuItem();
            this.mStateTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbCities = new System.Windows.Forms.TabPage();
            this.tbTickets = new System.Windows.Forms.TabPage();
            this.tbSeats = new System.Windows.Forms.TabPage();
            this.tbTransport = new System.Windows.Forms.TabPage();
            this.tbRoutes = new System.Windows.Forms.TabPage();
            this.btOk = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCities = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tbCities.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mAdd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(45, 20);
            this.mFile.Text = "Файл";
            // 
            // mAdd
            // 
            this.mAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddCity,
            this.mState});
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(69, 20);
            this.mAdd.Text = "Добавить";
            // 
            // mAddCity
            // 
            this.mAddCity.Name = "mAddCity";
            this.mAddCity.Size = new System.Drawing.Size(152, 22);
            this.mAddCity.Text = "Город";
            this.mAddCity.Click += new System.EventHandler(this.mAddCity_Click);
            // 
            // mState
            // 
            this.mState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSeatState,
            this.mStateTicket});
            this.mState.Name = "mState";
            this.mState.Size = new System.Drawing.Size(152, 22);
            this.mState.Text = "Состояние";
            // 
            // mSeatState
            // 
            this.mSeatState.Name = "mSeatState";
            this.mSeatState.Size = new System.Drawing.Size(152, 22);
            this.mSeatState.Text = "Места";
            this.mSeatState.Click += new System.EventHandler(this.mSeatState_Click);
            // 
            // mStateTicket
            // 
            this.mStateTicket.Name = "mStateTicket";
            this.mStateTicket.Size = new System.Drawing.Size(152, 22);
            this.mStateTicket.Text = "Билета";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbCities);
            this.tabControl.Controls.Add(this.tbTickets);
            this.tabControl.Controls.Add(this.tbSeats);
            this.tabControl.Controls.Add(this.tbTransport);
            this.tabControl.Controls.Add(this.tbRoutes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(589, 240);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tbCities
            // 
            this.tbCities.Controls.Add(this.lbCities);
            this.tbCities.Controls.Add(this.btOk);
            this.tbCities.Controls.Add(this.tbCity);
            this.tbCities.Controls.Add(this.label1);
            this.tbCities.Location = new System.Drawing.Point(4, 22);
            this.tbCities.Name = "tbCities";
            this.tbCities.Padding = new System.Windows.Forms.Padding(3);
            this.tbCities.Size = new System.Drawing.Size(581, 214);
            this.tbCities.TabIndex = 0;
            this.tbCities.Text = "Города";
            this.tbCities.UseVisualStyleBackColor = true;
            // 
            // tbTickets
            // 
            this.tbTickets.Location = new System.Drawing.Point(4, 22);
            this.tbTickets.Name = "tbTickets";
            this.tbTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tbTickets.Size = new System.Drawing.Size(581, 214);
            this.tbTickets.TabIndex = 1;
            this.tbTickets.Text = "Билеты";
            this.tbTickets.UseVisualStyleBackColor = true;
            // 
            // tbSeats
            // 
            this.tbSeats.Location = new System.Drawing.Point(4, 22);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(581, 214);
            this.tbSeats.TabIndex = 2;
            this.tbSeats.Text = "Места";
            this.tbSeats.UseVisualStyleBackColor = true;
            // 
            // tbTransport
            // 
            this.tbTransport.Location = new System.Drawing.Point(4, 22);
            this.tbTransport.Name = "tbTransport";
            this.tbTransport.Size = new System.Drawing.Size(581, 214);
            this.tbTransport.TabIndex = 3;
            this.tbTransport.Text = "Транспорт";
            this.tbTransport.UseVisualStyleBackColor = true;
            // 
            // tbRoutes
            // 
            this.tbRoutes.Location = new System.Drawing.Point(4, 22);
            this.tbRoutes.Name = "tbRoutes";
            this.tbRoutes.Size = new System.Drawing.Size(581, 214);
            this.tbRoutes.TabIndex = 4;
            this.tbRoutes.Text = "Маршруты";
            this.tbRoutes.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(489, 98);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Добавить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(306, 98);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(150, 20);
            this.tbCity.TabIndex = 2;
            this.tbCity.TextChanged += new System.EventHandler(this.tbCity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(213, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Город:";
            // 
            // lbCities
            // 
            this.lbCities.FormattingEnabled = true;
            this.lbCities.Location = new System.Drawing.Point(6, 6);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(201, 199);
            this.lbCities.TabIndex = 5;
            this.lbCities.SelectedIndexChanged += new System.EventHandler(this.lbCities_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 264);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tbCities.ResumeLayout(false);
            this.tbCities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mAdd;
        private System.Windows.Forms.ToolStripMenuItem mAddCity;
        private System.Windows.Forms.ToolStripMenuItem mState;
        private System.Windows.Forms.ToolStripMenuItem mSeatState;
        private System.Windows.Forms.ToolStripMenuItem mStateTicket;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbCities;
        private System.Windows.Forms.TabPage tbTickets;
        private System.Windows.Forms.TabPage tbSeats;
        private System.Windows.Forms.TabPage tbTransport;
        private System.Windows.Forms.TabPage tbRoutes;
        private System.Windows.Forms.ListBox lbCities;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label1;
    }
}

