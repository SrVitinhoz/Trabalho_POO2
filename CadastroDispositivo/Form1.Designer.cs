namespace CadastroDispositivo
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAliquota = new TextBox();
            txtDescricao = new TextBox();
            txtStatus = new TextBox();
            btnCadastrar = new Button();
            dataGridViewDispositivos = new DataGridView();
            btnListar = new Button();
            label4 = new Label();
            txtIdDeletar = new TextBox();
            btnDeletar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAtualizar = new Button();
            txtIdAtualizar = new TextBox();
            txtAliquotaAtualizar = new TextBox();
            txtDescricaoAtualizar = new TextBox();
            txtStatusAtualizar = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDispositivos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleDescription = "";
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 437);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(txtStatus);
            tabPage1.Controls.Add(txtDescricao);
            tabPage1.Controls.Add(txtAliquota);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CadastrarMaquininha";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnListar);
            tabPage2.Controls.Add(dataGridViewDispositivos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ListarMaquininha";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnDeletar);
            tabPage3.Controls.Add(txtIdDeletar);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 409);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "DeletarMaquininha";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtStatusAtualizar);
            tabPage4.Controls.Add(txtDescricaoAtualizar);
            tabPage4.Controls.Add(txtAliquotaAtualizar);
            tabPage4.Controls.Add(txtIdAtualizar);
            tabPage4.Controls.Add(btnAtualizar);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 409);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "AtualizarMaquininha";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Aliquota :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 132);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 234);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Status Dispositivo :";
            // 
            // txtAliquota
            // 
            txtAliquota.Location = new Point(294, 68);
            txtAliquota.Name = "txtAliquota";
            txtAliquota.Size = new Size(175, 23);
            txtAliquota.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(294, 175);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(175, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(294, 285);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(175, 23);
            txtStatus.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(638, 349);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDispositivos
            // 
            dataGridViewDispositivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDispositivos.Location = new Point(6, 6);
            dataGridViewDispositivos.Name = "dataGridViewDispositivos";
            dataGridViewDispositivos.Size = new Size(743, 361);
            dataGridViewDispositivos.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(651, 373);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(98, 30);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 42);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 0;
            label4.Text = "Insira o ID :";
            // 
            // txtIdDeletar
            // 
            txtIdDeletar.Location = new Point(314, 78);
            txtIdDeletar.Name = "txtIdDeletar";
            txtIdDeletar.Size = new Size(105, 23);
            txtIdDeletar.TabIndex = 1;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(417, 147);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 17);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 0;
            label5.Text = "ID a ser Atualizado :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 95);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 1;
            label6.Text = "Aliquota :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 178);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 2;
            label7.Text = "Descrição :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 269);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 3;
            label8.Text = "Status Dispositivo";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(621, 352);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtIdAtualizar
            // 
            txtIdAtualizar.Location = new Point(333, 50);
            txtIdAtualizar.Name = "txtIdAtualizar";
            txtIdAtualizar.Size = new Size(100, 23);
            txtIdAtualizar.TabIndex = 5;
            // 
            // txtAliquotaAtualizar
            // 
            txtAliquotaAtualizar.Location = new Point(323, 127);
            txtAliquotaAtualizar.Name = "txtAliquotaAtualizar";
            txtAliquotaAtualizar.Size = new Size(128, 23);
            txtAliquotaAtualizar.TabIndex = 6;
            // 
            // txtDescricaoAtualizar
            // 
            txtDescricaoAtualizar.Location = new Point(217, 208);
            txtDescricaoAtualizar.Name = "txtDescricaoAtualizar";
            txtDescricaoAtualizar.Size = new Size(343, 23);
            txtDescricaoAtualizar.TabIndex = 7;
            // 
            // txtStatusAtualizar
            // 
            txtStatusAtualizar.Location = new Point(217, 305);
            txtStatusAtualizar.Name = "txtStatusAtualizar";
            txtStatusAtualizar.Size = new Size(343, 23);
            txtStatusAtualizar.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDispositivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnCadastrar;
        private TextBox txtStatus;
        private TextBox txtDescricao;
        private TextBox txtAliquota;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnListar;
        private DataGridView dataGridViewDispositivos;
        private Button btnDeletar;
        private TextBox txtIdDeletar;
        private Label label4;
        private Label label5;
        private TextBox txtStatusAtualizar;
        private TextBox txtDescricaoAtualizar;
        private TextBox txtAliquotaAtualizar;
        private TextBox txtIdAtualizar;
        private Button btnAtualizar;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
