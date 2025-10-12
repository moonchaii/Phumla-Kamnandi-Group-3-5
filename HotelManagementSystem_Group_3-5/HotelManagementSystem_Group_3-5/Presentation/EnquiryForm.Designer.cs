namespace HotelManagementSystem_Group_3_5.Presentation
{
    partial class EnquiryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelReference = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxReferenceSpace = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 52);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(225, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enquiries";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(148, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(709, 340);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(166, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelReference.Location = new System.Drawing.Point(163, 191);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(121, 17);
            this.labelReference.TabIndex = 5;
            this.labelReference.Text = "Reference Number:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearch.Location = new System.Drawing.Point(525, 184);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(101, 28);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxReferenceSpace
            // 
            this.textBoxReferenceSpace.Location = new System.Drawing.Point(290, 192);
            this.textBoxReferenceSpace.Name = "textBoxReferenceSpace";
            this.textBoxReferenceSpace.Size = new System.Drawing.Size(169, 20);
            this.textBoxReferenceSpace.TabIndex = 7;
            // 
            // EnquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 551);
            this.Controls.Add(this.textBoxReferenceSpace);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelReference);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EnquiryForm";
            this.Text = "Enquiry";
            this.Load += new System.EventHandler(this.EnquiryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxReferenceSpace;
    }
}