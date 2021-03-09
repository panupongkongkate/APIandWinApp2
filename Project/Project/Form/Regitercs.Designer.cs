namespace Project
{
    partial class Regitercs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnPeople = new System.Windows.Forms.Button();
            this._btnReg = new System.Windows.Forms.Button();
            this._userConReg1 = new Project._userConReg();
            this.panel3 = new System.Windows.Forms.Panel();
            this._userPeople1 = new Project.usercontorl._userPeople();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this._btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 169);
            this.panel1.TabIndex = 0;
            // 
            // _btnLogOut
            // 
            this._btnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this._btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLogOut.Image = global::Project.Properties.Resources.Logoff;
            this._btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnLogOut.Location = new System.Drawing.Point(1084, 0);
            this._btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnLogOut.Name = "_btnLogOut";
            this._btnLogOut.Size = new System.Drawing.Size(173, 169);
            this._btnLogOut.TabIndex = 0;
            this._btnLogOut.Text = "Log-Out";
            this._btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnLogOut.UseCompatibleTextRendering = true;
            this._btnLogOut.UseVisualStyleBackColor = true;
            this._btnLogOut.Click += new System.EventHandler(this._btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this._btnPeople);
            this.panel2.Controls.Add(this._btnReg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 607);
            this.panel2.TabIndex = 1;
            // 
            // _btnPeople
            // 
            this._btnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnPeople.Location = new System.Drawing.Point(0, 52);
            this._btnPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnPeople.Name = "_btnPeople";
            this._btnPeople.Size = new System.Drawing.Size(267, 57);
            this._btnPeople.TabIndex = 2;
            this._btnPeople.Text = "People";
            this._btnPeople.UseVisualStyleBackColor = true;
            this._btnPeople.Click += new System.EventHandler(this._btnPeople_Click);
            // 
            // _btnReg
            // 
            this._btnReg.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnReg.Location = new System.Drawing.Point(0, 0);
            this._btnReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnReg.Name = "_btnReg";
            this._btnReg.Size = new System.Drawing.Size(267, 52);
            this._btnReg.TabIndex = 2;
            this._btnReg.Text = "Register";
            this._btnReg.UseVisualStyleBackColor = true;
            this._btnReg.Click += new System.EventHandler(this._btnReg_Click);
            // 
            // _userConReg1
            // 
            this._userConReg1.Location = new System.Drawing.Point(331, 13);
            this._userConReg1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this._userConReg1.Name = "_userConReg1";
            this._userConReg1.Size = new System.Drawing.Size(339, 352);
            this._userConReg1.TabIndex = 2;
            this._userConReg1.Load += new System.EventHandler(this._userConReg1_Load);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._userPeople1);
            this.panel3.Controls.Add(this._userConReg1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(267, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 607);
            this.panel3.TabIndex = 2;
            // 
            // _userPeople1
            // 
            this._userPeople1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._userPeople1.Location = new System.Drawing.Point(0, 0);
            this._userPeople1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._userPeople1.Name = "_userPeople1";
            this._userPeople1.Size = new System.Drawing.Size(990, 607);
            this._userPeople1.TabIndex = 3;
            // 
            // Regitercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 776);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regitercs";
            this.Text = "Regitercs";
            this.Load += new System.EventHandler(this.Regitercs_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnPeople;
        private System.Windows.Forms.Button _btnReg;
        private _userConReg _userConReg1;
        private System.Windows.Forms.Panel panel3;
        private usercontorl._userPeople _userPeople1;
    }
}