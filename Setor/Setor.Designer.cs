namespace Setor
{
    partial class Setor
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
            dataGrind = new DataGridView();
            lblNomeSetor = new Label();
            lblid = new Label();
            txtNomeSetor = new TextBox();
            btnGravar = new Button();
            lblNome = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListarTodos = new Button();
            btnListarPnome = new Button();
            btnCancelar = new Button();
            lblTitle = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrind).BeginInit();
            SuspendLayout();
            // 
            // dataGrind
            // 
            dataGrind.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrind.Location = new Point(37, 390);
            dataGrind.Name = "dataGrind";
            dataGrind.RowHeadersWidth = 62;
            dataGrind.Size = new Size(833, 254);
            dataGrind.TabIndex = 0;
            dataGrind.CellContentClick += dataGrind_CellContentClick;
            dataGrind.CellDoubleClick += DataGrind_CellDoubleClick;
            // 
            // lblNomeSetor
            // 
            lblNomeSetor.AutoSize = true;
            lblNomeSetor.Font = new Font("Segoe UI", 12F);
            lblNomeSetor.Location = new Point(30, 221);
            lblNomeSetor.Name = "lblNomeSetor";
            lblNomeSetor.Size = new Size(174, 21);
            lblNomeSetor.TabIndex = 1;
            lblNomeSetor.Text = "Digite o nome do Setor:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F);
            lblid.Location = new Point(34, 299);
            lblid.Name = "lblid";
            lblid.Size = new Size(28, 21);
            lblid.TabIndex = 2;
            lblid.Text = "ID:";
            // 
            // txtNomeSetor
            // 
            txtNomeSetor.Location = new Point(33, 261);
            txtNomeSetor.Name = "txtNomeSetor";
            txtNomeSetor.Size = new Size(442, 26);
            txtNomeSetor.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(738, 83);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(132, 49);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(36, 90);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(34, 332);
            txtID.Name = "txtID";
            txtID.Size = new Size(165, 26);
            txtID.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(134, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(542, 26);
            txtNome.TabIndex = 7;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(738, 154);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(132, 49);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(738, 221);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(132, 49);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListarTodos
            // 
            btnListarTodos.Location = new Point(37, 660);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(659, 49);
            btnListarTodos.TabIndex = 10;
            btnListarTodos.Text = "Listar todos";
            btnListarTodos.UseVisualStyleBackColor = true;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // btnListarPnome
            // 
            btnListarPnome.Location = new Point(493, 250);
            btnListarPnome.Name = "btnListarPnome";
            btnListarPnome.Size = new Size(132, 49);
            btnListarPnome.TabIndex = 11;
            btnListarPnome.Text = "Procurar";
            btnListarPnome.UseVisualStyleBackColor = true;
            btnListarPnome.Click += btnListarPnome_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(723, 660);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 49);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 180);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 23);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Editar setor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 42);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 15;
            label2.Text = "Inserir setor";
            // 
            // Setor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 731);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(btnCancelar);
            Controls.Add(btnListarPnome);
            Controls.Add(btnListarTodos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lblNome);
            Controls.Add(btnGravar);
            Controls.Add(txtNomeSetor);
            Controls.Add(lblid);
            Controls.Add(lblNomeSetor);
            Controls.Add(dataGrind);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Setor";
            Text = "Gerenciamento de Setores";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrind).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrind;
        private Label lblNomeSetor;
        private Label lblid;
        private TextBox txtNomeSetor;
        private Button btnGravar;
        private Label lblNome;
        private TextBox txtID;
        private TextBox txtNome;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListarTodos;
        private Button btnListarPnome;
        private Button btnCancelar;
        private Label lblTitle;
        private Label label2;
    }
}
