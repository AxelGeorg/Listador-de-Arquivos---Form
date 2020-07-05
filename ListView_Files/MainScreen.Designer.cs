namespace ListView_Files
{
    partial class MainScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_files = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_files
            // 
            this.listView_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_files.FullRowSelect = true;
            this.listView_files.GridLines = true;
            this.listView_files.HideSelection = false;
            this.listView_files.Location = new System.Drawing.Point(24, 28);
            this.listView_files.Name = "listView_files";
            this.listView_files.Size = new System.Drawing.Size(594, 262);
            this.listView_files.TabIndex = 4;
            this.listView_files.UseCompatibleStateImageBehavior = false;
            this.listView_files.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File ID";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Name";
            this.columnHeader2.Width = 198;
            // 
            // btn_remove
            // 
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.Location = new System.Drawing.Point(354, 322);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(136, 29);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "Remover Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_open
            // 
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.Location = new System.Drawing.Point(154, 322);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(136, 29);
            this.btn_open.TabIndex = 7;
            this.btn_open.Text = "Selecionar Arquivos";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Directory";
            this.columnHeader3.Width = 198;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 376);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.listView_files);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca detalhes de arquivos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_files;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

