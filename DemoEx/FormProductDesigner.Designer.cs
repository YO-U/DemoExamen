namespace DemoEx
{
    partial class FormProductDesigner
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxHardwareSizes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPlacements = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxHardware = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdging = new System.Windows.Forms.ComboBox();
            this.comboBoxFabric = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(101, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 31;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxHardwareSizes
            // 
            this.comboBoxHardwareSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHardwareSizes.FormattingEnabled = true;
            this.comboBoxHardwareSizes.Items.AddRange(new object[] {
            "Мелкая",
            "Средняя",
            "Крупная",
            "Миниатюрная",
            "Большая"});
            this.comboBoxHardwareSizes.Location = new System.Drawing.Point(159, 204);
            this.comboBoxHardwareSizes.Name = "comboBoxHardwareSizes";
            this.comboBoxHardwareSizes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHardwareSizes.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(19, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hrdware sizes";
            // 
            // comboBoxPlacements
            // 
            this.comboBoxPlacements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPlacements.FormattingEnabled = true;
            this.comboBoxPlacements.Items.AddRange(new object[] {
            "По центру",
            "По бокам",
            "На плечах",
            "На рукавах",
            "На воротнике"});
            this.comboBoxPlacements.Location = new System.Drawing.Point(159, 174);
            this.comboBoxPlacements.Name = "comboBoxPlacements";
            this.comboBoxPlacements.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPlacements.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Placements";
            // 
            // comboBoxHardware
            // 
            this.comboBoxHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHardware.FormattingEnabled = true;
            this.comboBoxHardware.Items.AddRange(new object[] {
            "Пуговицы",
            "Молнии",
            "Ленты",
            "Кнопки",
            "Застёжки"});
            this.comboBoxHardware.Location = new System.Drawing.Point(159, 144);
            this.comboBoxHardware.Name = "comboBoxHardware";
            this.comboBoxHardware.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHardware.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hardware";
            // 
            // comboBoxEdging
            // 
            this.comboBoxEdging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEdging.FormattingEnabled = true;
            this.comboBoxEdging.Items.AddRange(new object[] {
            "Обрубка",
            "Обмётка",
            "Защип",
            "Обмётка",
            "Завязка"});
            this.comboBoxEdging.Location = new System.Drawing.Point(159, 114);
            this.comboBoxEdging.Name = "comboBoxEdging";
            this.comboBoxEdging.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEdging.TabIndex = 24;
            // 
            // comboBoxFabric
            // 
            this.comboBoxFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFabric.FormattingEnabled = true;
            this.comboBoxFabric.Items.AddRange(new object[] {
            "Хлопок",
            "Шерсть",
            "Шелк",
            "Полиэстер",
            "Лен"});
            this.comboBoxFabric.Location = new System.Drawing.Point(159, 82);
            this.comboBoxFabric.Name = "comboBoxFabric";
            this.comboBoxFabric.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFabric.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Edging";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(87, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fabric";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hight";
            // 
            // textBoxHight
            // 
            this.textBoxHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHight.Location = new System.Drawing.Point(159, 52);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(100, 23);
            this.textBoxHight.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Width";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.Location = new System.Drawing.Point(159, 24);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 23);
            this.textBoxWidth.TabIndex = 17;
            // 
            // FormProductDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxHardwareSizes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPlacements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHardware);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEdging);
            this.Controls.Add(this.comboBoxFabric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWidth);
            this.Name = "FormProductDesigner";
            this.Text = "ProductDesigner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxHardwareSizes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPlacements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxHardware;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEdging;
        private System.Windows.Forms.ComboBox comboBoxFabric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWidth;
    }
}