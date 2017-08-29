namespace Laboratorio_Repaso_0_ED2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.btn_Clista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(207, 53);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(454, 22);
            this.txt1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(683, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(105, 56);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(72, 17);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Buscador:";
            // 
            // btn_Clista
            // 
            this.btn_Clista.Location = new System.Drawing.Point(835, 42);
            this.btn_Clista.Name = "btn_Clista";
            this.btn_Clista.Size = new System.Drawing.Size(108, 45);
            this.btn_Clista.TabIndex = 3;
            this.btn_Clista.Text = "Crear Lista";
            this.btn_Clista.UseVisualStyleBackColor = true;
            this.btn_Clista.Click += new System.EventHandler(this.btn_Clista_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(447, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 311);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Clista);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn_Clista;
        private System.Windows.Forms.Panel panel1;
    }
}

