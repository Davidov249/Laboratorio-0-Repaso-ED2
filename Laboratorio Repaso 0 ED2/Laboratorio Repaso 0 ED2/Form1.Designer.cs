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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.btn_Clista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_OrdAs = new System.Windows.Forms.Button();
            this.btn_OrdDes = new System.Windows.Forms.Button();
            this.ListaActual = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(126, 23);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(725, 22);
            this.txt1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(891, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(24, 26);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(72, 17);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Buscador:";
            // 
            // btn_Clista
            // 
            this.btn_Clista.Location = new System.Drawing.Point(903, 329);
            this.btn_Clista.Name = "btn_Clista";
            this.btn_Clista.Size = new System.Drawing.Size(108, 48);
            this.btn_Clista.TabIndex = 3;
            this.btn_Clista.Text = "Crear Lista";
            this.btn_Clista.UseVisualStyleBackColor = true;
            this.btn_Clista.Click += new System.EventHandler(this.btn_Clista_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListaActual);
            this.panel1.Location = new System.Drawing.Point(515, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 311);
            this.panel1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 59);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(368, 261);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.lb1);
            this.panel2.Location = new System.Drawing.Point(12, 564);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 66);
            this.panel2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(497, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_OrdAs
            // 
            this.btn_OrdAs.Location = new System.Drawing.Point(787, 329);
            this.btn_OrdAs.Name = "btn_OrdAs";
            this.btn_OrdAs.Size = new System.Drawing.Size(110, 48);
            this.btn_OrdAs.TabIndex = 8;
            this.btn_OrdAs.Text = "Ordenar Ascendente";
            this.btn_OrdAs.UseVisualStyleBackColor = true;
            // 
            // btn_OrdDes
            // 
            this.btn_OrdDes.Location = new System.Drawing.Point(671, 329);
            this.btn_OrdDes.Name = "btn_OrdDes";
            this.btn_OrdDes.Size = new System.Drawing.Size(110, 48);
            this.btn_OrdDes.TabIndex = 9;
            this.btn_OrdDes.Text = "Ordenar Descendente";
            this.btn_OrdDes.UseVisualStyleBackColor = true;
            // 
            // ListaActual
            // 
            this.ListaActual.FormattingEnabled = true;
            this.ListaActual.ItemHeight = 16;
            this.ListaActual.Location = new System.Drawing.Point(3, 16);
            this.ListaActual.Name = "ListaActual";
            this.ListaActual.Size = new System.Drawing.Size(490, 292);
            this.ListaActual.TabIndex = 0;
            this.ListaActual.SelectedIndexChanged += new System.EventHandler(this.ListaActual_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lista de reproducción actual";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(518, 329);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(518, 356);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 21);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Duración";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtNombreL
            // 
            this.txtNombreL.Location = new System.Drawing.Point(671, 381);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.Size = new System.Drawing.Size(340, 22);
            this.txtNombreL.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 642);
            this.Controls.Add(this.txtNombreL);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OrdDes);
            this.Controls.Add(this.btn_OrdAs);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Clista);
            this.Name = "Form1";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn_Clista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox ListaActual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_OrdAs;
        private System.Windows.Forms.Button btn_OrdDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtNombreL;
    }
}

