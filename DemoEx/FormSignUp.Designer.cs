namespace DemoEx
{
    partial class FormSignUp
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
            this.CreateUser = new System.Windows.Forms.Button();
            this.radioDirectorate = new System.Windows.Forms.RadioButton();
            this.radioStorekeepers = new System.Windows.Forms.RadioButton();
            this.radioManagers = new System.Windows.Forms.RadioButton();
            this.radioCustomer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Namee = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateUser
            // 
            this.CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUser.Location = new System.Drawing.Point(118, 346);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(118, 42);
            this.CreateUser.TabIndex = 34;
            this.CreateUser.Text = "Create";
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click_1);
            // 
            // radioDirectorate
            // 
            this.radioDirectorate.AutoSize = true;
            this.radioDirectorate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioDirectorate.Location = new System.Drawing.Point(178, 304);
            this.radioDirectorate.Name = "radioDirectorate";
            this.radioDirectorate.Size = new System.Drawing.Size(96, 21);
            this.radioDirectorate.TabIndex = 33;
            this.radioDirectorate.TabStop = true;
            this.radioDirectorate.Text = "Directorate";
            this.radioDirectorate.UseVisualStyleBackColor = true;
            // 
            // radioStorekeepers
            // 
            this.radioStorekeepers.AutoSize = true;
            this.radioStorekeepers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioStorekeepers.Location = new System.Drawing.Point(180, 281);
            this.radioStorekeepers.Name = "radioStorekeepers";
            this.radioStorekeepers.Size = new System.Drawing.Size(111, 21);
            this.radioStorekeepers.TabIndex = 32;
            this.radioStorekeepers.TabStop = true;
            this.radioStorekeepers.Text = "Storekeepers";
            this.radioStorekeepers.UseVisualStyleBackColor = true;
            // 
            // radioManagers
            // 
            this.radioManagers.AutoSize = true;
            this.radioManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioManagers.Location = new System.Drawing.Point(83, 304);
            this.radioManagers.Name = "radioManagers";
            this.radioManagers.Size = new System.Drawing.Size(89, 21);
            this.radioManagers.TabIndex = 31;
            this.radioManagers.TabStop = true;
            this.radioManagers.Text = "Managers";
            this.radioManagers.UseVisualStyleBackColor = true;
            // 
            // radioCustomer
            // 
            this.radioCustomer.AutoSize = true;
            this.radioCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioCustomer.Location = new System.Drawing.Point(83, 281);
            this.radioCustomer.Name = "radioCustomer";
            this.radioCustomer.Size = new System.Drawing.Size(93, 21);
            this.radioCustomer.TabIndex = 30;
            this.radioCustomer.TabStop = true;
            this.radioCustomer.Text = "Customers";
            this.radioCustomer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(151, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(102, 209);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(148, 23);
            this.Password.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(143, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Login";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(102, 132);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(148, 23);
            this.Login.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // Namee
            // 
            this.Namee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namee.Location = new System.Drawing.Point(102, 59);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(148, 23);
            this.Namee.TabIndex = 23;
            this.Namee.TextChanged += new System.EventHandler(this.Namee_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(304, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 35;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 453);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.radioDirectorate);
            this.Controls.Add(this.radioStorekeepers);
            this.Controls.Add(this.radioManagers);
            this.Controls.Add(this.radioCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namee);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.RadioButton radioDirectorate;
        private System.Windows.Forms.RadioButton radioStorekeepers;
        private System.Windows.Forms.RadioButton radioManagers;
        private System.Windows.Forms.RadioButton radioCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Namee;
        private System.Windows.Forms.Button Back;
    }
}