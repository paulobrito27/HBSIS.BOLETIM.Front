namespace HBSIS.BOLETIM.Front.Adiministrador
{
    partial class MatAlunoCursoView
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
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_Cursos = new System.Windows.Forms.ComboBox();
            this.box_Alunos = new System.Windows.Forms.ComboBox();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_erro1 = new System.Windows.Forms.Label();
            this.lbl_erro2 = new System.Windows.Forms.Label();
            this.lbl_erro3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(132, 116);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(293, 35);
            this.btn_Cadastrar.TabIndex = 0;
            this.btn_Cadastrar.Text = "Matricular Curso";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alunos";
            // 
            // box_Cursos
            // 
            this.box_Cursos.FormattingEnabled = true;
            this.box_Cursos.Location = new System.Drawing.Point(132, 9);
            this.box_Cursos.Name = "box_Cursos";
            this.box_Cursos.Size = new System.Drawing.Size(293, 24);
            this.box_Cursos.TabIndex = 12;
            // 
            // box_Alunos
            // 
            this.box_Alunos.FormattingEnabled = true;
            this.box_Alunos.Location = new System.Drawing.Point(132, 59);
            this.box_Alunos.Name = "box_Alunos";
            this.box_Alunos.Size = new System.Drawing.Size(293, 24);
            this.box_Alunos.TabIndex = 13;
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.Location = new System.Drawing.Point(44, 241);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(0, 31);
            this.lbl_ok.TabIndex = 14;
            // 
            // lbl_erro1
            // 
            this.lbl_erro1.AutoSize = true;
            this.lbl_erro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro1.Location = new System.Drawing.Point(44, 288);
            this.lbl_erro1.Name = "lbl_erro1";
            this.lbl_erro1.Size = new System.Drawing.Size(0, 31);
            this.lbl_erro1.TabIndex = 15;
            // 
            // lbl_erro2
            // 
            this.lbl_erro2.AutoSize = true;
            this.lbl_erro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro2.Location = new System.Drawing.Point(44, 331);
            this.lbl_erro2.Name = "lbl_erro2";
            this.lbl_erro2.Size = new System.Drawing.Size(0, 31);
            this.lbl_erro2.TabIndex = 16;
            // 
            // lbl_erro3
            // 
            this.lbl_erro3.AutoSize = true;
            this.lbl_erro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro3.Location = new System.Drawing.Point(44, 377);
            this.lbl_erro3.Name = "lbl_erro3";
            this.lbl_erro3.Size = new System.Drawing.Size(0, 31);
            this.lbl_erro3.TabIndex = 17;
            // 
            // MatAlunoCursoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 432);
            this.Controls.Add(this.lbl_erro3);
            this.Controls.Add(this.lbl_erro2);
            this.Controls.Add(this.lbl_erro1);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.box_Alunos);
            this.Controls.Add(this.box_Cursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cadastrar);
            this.Name = "MatAlunoCursoView";
            this.Text = "Matricular Aluno em Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_Cursos;
        private System.Windows.Forms.ComboBox box_Alunos;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_erro1;
        private System.Windows.Forms.Label lbl_erro2;
        private System.Windows.Forms.Label lbl_erro3;
    }
}