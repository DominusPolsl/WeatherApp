namespace Pogodynka
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel6 = new Panel();
            cityLbl = new Label();
            panel5 = new Panel();
            DescriptionLbl = new Label();
            refreshBtn = new Button();
            panel4 = new Panel();
            HumidLbl = new Label();
            panel3 = new Panel();
            PressureLbl = new Label();
            panel2 = new Panel();
            TempLbl = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cityTbx = new TextBox();
            label2 = new Label();
            label1 = new Label();
            capitalCbx = new ComboBox();
            iconPbx = new PictureBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPbx).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cityTbx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(capitalCbx);
            panel1.Controls.Add(iconPbx);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 737);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(cityLbl);
            panel6.Location = new Point(190, 197);
            panel6.Name = "panel6";
            panel6.Size = new Size(210, 66);
            panel6.TabIndex = 10;
            // 
            // cityLbl
            // 
            cityLbl.Dock = DockStyle.Top;
            cityLbl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityLbl.Location = new Point(0, 0);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new Size(210, 66);
            cityLbl.TabIndex = 1;
            cityLbl.Text = "----";
            cityLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(DescriptionLbl);
            panel5.Location = new Point(221, 469);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 33);
            panel5.TabIndex = 9;
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.Dock = DockStyle.Top;
            DescriptionLbl.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionLbl.Location = new Point(0, 0);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(147, 33);
            DescriptionLbl.TabIndex = 1;
            DescriptionLbl.Text = "----";
            DescriptionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.PaleGreen;
            refreshBtn.Location = new Point(400, 144);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(170, 29);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Get weather";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(HumidLbl);
            panel4.Location = new Point(332, 675);
            panel4.Name = "panel4";
            panel4.Size = new Size(147, 37);
            panel4.TabIndex = 10;
            // 
            // HumidLbl
            // 
            HumidLbl.Dock = DockStyle.Top;
            HumidLbl.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HumidLbl.Location = new Point(0, 0);
            HumidLbl.Name = "HumidLbl";
            HumidLbl.Size = new Size(147, 37);
            HumidLbl.TabIndex = 1;
            HumidLbl.Text = "----";
            HumidLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(PressureLbl);
            panel3.Location = new Point(332, 610);
            panel3.Name = "panel3";
            panel3.Size = new Size(147, 33);
            panel3.TabIndex = 9;
            // 
            // PressureLbl
            // 
            PressureLbl.Dock = DockStyle.Top;
            PressureLbl.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PressureLbl.Location = new Point(0, 0);
            PressureLbl.Name = "PressureLbl";
            PressureLbl.Size = new Size(147, 33);
            PressureLbl.TabIndex = 1;
            PressureLbl.Text = "----";
            PressureLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(TempLbl);
            panel2.Location = new Point(332, 546);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 33);
            panel2.TabIndex = 8;
            // 
            // TempLbl
            // 
            TempLbl.Dock = DockStyle.Top;
            TempLbl.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TempLbl.Location = new Point(0, 0);
            TempLbl.Name = "TempLbl";
            TempLbl.Size = new Size(147, 33);
            TempLbl.TabIndex = 1;
            TempLbl.Text = "----";
            TempLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(118, 682);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 7;
            label5.Text = "Humidity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(118, 617);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Pressure:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(118, 553);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 5;
            label3.Text = "Temperature:";
            // 
            // cityTbx
            // 
            cityTbx.Location = new Point(400, 87);
            cityTbx.Name = "cityTbx";
            cityTbx.Size = new Size(170, 27);
            cityTbx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(442, 52);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 3;
            label2.Text = "City name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 2;
            label1.Text = "Popular european capitals\r\n";
            // 
            // capitalCbx
            // 
            capitalCbx.FormattingEnabled = true;
            capitalCbx.Items.AddRange(new object[] { "London", "Berlin", "Madrid", "Roma", "Kyiv", "Paris", "Bucharest", "Budapest", "Minsk", "Warszawa", "Wien", "Beograd", "Praha", "Sofija", "Athenai", "Riga", "Stockholm", "Amsterdam", "Chisinau", "Zagreb" });
            capitalCbx.Location = new Point(53, 87);
            capitalCbx.Name = "capitalCbx";
            capitalCbx.Size = new Size(177, 28);
            capitalCbx.TabIndex = 1;
            capitalCbx.SelectedIndexChanged += capitalCbx_SelectedIndexChanged;
            // 
            // iconPbx
            // 
            iconPbx.BackColor = SystemColors.ScrollBar;
            iconPbx.Location = new Point(190, 269);
            iconPbx.Name = "iconPbx";
            iconPbx.Size = new Size(210, 183);
            iconPbx.SizeMode = PictureBoxSizeMode.Zoom;
            iconPbx.TabIndex = 0;
            iconPbx.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 753);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPbx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox iconPbx;
        private TextBox cityTbx;
        private Label label2;
        private Label label1;
        private ComboBox capitalCbx;
        private Label label4;
        private Label label3;
        private Label label5;
        private Panel panel4;
        private Label HumidLbl;
        private Panel panel3;
        private Label PressureLbl;
        private Panel panel2;
        private Label TempLbl;
        private Button refreshBtn;
        private Panel panel5;
        private Label DescriptionLbl;
        private Panel panel6;
        private Label cityLbl;
    }
}
