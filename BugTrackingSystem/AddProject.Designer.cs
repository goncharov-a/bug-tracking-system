namespace BugTrackingSystem
{
    partial class AddProject
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
            this.btCancelbtCancel = new System.Windows.Forms.Button();
            this.btnAddProjectOk = new System.Windows.Forms.Button();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProjectDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancelbtCancel
            // 
            this.btCancelbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelbtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelbtCancel.Location = new System.Drawing.Point(193, 180);
            this.btCancelbtCancel.Name = "btCancelbtCancel";
            this.btCancelbtCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancelbtCancel.TabIndex = 10;
            this.btCancelbtCancel.Text = "Cancel";
            this.btCancelbtCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddProjectOk
            // 
            this.btnAddProjectOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProjectOk.Location = new System.Drawing.Point(101, 180);
            this.btnAddProjectOk.Name = "btnAddProjectOk";
            this.btnAddProjectOk.Size = new System.Drawing.Size(75, 23);
            this.btnAddProjectOk.TabIndex = 9;
            this.btnAddProjectOk.Text = "OK";
            this.btnAddProjectOk.UseVisualStyleBackColor = true;
            this.btnAddProjectOk.Click += new System.EventHandler(this.btnAddProjectOk_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(31, 15);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(43, 13);
            this.lbAuthor.TabIndex = 8;
            this.lbAuthor.Text = "Project:";
            // 
            // textBoxProject
            // 
            this.textBoxProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProject.Location = new System.Drawing.Point(100, 13);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(211, 20);
            this.textBoxProject.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Description:";
            // 
            // textBoxProjectDescription
            // 
            this.textBoxProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProjectDescription.Location = new System.Drawing.Point(98, 52);
            this.textBoxProjectDescription.Multiline = true;
            this.textBoxProjectDescription.Name = "textBoxProjectDescription";
            this.textBoxProjectDescription.Size = new System.Drawing.Size(211, 111);
            this.textBoxProjectDescription.TabIndex = 11;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProjectDescription);
            this.Controls.Add(this.btCancelbtCancel);
            this.Controls.Add(this.btnAddProjectOk);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.textBoxProject);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelbtCancel;
        private System.Windows.Forms.Button btnAddProjectOk;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProjectDescription;
    }
}