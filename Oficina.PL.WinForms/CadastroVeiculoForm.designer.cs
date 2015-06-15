namespace Oficina.PL.WinForms
{
    partial class CadastroVeiculoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.inserirButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.pesquisarTextBox = new System.Windows.Forms.TextBox();
            this.clientesListBox = new System.Windows.Forms.ListBox();
            this.veiculosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Cor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "A&no:";
            // 
            // placaTextBox
            // 
            this.placaTextBox.AccessibleName = "Placa";
            this.placaTextBox.Location = new System.Drawing.Point(266, 36);
            this.placaTextBox.MaxLength = 7;
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(100, 20);
            this.placaTextBox.TabIndex = 4;
            this.placaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(266, 62);
            this.modeloTextBox.MaxLength = 30;
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(367, 20);
            this.modeloTextBox.TabIndex = 6;
            // 
            // corTextBox
            // 
            this.corTextBox.Location = new System.Drawing.Point(266, 88);
            this.corTextBox.MaxLength = 30;
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(367, 20);
            this.corTextBox.TabIndex = 8;
            // 
            // anoTextBox
            // 
            this.anoTextBox.Location = new System.Drawing.Point(266, 114);
            this.anoTextBox.MaxLength = 4;
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anoTextBox.TabIndex = 10;
            this.anoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inserirButton
            // 
            this.inserirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirButton.Location = new System.Drawing.Point(209, 156);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(75, 23);
            this.inserirButton.TabIndex = 11;
            this.inserirButton.Text = "&Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarButton.Location = new System.Drawing.Point(290, 156);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(75, 23);
            this.atualizarButton.TabIndex = 12;
            this.atualizarButton.Text = "&Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.Location = new System.Drawing.Point(371, 156);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 13;
            this.excluirButton.Text = "&Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarButton.Location = new System.Drawing.Point(452, 156);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(75, 23);
            this.pesquisarButton.TabIndex = 14;
            this.pesquisarButton.Text = "&Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisarButton_Click);
            // 
            // pesquisarTextBox
            // 
            this.pesquisarTextBox.Location = new System.Drawing.Point(533, 158);
            this.pesquisarTextBox.MaxLength = 7;
            this.pesquisarTextBox.Name = "pesquisarTextBox";
            this.pesquisarTextBox.Size = new System.Drawing.Size(100, 20);
            this.pesquisarTextBox.TabIndex = 0;
            this.pesquisarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clientesListBox
            // 
            this.clientesListBox.FormattingEnabled = true;
            this.clientesListBox.Location = new System.Drawing.Point(12, 36);
            this.clientesListBox.Name = "clientesListBox";
            this.clientesListBox.Size = new System.Drawing.Size(191, 147);
            this.clientesListBox.TabIndex = 2;
            // 
            // veiculosDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.veiculosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.veiculosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.veiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veiculosDataGridView.Location = new System.Drawing.Point(12, 190);
            this.veiculosDataGridView.MultiSelect = false;
            this.veiculosDataGridView.Name = "veiculosDataGridView";
            this.veiculosDataGridView.ReadOnly = true;
            this.veiculosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veiculosDataGridView.Size = new System.Drawing.Size(619, 261);
            this.veiculosDataGridView.TabIndex = 15;
            this.veiculosDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.veiculosDataGridView_RowEnter);
            // 
            // CadastroVeiculoForm
            // 
            this.AcceptButton = this.pesquisarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 463);
            this.Controls.Add(this.veiculosDataGridView);
            this.Controls.Add(this.clientesListBox);
            this.Controls.Add(this.pesquisarTextBox);
            this.Controls.Add(this.pesquisarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.placaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CadastroVeiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.cadastroVeiculoForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cadastroVeiculoForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.veiculosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.TextBox pesquisarTextBox;
        private System.Windows.Forms.ListBox clientesListBox;
        private System.Windows.Forms.DataGridView veiculosDataGridView;
    }
}

