namespace Proiect_semestru_VLADU_STEFAN_ALEXANDRU_GRUPA_615
{
    partial class MainProgram
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
            this.availableBtn = new System.Windows.Forms.Button();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.hideCars = new System.Windows.Forms.Button();
            this.boxCars = new System.Windows.Forms.ListBox();
            this.reservedCars = new System.Windows.Forms.ListBox();
            this.removeCar = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.calendar2 = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableBtn
            // 
            this.availableBtn.Location = new System.Drawing.Point(225, 151);
            this.availableBtn.Name = "availableBtn";
            this.availableBtn.Size = new System.Drawing.Size(128, 23);
            this.availableBtn.TabIndex = 0;
            this.availableBtn.Text = "Available cars";
            this.availableBtn.UseVisualStyleBackColor = true;
            this.availableBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserveBtn
            // 
            this.reserveBtn.Location = new System.Drawing.Point(225, 180);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(128, 23);
            this.reserveBtn.TabIndex = 2;
            this.reserveBtn.Text = "Add car";
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Visible = false;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // hideCars
            // 
            this.hideCars.Location = new System.Drawing.Point(41, 341);
            this.hideCars.Name = "hideCars";
            this.hideCars.Size = new System.Drawing.Size(147, 23);
            this.hideCars.TabIndex = 4;
            this.hideCars.Text = "Hide available cars";
            this.hideCars.UseVisualStyleBackColor = true;
            this.hideCars.Visible = false;
            this.hideCars.Click += new System.EventHandler(this.hideCars_Click);
            // 
            // boxCars
            // 
            this.boxCars.FormattingEnabled = true;
            this.boxCars.Location = new System.Drawing.Point(12, 38);
            this.boxCars.Name = "boxCars";
            this.boxCars.Size = new System.Drawing.Size(120, 277);
            this.boxCars.TabIndex = 6;
            this.boxCars.Visible = false;
            // 
            // reservedCars
            // 
            this.reservedCars.FormattingEnabled = true;
            this.reservedCars.Location = new System.Drawing.Point(399, 38);
            this.reservedCars.Name = "reservedCars";
            this.reservedCars.Size = new System.Drawing.Size(120, 277);
            this.reservedCars.TabIndex = 7;
            this.reservedCars.Visible = false;
            // 
            // removeCar
            // 
            this.removeCar.Location = new System.Drawing.Point(225, 209);
            this.removeCar.Name = "removeCar";
            this.removeCar.Size = new System.Drawing.Size(128, 23);
            this.removeCar.TabIndex = 8;
            this.removeCar.Text = "Remove car";
            this.removeCar.UseVisualStyleBackColor = true;
            this.removeCar.Visible = false;
            this.removeCar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // calendar
            // 
            this.calendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.calendar.Location = new System.Drawing.Point(555, 92);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(200, 20);
            this.calendar.TabIndex = 9;
            this.calendar.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Make reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // calendar2
            // 
            this.calendar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.calendar2.Location = new System.Drawing.Point(555, 197);
            this.calendar2.Name = "calendar2";
            this.calendar2.Size = new System.Drawing.Size(200, 20);
            this.calendar2.TabIndex = 11;
            this.calendar2.Visible = false;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(632, 64);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From";
            this.labelFrom.Visible = false;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(632, 180);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "To";
            this.labelTo.Visible = false;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.calendar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.removeCar);
            this.Controls.Add(this.reservedCars);
            this.Controls.Add(this.boxCars);
            this.Controls.Add(this.hideCars);
            this.Controls.Add(this.reserveBtn);
            this.Controls.Add(this.availableBtn);
            this.Name = "MainProgram";
            this.Text = "RentACar";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button availableBtn;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.Button hideCars;
        private System.Windows.Forms.ListBox boxCars;
        private System.Windows.Forms.ListBox reservedCars;
        private System.Windows.Forms.Button removeCar;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker calendar2;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
    }
}