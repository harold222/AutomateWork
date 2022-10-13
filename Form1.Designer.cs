namespace automateWork
{
    partial class Form1
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
            this.initProcess = new System.Windows.Forms.Button();
            this.stopProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // button initProcess
            // 
            this.initProcess.BackColor = System.Drawing.Color.DarkCyan;
            this.initProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.initProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.initProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initProcess.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.initProcess.ForeColor = System.Drawing.Color.White;
            this.initProcess.Location = new System.Drawing.Point(132, 184);
            this.initProcess.Name = "initProcess";
            this.initProcess.Size = new System.Drawing.Size(97, 31);
            this.initProcess.TabIndex = 0;
            this.initProcess.Text = "Iniciar";
            this.initProcess.UseVisualStyleBackColor = false;
            this.initProcess.Click += new System.EventHandler(this.initProcess_Click);

            // 
            // button stopProcess
            // 
            this.stopProcess.BackColor = System.Drawing.Color.Red;
            this.stopProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stopProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopProcess.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopProcess.ForeColor = System.Drawing.Color.White;
            this.stopProcess.Location = new System.Drawing.Point(132, 230);
            this.stopProcess.Name = "stopProcess";
            this.stopProcess.Size = new System.Drawing.Size(97, 28);
            this.stopProcess.TabIndex = 1;
            this.stopProcess.Text = "Detener";
            this.stopProcess.UseVisualStyleBackColor = false;
            this.stopProcess.Click += new System.EventHandler(this.stopProcess_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 334);
            this.Controls.Add(this.stopProcess);
            this.Controls.Add(this.initProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private Button initProcess;
        private Button stopProcess;
    }
}