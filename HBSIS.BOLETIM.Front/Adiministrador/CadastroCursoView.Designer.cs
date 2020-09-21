namespace HBSIS.BOLETIM.Front.Adiministrador
{
    partial class CadastroCursoView
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.llist_Cursos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_erro1 = new System.Windows.Forms.Label();
            this.lbl_erro2 = new System.Windows.Forms.Label();
            this.lbl_erro3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de cursos cadastrados";
            // 
            // llist_Cursos
            // 
            this.llist_Cursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llist_Cursos.HideSelection = false;
            this.llist_Cursos.Location = new System.Drawing.Point(27, 86);
            this.llist_Cursos.Name = "llist_Cursos";
            this.llist_Cursos.Size = new System.Drawing.Size(344, 339);
            this.llist_Cursos.TabIndex = 2;
            this.llist_Cursos.UseCompatibleStateImageBehavior = false;
            this.llist_Cursos.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Situação";
            // 
            // txt_Curso
            // 
            this.txt_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Curso.Location = new System.Drawing.Point(533, 160);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(355, 30);
            this.txt_Curso.TabIndex = 6;
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ok.Location = new System.Drawing.Point(530, 457);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(0, 20);
            this.lbl_ok.TabIndex = 8;
            // 
            // lbl_erro1
            // 
            this.lbl_erro1.AutoSize = true;
            this.lbl_erro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_erro1.Location = new System.Drawing.Point(530, 493);
            this.lbl_erro1.Name = "lbl_erro1";
            this.lbl_erro1.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro1.TabIndex = 9;
            // 
            // lbl_erro2
            // 
            this.lbl_erro2.AutoSize = true;
            this.lbl_erro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_erro2.Location = new System.Drawing.Point(530, 530);
            this.lbl_erro2.Name = "lbl_erro2";
            this.lbl_erro2.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro2.TabIndex = 10;
            // 
            // lbl_erro3
            // 
            this.lbl_erro3.AutoSize = true;
            this.lbl_erro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_erro3.Location = new System.Drawing.Point(530, 570);
            this.lbl_erro3.Name = "lbl_erro3";
            this.lbl_erro3.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro3.TabIndex = 11;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(650, 265);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(237, 33);
            this.comboBox.TabIndex = 12;
            // 
            // CadastroCursoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 624);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lbl_erro3);
            this.Controls.Add(this.lbl_erro2);
            this.Controls.Add(this.lbl_erro1);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.txt_Curso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llist_Cursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CadastroCursoView";
            this.Text = "CadastroCursoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView llist_Cursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_erro1;
        private System.Windows.Forms.Label lbl_erro2;
        private System.Windows.Forms.Label lbl_erro3;
        private System.Windows.Forms.ComboBox comboBox;
    }
}