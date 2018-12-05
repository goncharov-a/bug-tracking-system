namespace BugTrackingSystem
{
    partial class AddTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.comboBoxProjectName = new System.Windows.Forms.ComboBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.textBoxTaskType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTaskPriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.btCancelbtCancel = new System.Windows.Forms.Button();
            this.btnAddTaskOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Project:";
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(134, 6);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(211, 21);
            this.comboBoxUserName.TabIndex = 2;
            // 
            // comboBoxProjectName
            // 
            this.comboBoxProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjectName.FormattingEnabled = true;
            this.comboBoxProjectName.Location = new System.Drawing.Point(134, 33);
            this.comboBoxProjectName.Name = "comboBoxProjectName";
            this.comboBoxProjectName.Size = new System.Drawing.Size(211, 21);
            this.comboBoxProjectName.TabIndex = 3;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(57, 69);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(34, 13);
            this.lbAuthor.TabIndex = 10;
            this.lbAuthor.Text = "Type:";
            // 
            // textBoxTaskType
            // 
            this.textBoxTaskType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaskType.Location = new System.Drawing.Point(134, 67);
            this.textBoxTaskType.Name = "textBoxTaskType";
            this.textBoxTaskType.Size = new System.Drawing.Size(211, 20);
            this.textBoxTaskType.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Priority";
            // 
            // textBoxTaskPriority
            // 
            this.textBoxTaskPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaskPriority.Location = new System.Drawing.Point(134, 105);
            this.textBoxTaskPriority.Name = "textBoxTaskPriority";
            this.textBoxTaskPriority.Size = new System.Drawing.Size(211, 20);
            this.textBoxTaskPriority.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description:";
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaskDescription.Location = new System.Drawing.Point(134, 149);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(211, 111);
            this.textBoxTaskDescription.TabIndex = 13;
            // 
            // btCancelbtCancel
            // 
            this.btCancelbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelbtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelbtCancel.Location = new System.Drawing.Point(270, 277);
            this.btCancelbtCancel.Name = "btCancelbtCancel";
            this.btCancelbtCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancelbtCancel.TabIndex = 16;
            this.btCancelbtCancel.Text = "Cancel";
            this.btCancelbtCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTaskOk
            // 
            this.btnAddTaskOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTaskOk.Location = new System.Drawing.Point(166, 277);
            this.btnAddTaskOk.Name = "btnAddTaskOk";
            this.btnAddTaskOk.Size = new System.Drawing.Size(75, 23);
            this.btnAddTaskOk.TabIndex = 15;
            this.btnAddTaskOk.Text = "OK";
            this.btnAddTaskOk.UseVisualStyleBackColor = true;
            this.btnAddTaskOk.Click += new System.EventHandler(this.btnAddTaskOk_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 324);
            this.Controls.Add(this.btCancelbtCancel);
            this.Controls.Add(this.btnAddTaskOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTaskPriority);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.textBoxTaskType);
            this.Controls.Add(this.comboBoxProjectName);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox textBoxTaskType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTaskPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Button btCancelbtCancel;
        private System.Windows.Forms.Button btnAddTaskOk;
    }
}