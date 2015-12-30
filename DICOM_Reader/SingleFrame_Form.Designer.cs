namespace DICOM_Reader
{
    partial class SingleFrame_Form
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar_SingleFrame_Width = new System.Windows.Forms.TrackBar();
            this.trackBar_SingleFrame_Center = new System.Windows.Forms.TrackBar();
            this.pictureBox_SingleFrame = new System.Windows.Forms.PictureBox();
            this.dataGridView_SingleFrame = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SingleFrame_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SingleFrame_Center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SingleFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SingleFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_SingleFrame, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(699, 453);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.trackBar_SingleFrame_Width, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.trackBar_SingleFrame_Center, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox_SingleFrame, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(352, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(344, 447);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // trackBar_SingleFrame_Width
            // 
            this.trackBar_SingleFrame_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_SingleFrame_Width.Location = new System.Drawing.Point(3, 360);
            this.trackBar_SingleFrame_Width.Name = "trackBar_SingleFrame_Width";
            this.trackBar_SingleFrame_Width.Size = new System.Drawing.Size(338, 38);
            this.trackBar_SingleFrame_Width.TabIndex = 0;
            this.trackBar_SingleFrame_Width.Tag = "Width";
            this.trackBar_SingleFrame_Width.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_SingleFrame_Width.ValueChanged += new System.EventHandler(this.trackBar_SingleFrame_Width_ValueChanged);
            // 
            // trackBar_SingleFrame_Center
            // 
            this.trackBar_SingleFrame_Center.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_SingleFrame_Center.Location = new System.Drawing.Point(3, 404);
            this.trackBar_SingleFrame_Center.Name = "trackBar_SingleFrame_Center";
            this.trackBar_SingleFrame_Center.Size = new System.Drawing.Size(338, 40);
            this.trackBar_SingleFrame_Center.TabIndex = 1;
            this.trackBar_SingleFrame_Center.Tag = "Center";
            this.trackBar_SingleFrame_Center.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_SingleFrame_Center.ValueChanged += new System.EventHandler(this.trackBar_SingleFrame_Center_ValueChanged);
            // 
            // pictureBox_SingleFrame
            // 
            this.pictureBox_SingleFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_SingleFrame.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_SingleFrame.Name = "pictureBox_SingleFrame";
            this.pictureBox_SingleFrame.Size = new System.Drawing.Size(338, 351);
            this.pictureBox_SingleFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_SingleFrame.TabIndex = 2;
            this.pictureBox_SingleFrame.TabStop = false;
            // 
            // dataGridView_SingleFrame
            // 
            this.dataGridView_SingleFrame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_SingleFrame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SingleFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_SingleFrame.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_SingleFrame.Name = "dataGridView_SingleFrame";
            this.dataGridView_SingleFrame.RowHeadersVisible = false;
            this.dataGridView_SingleFrame.Size = new System.Drawing.Size(343, 447);
            this.dataGridView_SingleFrame.TabIndex = 1;
            // 
            // SingleFrame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "SingleFrame_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DICOM Reader - Single Frame";
            this.Load += new System.EventHandler(this.SingleFrame_Form_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SingleFrame_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SingleFrame_Center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SingleFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SingleFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar trackBar_SingleFrame_Width;
        private System.Windows.Forms.TrackBar trackBar_SingleFrame_Center;
        private System.Windows.Forms.PictureBox pictureBox_SingleFrame;
        private System.Windows.Forms.DataGridView dataGridView_SingleFrame;


    }
}