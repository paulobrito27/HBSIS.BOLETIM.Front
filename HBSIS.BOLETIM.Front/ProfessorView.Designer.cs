namespace HBSIS.BOLETIM.Front
{
    partial class ProfessorView
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
            this.boxAluno = new System.Windows.Forms.ComboBox();
            this.boxMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_erro1 = new System.Windows.Forms.Label();
            this.lbl_erro2 = new System.Windows.Forms.Label();
            this.lbl_erro3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxAluno
            // 
            this.boxAluno.FormattingEnabled = true;
            this.boxAluno.Location = new System.Drawing.Point(298, 183);
            this.boxAluno.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boxAluno.Name = "boxAluno";
            this.boxAluno.Size = new System.Drawing.Size(479, 37);
            this.boxAluno.TabIndex = 0;
            this.boxAluno.SelectedIndexChanged += new System.EventHandler(this.boxAluno_SelectedIndexChanged);
            // 
            // boxMateria
            // 
            this.boxMateria.FormattingEnabled = true;
            this.boxMateria.Location = new System.Drawing.Point(298, 330);
            this.boxMateria.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boxMateria.Name = "boxMateria";
            this.boxMateria.Size = new System.Drawing.Size(479, 37);
            this.boxMateria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1664, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(378, 425);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(145, 36);
            this.txtNota.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 60);
            this.label5.TabIndex = 7;
            this.label5.Text = "Atribuir notas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Location = new System.Drawing.Point(134, 573);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(0, 29);
            this.lbl_ok.TabIndex = 9;
            // 
            // lbl_erro1
            // 
            this.lbl_erro1.AutoSize = true;
            this.lbl_erro1.Location = new System.Drawing.Point(134, 622);
            this.lbl_erro1.Name = "lbl_erro1";
            this.lbl_erro1.Size = new System.Drawing.Size(0, 29);
            this.lbl_erro1.TabIndex = 10;
            // 
            // lbl_erro2
            // 
            this.lbl_erro2.AutoSize = true;
            this.lbl_erro2.Location = new System.Drawing.Point(134, 669);
            this.lbl_erro2.Name = "lbl_erro2";
            this.lbl_erro2.Size = new System.Drawing.Size(0, 29);
            this.lbl_erro2.TabIndex = 11;
            // 
            // lbl_erro3
            // 
            this.lbl_erro3.AutoSize = true;
            this.lbl_erro3.Location = new System.Drawing.Point(134, 718);
            this.lbl_erro3.Name = "lbl_erro3";
            this.lbl_erro3.Size = new System.Drawing.Size(0, 29);
            this.lbl_erro3.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1128, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_erro3);
            this.Controls.Add(this.lbl_erro2);
            this.Controls.Add(this.lbl_erro1);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxMateria);
            this.Controls.Add(this.boxAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ProfessorView";
            this.Text = "Ambiente do Docente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxAluno;
        private System.Windows.Forms.ComboBox boxMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_erro1;
        private System.Windows.Forms.Label lbl_erro2;
        private System.Windows.Forms.Label lbl_erro3;
        private System.Windows.Forms.Button button2;
    }
}