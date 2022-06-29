
namespace NetworkSystem
{
    partial class MainForm
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.srcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loadBtn.FlatAppearance.BorderSize = 10;
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadBtn.Location = new System.Drawing.Point(273, 90);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(248, 63);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load your file";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // loadinglbl
            // 
            this.loadinglbl.AutoSize = true;
            this.loadinglbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadinglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadinglbl.Location = new System.Drawing.Point(318, 182);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(170, 38);
            this.loadinglbl.TabIndex = 1;
            this.loadinglbl.Text = "Loading......";
            this.loadinglbl.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(169, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show network metrics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // srcBtn
            // 
            this.srcBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.srcBtn.Location = new System.Drawing.Point(452, 274);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(178, 78);
            this.srcBtn.TabIndex = 3;
            this.srcBtn.Text = "Search Node";
            this.srcBtn.UseVisualStyleBackColor = false;
            this.srcBtn.Visible = false;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadinglbl);
            this.Controls.Add(this.loadBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label loadinglbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button srcBtn;
    }
}