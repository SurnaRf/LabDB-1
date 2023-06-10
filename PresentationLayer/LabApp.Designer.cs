namespace PresentationLayer
{
    partial class LabApp
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
            this.colonyBtn = new System.Windows.Forms.Button();
            this.petriDishBtn = new System.Windows.Forms.Button();
            this.cupboardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colonyBtn
            // 
            this.colonyBtn.Location = new System.Drawing.Point(103, 223);
            this.colonyBtn.Name = "colonyBtn";
            this.colonyBtn.Size = new System.Drawing.Size(94, 29);
            this.colonyBtn.TabIndex = 0;
            this.colonyBtn.Text = "Colonies";
            this.colonyBtn.UseVisualStyleBackColor = true;
            // 
            // petriDishBtn
            // 
            this.petriDishBtn.Location = new System.Drawing.Point(330, 223);
            this.petriDishBtn.Name = "petriDishBtn";
            this.petriDishBtn.Size = new System.Drawing.Size(94, 29);
            this.petriDishBtn.TabIndex = 1;
            this.petriDishBtn.Text = "Petri Dishes";
            this.petriDishBtn.UseVisualStyleBackColor = true;
            // 
            // cupboardBtn
            // 
            this.cupboardBtn.Location = new System.Drawing.Point(562, 223);
            this.cupboardBtn.Name = "cupboardBtn";
            this.cupboardBtn.Size = new System.Drawing.Size(94, 29);
            this.cupboardBtn.TabIndex = 2;
            this.cupboardBtn.Text = "Cupboards";
            this.cupboardBtn.UseVisualStyleBackColor = true;
            this.cupboardBtn.Click += new System.EventHandler(this.cupboardBtn_Click);
            // 
            // LabApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cupboardBtn);
            this.Controls.Add(this.petriDishBtn);
            this.Controls.Add(this.colonyBtn);
            this.Name = "LabApp";
            this.Text = "LabApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colonyBtn;
        private System.Windows.Forms.Button petriDishBtn;
        private System.Windows.Forms.Button cupboardBtn;
    }
}