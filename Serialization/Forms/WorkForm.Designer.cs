namespace Serialization.Forms
{
    partial class WorkForm
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
            this.AssembliesTbl = new System.Windows.Forms.DataGridView();
            this.TypesTbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AssembliesTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // AssembliesTbl
            // 
            this.AssembliesTbl.AllowUserToAddRows = false;
            this.AssembliesTbl.AllowUserToDeleteRows = false;
            this.AssembliesTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssembliesTbl.CausesValidation = false;
            this.AssembliesTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssembliesTbl.Location = new System.Drawing.Point(12, 12);
            this.AssembliesTbl.Name = "AssembliesTbl";
            this.AssembliesTbl.ReadOnly = true;
            this.AssembliesTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssembliesTbl.Size = new System.Drawing.Size(240, 426);
            this.AssembliesTbl.TabIndex = 0;
            this.AssembliesTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssembliesTbl_CellClick);
            // 
            // TypesTbl
            // 
            this.TypesTbl.AllowUserToAddRows = false;
            this.TypesTbl.AllowUserToDeleteRows = false;
            this.TypesTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TypesTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypesTbl.Location = new System.Drawing.Point(258, 12);
            this.TypesTbl.Name = "TypesTbl";
            this.TypesTbl.ReadOnly = true;
            this.TypesTbl.Size = new System.Drawing.Size(240, 426);
            this.TypesTbl.TabIndex = 1;
            this.TypesTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TypesTbl_CellClick);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypesTbl);
            this.Controls.Add(this.AssembliesTbl);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.Load += new System.EventHandler(this.WorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssembliesTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssembliesTbl;
        private System.Windows.Forms.DataGridView TypesTbl;
    }
}