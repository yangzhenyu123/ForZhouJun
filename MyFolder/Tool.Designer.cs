namespace MyFolder
{
    partial class Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.btn_ChooseFolder = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChooseFolder
            // 
            this.btn_ChooseFolder.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ChooseFolder.Location = new System.Drawing.Point(254, 22);
            this.btn_ChooseFolder.Name = "btn_ChooseFolder";
            this.btn_ChooseFolder.Size = new System.Drawing.Size(116, 38);
            this.btn_ChooseFolder.TabIndex = 0;
            this.btn_ChooseFolder.Text = "选择根文件夹";
            this.btn_ChooseFolder.UseVisualStyleBackColor = true;
            this.btn_ChooseFolder.Click += new System.EventHandler(this.btn_ChooseFolder_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Filter.Location = new System.Drawing.Point(26, 85);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(116, 48);
            this.btn_Filter.TabIndex = 1;
            this.btn_Filter.Text = "筛选空文件夹";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Delete.Location = new System.Drawing.Point(148, 85);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 48);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除空文件夹";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(26, 33);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(222, 21);
            this.txt_path.TabIndex = 3;
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DeleteAll.Location = new System.Drawing.Point(270, 85);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(131, 48);
            this.btn_DeleteAll.TabIndex = 4;
            this.btn_DeleteAll.Text = "递归删除空文件夹";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 167);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_ChooseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tool";
            this.Text = "Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChooseFolder;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_DeleteAll;

    }
}