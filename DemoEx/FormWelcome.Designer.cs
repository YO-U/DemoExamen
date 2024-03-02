namespace DemoEx
{
    partial class FormWelcome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenSignIn = new System.Windows.Forms.Button();
            this.OpenSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenSignIn
            // 
            this.OpenSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSignIn.Location = new System.Drawing.Point(123, 235);
            this.OpenSignIn.Name = "OpenSignIn";
            this.OpenSignIn.Size = new System.Drawing.Size(123, 58);
            this.OpenSignIn.TabIndex = 3;
            this.OpenSignIn.Text = "Sign in";
            this.OpenSignIn.UseVisualStyleBackColor = true;
            this.OpenSignIn.Click += new System.EventHandler(this.OpenSignIn_Click);
            // 
            // OpenSignUp
            // 
            this.OpenSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSignUp.Location = new System.Drawing.Point(123, 101);
            this.OpenSignUp.Name = "OpenSignUp";
            this.OpenSignUp.Size = new System.Drawing.Size(123, 58);
            this.OpenSignUp.TabIndex = 2;
            this.OpenSignUp.Text = "Sign up";
            this.OpenSignUp.UseVisualStyleBackColor = true;
            this.OpenSignUp.Click += new System.EventHandler(this.OpenSignUp_Click);
            // 
            // FormWelcome
            // 
            this.ClientSize = new System.Drawing.Size(377, 419);
            this.Controls.Add(this.OpenSignIn);
            this.Controls.Add(this.OpenSignUp);
            this.Name = "FormWelcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button OpenSignIn;
        private System.Windows.Forms.Button OpenSignUp;
    }
}

