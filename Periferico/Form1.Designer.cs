namespace Periferico
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtCor = new TextBox();
            txtData = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Fabricacao";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Periferico Id";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(124, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(318, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(124, 79);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(318, 23);
            txtCor.TabIndex = 5;
            // 
            // txtData
            // 
            txtData.Location = new Point(124, 112);
            txtData.Name = "txtData";
            txtData.Size = new Size(318, 23);
            txtData.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 18);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(629, 295);
            Controls.Add(label5);
            Controls.Add(txtData);
            Controls.Add(txtCor);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Periferico";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtCor;
        private TextBox txtData;
        private Label label5;
    }
}
