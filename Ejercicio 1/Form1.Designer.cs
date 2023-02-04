namespace Ejercicio_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumtextBox = new System.Windows.Forms.TextBox();
            this.RestextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RestextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // NumtextBox
            // 
            this.NumtextBox.Location = new System.Drawing.Point(251, 45);
            this.NumtextBox.Name = "NumtextBox";
            this.NumtextBox.Size = new System.Drawing.Size(211, 23);
            this.NumtextBox.TabIndex = 2;
            // 
            // RestextBox1
            // 
            this.RestextBox1.Location = new System.Drawing.Point(251, 129);
            this.RestextBox1.Name = "RestextBox1";
            this.RestextBox1.Size = new System.Drawing.Size(211, 23);
            this.RestextBox1.TabIndex = 3;
            this.RestextBox1.TextChanged += new System.EventHandler(this.RestextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestextBox2
            // 
            this.RestextBox2.Location = new System.Drawing.Point(251, 174);
            this.RestextBox2.Name = "RestextBox2";
            this.RestextBox2.Size = new System.Drawing.Size(211, 23);
            this.RestextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Par o Impar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Positivo o Negativo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(219, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejercicio #1 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RestextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RestextBox1);
            this.Controls.Add(this.NumtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NumtextBox;
        private TextBox RestextBox1;
        private Button button1;
        private TextBox RestextBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}