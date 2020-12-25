
namespace SolutionExam
{
    partial class Form1
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.getImage = new System.Windows.Forms.Button();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.emPic = new System.Windows.Forms.PictureBox();
            this.deEm = new System.Windows.Forms.Button();
            this.edEm = new System.Windows.Forms.Button();
            this.regEm = new System.Windows.Forms.Button();
            this.dataGridEm = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEm)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(605, 188);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 164;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // getImage
            // 
            this.getImage.Location = new System.Drawing.Point(605, 63);
            this.getImage.Name = "getImage";
            this.getImage.Size = new System.Drawing.Size(75, 23);
            this.getImage.TabIndex = 163;
            this.getImage.Text = "Browse";
            this.getImage.UseVisualStyleBackColor = true;
            this.getImage.Click += new System.EventHandler(this.getImage_Click);
            // 
            // dobBox
            // 
            this.dobBox.CustomFormat = "\"dddd ,dd MMMM, yyyy\"";
            this.dobBox.Location = new System.Drawing.Point(103, 126);
            this.dobBox.Name = "dobBox";
            this.dobBox.ShowCheckBox = true;
            this.dobBox.Size = new System.Drawing.Size(200, 20);
            this.dobBox.TabIndex = 162;
            // 
            // emPic
            // 
            this.emPic.BackColor = System.Drawing.SystemColors.Window;
            this.emPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emPic.Location = new System.Drawing.Point(441, 61);
            this.emPic.Name = "emPic";
            this.emPic.Size = new System.Drawing.Size(150, 150);
            this.emPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emPic.TabIndex = 161;
            this.emPic.TabStop = false;
            // 
            // deEm
            // 
            this.deEm.Location = new System.Drawing.Point(228, 197);
            this.deEm.Name = "deEm";
            this.deEm.Size = new System.Drawing.Size(75, 23);
            this.deEm.TabIndex = 160;
            this.deEm.Text = "Delete";
            this.deEm.UseVisualStyleBackColor = true;
            this.deEm.Click += new System.EventHandler(this.deEm_Click);
            // 
            // edEm
            // 
            this.edEm.Location = new System.Drawing.Point(128, 197);
            this.edEm.Name = "edEm";
            this.edEm.Size = new System.Drawing.Size(75, 23);
            this.edEm.TabIndex = 159;
            this.edEm.Text = "Save";
            this.edEm.UseVisualStyleBackColor = true;
            this.edEm.Click += new System.EventHandler(this.edEm_Click);
            // 
            // regEm
            // 
            this.regEm.Location = new System.Drawing.Point(30, 197);
            this.regEm.Name = "regEm";
            this.regEm.Size = new System.Drawing.Size(75, 23);
            this.regEm.TabIndex = 158;
            this.regEm.Text = "Register";
            this.regEm.UseVisualStyleBackColor = true;
            this.regEm.Click += new System.EventHandler(this.regEm_Click);
            // 
            // dataGridEm
            // 
            this.dataGridEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEm.Location = new System.Drawing.Point(12, 235);
            this.dataGridEm.Name = "dataGridEm";
            this.dataGridEm.Size = new System.Drawing.Size(776, 205);
            this.dataGridEm.TabIndex = 157;
            this.dataGridEm.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridEm_RowHeaderMouseClick);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(103, 94);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 20);
            this.nameBox.TabIndex = 156;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(103, 63);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 154;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 153;
            this.label4.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 152;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 151;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 150;
            this.label1.Text = "Example";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.getImage);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(this.emPic);
            this.Controls.Add(this.deEm);
            this.Controls.Add(this.edEm);
            this.Controls.Add(this.regEm);
            this.Controls.Add(this.dataGridEm);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button getImage;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.PictureBox emPic;
        private System.Windows.Forms.Button deEm;
        private System.Windows.Forms.Button edEm;
        private System.Windows.Forms.Button regEm;
        private System.Windows.Forms.DataGridView dataGridEm;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

