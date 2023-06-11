namespace PresentationLayer
{
    partial class CupboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cupboardsGridView = new System.Windows.Forms.DataGridView();
            this.roomTxtBox = new System.Windows.Forms.TextBox();
            this.scientistTxtBox = new System.Windows.Forms.TextBox();
            this.lightTxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.petriDishListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cupboardsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scientist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Light Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Petri Dishes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cupboards";
            // 
            // cupboardsGridView
            // 
            this.cupboardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cupboardsGridView.Location = new System.Drawing.Point(318, 41);
            this.cupboardsGridView.Name = "cupboardsGridView";
            this.cupboardsGridView.RowHeadersWidth = 51;
            this.cupboardsGridView.RowTemplate.Height = 29;
            this.cupboardsGridView.Size = new System.Drawing.Size(470, 397);
            this.cupboardsGridView.TabIndex = 6;
            this.cupboardsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cupboardsGridView_CellClick);
            // 
            // roomTxtBox
            // 
            this.roomTxtBox.Location = new System.Drawing.Point(118, 41);
            this.roomTxtBox.Name = "roomTxtBox";
            this.roomTxtBox.Size = new System.Drawing.Size(194, 27);
            this.roomTxtBox.TabIndex = 7;
            // 
            // scientistTxtBox
            // 
            this.scientistTxtBox.Location = new System.Drawing.Point(118, 81);
            this.scientistTxtBox.Name = "scientistTxtBox";
            this.scientistTxtBox.Size = new System.Drawing.Size(194, 27);
            this.scientistTxtBox.TabIndex = 8;
            // 
            // lightTxtBox
            // 
            this.lightTxtBox.Location = new System.Drawing.Point(118, 125);
            this.lightTxtBox.Name = "lightTxtBox";
            this.lightTxtBox.Size = new System.Drawing.Size(194, 27);
            this.lightTxtBox.TabIndex = 9;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(16, 225);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 29);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(118, 225);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(218, 225);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(118, 260);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(218, 260);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(94, 29);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // petriDishListBox
            // 
            this.petriDishListBox.FormattingEnabled = true;
            this.petriDishListBox.ItemHeight = 20;
            this.petriDishListBox.Location = new System.Drawing.Point(12, 334);
            this.petriDishListBox.Name = "petriDishListBox";
            this.petriDishListBox.Size = new System.Drawing.Size(295, 104);
            this.petriDishListBox.TabIndex = 16;
            // 
            // CupboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.petriDishListBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.lightTxtBox);
            this.Controls.Add(this.scientistTxtBox);
            this.Controls.Add(this.roomTxtBox);
            this.Controls.Add(this.cupboardsGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CupboardForm";
            this.Text = "CupboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.cupboardsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView cupboardsGridView;
        private System.Windows.Forms.TextBox roomTxtBox;
        private System.Windows.Forms.TextBox scientistTxtBox;
        private System.Windows.Forms.TextBox lightTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListBox petriDishListBox;
    }
}