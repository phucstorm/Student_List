namespace ConnectData
{
    partial class FormList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btReload = new System.Windows.Forms.ToolStripMenuItem();
            this.lstStudent = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btEdit,
            this.btDelete,
            this.btReload});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(41, 20);
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(39, 20);
            this.btEdit.Text = "Edit";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(52, 20);
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btReload
            // 
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(55, 20);
            this.btReload.Text = "Reload";
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // lstStudent
            // 
            this.lstStudent.AllowUserToAddRows = false;
            this.lstStudent.AllowUserToDeleteRows = false;
            this.lstStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudent.Location = new System.Drawing.Point(0, 24);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.ReadOnly = true;
            this.lstStudent.Size = new System.Drawing.Size(284, 237);
            this.lstStudent.TabIndex = 1;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormList";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btAdd;
        private System.Windows.Forms.ToolStripMenuItem btEdit;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.ToolStripMenuItem btReload;
        private System.Windows.Forms.DataGridView lstStudent;
    }
}

