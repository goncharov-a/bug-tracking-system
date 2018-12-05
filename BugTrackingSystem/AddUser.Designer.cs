namespace BugTrackingSystem
{
    partial class AddUser
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
            this.btnAddUserOk = new System.Windows.Forms.Button();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.btCancelbtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUserOk
            // 
            this.btnAddUserOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserOk.Location = new System.Drawing.Point(55, 61);
            this.btnAddUserOk.Name = "btnAddUserOk";
            this.btnAddUserOk.Size = new System.Drawing.Size(75, 23);
            this.btnAddUserOk.TabIndex = 5;
            this.btnAddUserOk.Text = "OK";
            this.btnAddUserOk.UseVisualStyleBackColor = true;
            this.btnAddUserOk.Click += new System.EventHandler(this.btnAddUserOk_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(11, 24);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(32, 13);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "User:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Location = new System.Drawing.Point(55, 21);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(211, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // btCancelbtCancel
            // 
            this.btCancelbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelbtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelbtCancel.Location = new System.Drawing.Point(147, 61);
            this.btCancelbtCancel.Name = "btCancelbtCancel";
            this.btCancelbtCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancelbtCancel.TabIndex = 6;
            this.btCancelbtCancel.Text = "Cancel";
            this.btCancelbtCancel.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 108);
            this.Controls.Add(this.btCancelbtCancel);
            this.Controls.Add(this.btnAddUserOk);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.textBoxUser);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUserOk;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button btCancelbtCancel;
    }
}