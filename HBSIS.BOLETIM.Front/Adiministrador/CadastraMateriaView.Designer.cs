namespace HBSIS.BOLETIM.Front.Adiministrador
{
    partial class CadastraMateriaView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_erro3 = new System.Windows.Forms.Label();
            this.lbl_erro2 = new System.Windows.Forms.Label();
            this.lbl_erro1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de disciplinas";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(311, 443);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Situação";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(519, 76);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(380, 30);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(519, 133);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(380, 117);
            this.txt_descricao.TabIndex = 7;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(630, 306);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 8;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(409, 306);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(194, 33);
            this.comboBox.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(630, 550);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(262, 38);
            this.btn_cadastrar.TabIndex = 10;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(42, 571);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(262, 38);
            this.btn_deletar.TabIndex = 11;
            this.btn_deletar.Text = "DELETAR";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(42, 640);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(262, 38);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.Location = new System.Drawing.Point(515, 609);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(0, 25);
            this.lbl_ok.TabIndex = 13;
            // 
            // lbl_erro3
            // 
            this.lbl_erro3.AutoSize = true;
            this.lbl_erro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro3.Location = new System.Drawing.Point(515, 727);
            this.lbl_erro3.Name = "lbl_erro3";
            this.lbl_erro3.Size = new System.Drawing.Size(0, 25);
            this.lbl_erro3.TabIndex = 14;
            // 
            // lbl_erro2
            // 
            this.lbl_erro2.AutoSize = true;
            this.lbl_erro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro2.Location = new System.Drawing.Point(515, 685);
            this.lbl_erro2.Name = "lbl_erro2";
            this.lbl_erro2.Size = new System.Drawing.Size(0, 25);
            this.lbl_erro2.TabIndex = 15;
            // 
            // lbl_erro1
            // 
            this.lbl_erro1.AutoSize = true;
            this.lbl_erro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro1.Location = new System.Drawing.Point(515, 648);
            this.lbl_erro1.Name = "lbl_erro1";
            this.lbl_erro1.Size = new System.Drawing.Size(0, 25);
            this.lbl_erro1.TabIndex = 16;
            // 
            // CadastraMateriaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 820);
            this.Controls.Add(this.lbl_erro1);
            this.Controls.Add(this.lbl_erro2);
            this.Controls.Add(this.lbl_erro3);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "CadastraMateriaView";
            this.Text = "Cadastro de materias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_erro3;
        private System.Windows.Forms.Label lbl_erro2;
        private System.Windows.Forms.Label lbl_erro1;
    }
}