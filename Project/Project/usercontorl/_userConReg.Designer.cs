namespace Project
{
    partial class _userConReg
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnSummit = new System.Windows.Forms.Button();
            this._btnClear = new System.Windows.Forms.Button();
            this._txtLastName = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "id";
            // 
            // _btnSummit
            // 
            this._btnSummit.Location = new System.Drawing.Point(178, 222);
            this._btnSummit.Name = "_btnSummit";
            this._btnSummit.Size = new System.Drawing.Size(110, 49);
            this._btnSummit.TabIndex = 12;
            this._btnSummit.Text = "Submit";
            this._btnSummit.UseVisualStyleBackColor = true;
            this._btnSummit.Click += new System.EventHandler(this._btnSummit_Click);
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(96, 222);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(76, 49);
            this._btnClear.TabIndex = 11;
            this._btnClear.Text = "Clear";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _txtLastName
            // 
            this._txtLastName.Location = new System.Drawing.Point(164, 163);
            this._txtLastName.Name = "_txtLastName";
            this._txtLastName.Size = new System.Drawing.Size(100, 26);
            this._txtLastName.TabIndex = 10;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(164, 115);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 26);
            this._txtName.TabIndex = 9;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(164, 63);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 26);
            this._txtId.TabIndex = 8;
            this._txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtId_KeyPress);
            // 
            // _userConReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnSummit);
            this.Controls.Add(this._btnClear);
            this.Controls.Add(this._txtLastName);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._txtId);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_userConReg";
            this.Size = new System.Drawing.Size(390, 320);
            this.Load += new System.EventHandler(this._userConReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnSummit;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.TextBox _txtLastName;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtId;
    }
}
