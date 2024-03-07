namespace Presupuesto_Hospital
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
            btn_pagos = new Button();
            btn_limpiar = new Button();
            btn_cerrar = new Button();
            txt_presupuesto = new TextBox();
            txt_eme = new TextBox();
            txt_cir = new TextBox();
            txt_sum = new TextBox();
            txt_adm = new TextBox();
            txt_lab = new TextBox();
            txt_ima = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btn_pagos
            // 
            btn_pagos.BackColor = Color.FromArgb(255, 224, 192);
            btn_pagos.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pagos.Location = new Point(610, 502);
            btn_pagos.Margin = new Padding(4, 5, 4, 5);
            btn_pagos.Name = "btn_pagos";
            btn_pagos.Size = new Size(111, 50);
            btn_pagos.TabIndex = 0;
            btn_pagos.Text = "Pagar";
            btn_pagos.UseVisualStyleBackColor = false;
            btn_pagos.Click += pagos_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(255, 224, 192);
            btn_limpiar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.Location = new Point(741, 502);
            btn_limpiar.Margin = new Padding(4, 5, 4, 5);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(111, 50);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += limpiar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.FromArgb(255, 224, 192);
            btn_cerrar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cerrar.Location = new Point(873, 502);
            btn_cerrar.Margin = new Padding(4, 5, 4, 5);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(111, 50);
            btn_cerrar.TabIndex = 2;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += cerrar_Click;
            // 
            // txt_presupuesto
            // 
            txt_presupuesto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_presupuesto.Location = new Point(413, 53);
            txt_presupuesto.Margin = new Padding(4, 5, 4, 5);
            txt_presupuesto.Name = "txt_presupuesto";
            txt_presupuesto.Size = new Size(141, 26);
            txt_presupuesto.TabIndex = 3;
            // 
            // txt_eme
            // 
            txt_eme.Location = new Point(333, 125);
            txt_eme.Margin = new Padding(4, 5, 4, 5);
            txt_eme.Name = "txt_eme";
            txt_eme.Size = new Size(141, 31);
            txt_eme.TabIndex = 4;
            // 
            // txt_cir
            // 
            txt_cir.Location = new Point(333, 172);
            txt_cir.Margin = new Padding(4, 5, 4, 5);
            txt_cir.Name = "txt_cir";
            txt_cir.Size = new Size(141, 31);
            txt_cir.TabIndex = 5;
            // 
            // txt_sum
            // 
            txt_sum.Location = new Point(333, 238);
            txt_sum.Margin = new Padding(4, 5, 4, 5);
            txt_sum.Name = "txt_sum";
            txt_sum.Size = new Size(141, 31);
            txt_sum.TabIndex = 6;
            // 
            // txt_adm
            // 
            txt_adm.Location = new Point(333, 302);
            txt_adm.Margin = new Padding(4, 5, 4, 5);
            txt_adm.Name = "txt_adm";
            txt_adm.Size = new Size(141, 31);
            txt_adm.TabIndex = 7;
            txt_adm.TextChanged += textBox5_TextChanged;
            // 
            // txt_lab
            // 
            txt_lab.Location = new Point(333, 365);
            txt_lab.Margin = new Padding(4, 5, 4, 5);
            txt_lab.Name = "txt_lab";
            txt_lab.Size = new Size(141, 31);
            txt_lab.TabIndex = 8;
            // 
            // txt_ima
            // 
            txt_ima.Location = new Point(435, 431);
            txt_ima.Margin = new Padding(4, 5, 4, 5);
            txt_ima.Name = "txt_ima";
            txt_ima.Size = new Size(141, 31);
            txt_ima.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 32);
            label1.TabIndex = 10;
            label1.Text = "Presupuesto del Hospital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(110, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 11;
            label2.Text = "Emergencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 12;
            label3.Text = "Cirujía";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(110, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 13;
            label4.Text = "Suministros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(110, 315);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(172, 32);
            label5.TabIndex = 14;
            label5.Text = "Aministración";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(110, 378);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 32);
            label6.TabIndex = 15;
            label6.Text = "Laboratorio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(110, 442);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(279, 32);
            label7.TabIndex = 16;
            label7.Text = "Imágenes Diagnosticas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1029, 561);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ima);
            Controls.Add(txt_lab);
            Controls.Add(txt_adm);
            Controls.Add(txt_sum);
            Controls.Add(txt_cir);
            Controls.Add(txt_eme);
            Controls.Add(txt_presupuesto);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_pagos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Dia de Pago del Hospital ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pagos;
        private Button btn_limpiar;
        private Button btn_cerrar;
        private TextBox txt_presupuesto;
        private TextBox txt_eme;
        private TextBox txt_cir;
        private TextBox txt_sum;
        private TextBox txt_adm;
        private TextBox txt_lab;
        private TextBox txt_ima;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}