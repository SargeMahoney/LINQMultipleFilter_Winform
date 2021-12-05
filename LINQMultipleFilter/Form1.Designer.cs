namespace LINQMultipleFilter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numMinAge = new System.Windows.Forms.NumericUpDown();
            this.numMaxAge = new System.Windows.Forms.NumericUpDown();
            this.txtGeneralSearch = new System.Windows.Forms.TextBox();
            this.chkBoxActive = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblGeneralSearch = new System.Windows.Forms.Label();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.lblMinAge = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // numMinAge
            // 
            this.numMinAge.Location = new System.Drawing.Point(858, 98);
            this.numMinAge.Name = "numMinAge";
            this.numMinAge.Size = new System.Drawing.Size(180, 31);
            this.numMinAge.TabIndex = 0;
            // 
            // numMaxAge
            // 
            this.numMaxAge.Location = new System.Drawing.Point(858, 61);
            this.numMaxAge.Name = "numMaxAge";
            this.numMaxAge.Size = new System.Drawing.Size(180, 31);
            this.numMaxAge.TabIndex = 1;
            // 
            // txtGeneralSearch
            // 
            this.txtGeneralSearch.Location = new System.Drawing.Point(858, 12);
            this.txtGeneralSearch.Name = "txtGeneralSearch";
            this.txtGeneralSearch.Size = new System.Drawing.Size(150, 31);
            this.txtGeneralSearch.TabIndex = 2;
            // 
            // chkBoxActive
            // 
            this.chkBoxActive.AutoSize = true;
            this.chkBoxActive.Location = new System.Drawing.Point(858, 153);
            this.chkBoxActive.Name = "chkBoxActive";
            this.chkBoxActive.Size = new System.Drawing.Size(127, 29);
            this.chkBoxActive.TabIndex = 3;
            this.chkBoxActive.Text = "Only Actice";
            this.chkBoxActive.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(858, 201);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 34);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblGeneralSearch
            // 
            this.lblGeneralSearch.AutoSize = true;
            this.lblGeneralSearch.Location = new System.Drawing.Point(720, 15);
            this.lblGeneralSearch.Name = "lblGeneralSearch";
            this.lblGeneralSearch.Size = new System.Drawing.Size(123, 25);
            this.lblGeneralSearch.TabIndex = 5;
            this.lblGeneralSearch.Text = "GeneralSearch";
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.AutoSize = true;
            this.lblMaxAge.Location = new System.Drawing.Point(761, 63);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(82, 25);
            this.lblMaxAge.TabIndex = 6;
            this.lblMaxAge.Text = "Max Age";
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(761, 100);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(79, 25);
            this.lblMinAge.TabIndex = 7;
            this.lblMinAge.Text = "Min Age";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(28, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(28, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 33;
            this.dgvUsers.Size = new System.Drawing.Size(628, 225);
            this.dgvUsers.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 353);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMinAge);
            this.Controls.Add(this.lblMaxAge);
            this.Controls.Add(this.lblGeneralSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.chkBoxActive);
            this.Controls.Add(this.txtGeneralSearch);
            this.Controls.Add(this.numMaxAge);
            this.Controls.Add(this.numMinAge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numMinAge;
        private NumericUpDown numMaxAge;
        private TextBox txtGeneralSearch;
        private CheckBox chkBoxActive;
        private Button btnFilter;
        private Label lblGeneralSearch;
        private Label lblMaxAge;
        private Label lblMinAge;
        private Button btnReset;
        private DataGridView dgvUsers;
    }
}