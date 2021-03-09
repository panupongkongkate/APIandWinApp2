namespace Project.usercontorl
{
    partial class _userPeople
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgv
            // 
            this._dgv.AllowUserToAddRows = false;
            this._dgv.AllowUserToDeleteRows = false;
            this._dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgv.Location = new System.Drawing.Point(0, 0);
            this._dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._dgv.Name = "_dgv";
            this._dgv.ReadOnly = true;
            this._dgv.RowHeadersWidth = 62;
            this._dgv.Size = new System.Drawing.Size(780, 478);
            this._dgv.TabIndex = 0;
            this._dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv_CellContentClick);
            // 
            // _userPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_userPeople";
            this.Size = new System.Drawing.Size(780, 478);
            this.Load += new System.EventHandler(this._userPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgv;
    }
}
