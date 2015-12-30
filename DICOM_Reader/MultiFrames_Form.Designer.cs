namespace DICOM_Reader
{
    partial class MultiFrames_Form
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
            this.tableLayoutPanel_MultiFrames_Form = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_MultiFrames_Image = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar_MultiFrames_FrameToDisplay = new System.Windows.Forms.TrackBar();
            this.trackBar_MultiFrames_Width = new System.Windows.Forms.TrackBar();
            this.trackBar_MultiFrames_Center = new System.Windows.Forms.TrackBar();
            this.pictureBox_MultiFrames = new System.Windows.Forms.PictureBox();
            this.dataGridView_MultiFrames = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_MultiFrames_Form.SuspendLayout();
            this.tableLayoutPanel_MultiFrames_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MultiFrames_FrameToDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MultiFrames_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MultiFrames_Center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MultiFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MultiFrames)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_MultiFrames_Form
            // 
            this.tableLayoutPanel_MultiFrames_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_MultiFrames_Form.ColumnCount = 2;
            this.tableLayoutPanel_MultiFrames_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MultiFrames_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MultiFrames_Form.Controls.Add(this.tableLayoutPanel_MultiFrames_Image, 1, 0);
            this.tableLayoutPanel_MultiFrames_Form.Controls.Add(this.dataGridView_MultiFrames, 0, 0);
            this.tableLayoutPanel_MultiFrames_Form.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel_MultiFrames_Form.Name = "tableLayoutPanel_MultiFrames_Form";
            this.tableLayoutPanel_MultiFrames_Form.RowCount = 1;
            this.tableLayoutPanel_MultiFrames_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MultiFrames_Form.Size = new System.Drawing.Size(699, 454);
            this.tableLayoutPanel_MultiFrames_Form.TabIndex = 1;
            // 
            // tableLayoutPanel_MultiFrames_Image
            // 
            this.tableLayoutPanel_MultiFrames_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_MultiFrames_Image.ColumnCount = 1;
            this.tableLayoutPanel_MultiFrames_Image.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MultiFrames_Image.Controls.Add(this.trackBar_MultiFrames_FrameToDisplay, 0, 1);
            this.tableLayoutPanel_MultiFrames_Image.Controls.Add(this.trackBar_MultiFrames_Width, 0, 2);
            this.tableLayoutPanel_MultiFrames_Image.Controls.Add(this.trackBar_MultiFrames_Center, 0, 3);
            this.tableLayoutPanel_MultiFrames_Image.Controls.Add(this.pictureBox_MultiFrames, 0, 0);
            this.tableLayoutPanel_MultiFrames_Image.Location = new System.Drawing.Point(352, 3);
            this.tableLayoutPanel_MultiFrames_Image.Name = "tableLayoutPanel_MultiFrames_Image";
            this.tableLayoutPanel_MultiFrames_Image.RowCount = 4;
            this.tableLayoutPanel_MultiFrames_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79F));
            this.tableLayoutPanel_MultiFrames_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel_MultiFrames_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel_MultiFrames_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel_MultiFrames_Image.Size = new System.Drawing.Size(344, 448);
            this.tableLayoutPanel_MultiFrames_Image.TabIndex = 0;
            // 
            // trackBar_MultiFrames_FrameToDisplay
            // 
            this.trackBar_MultiFrames_FrameToDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_MultiFrames_FrameToDisplay.Location = new System.Drawing.Point(3, 356);
            this.trackBar_MultiFrames_FrameToDisplay.Name = "trackBar_MultiFrames_FrameToDisplay";
            this.trackBar_MultiFrames_FrameToDisplay.Size = new System.Drawing.Size(338, 25);
            this.trackBar_MultiFrames_FrameToDisplay.TabIndex = 0;
            this.trackBar_MultiFrames_FrameToDisplay.ValueChanged += new System.EventHandler(this.trackBar_MultiFrames_FrameToDisplay_ValueChanged);
            // 
            // trackBar_MultiFrames_Width
            // 
            this.trackBar_MultiFrames_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_MultiFrames_Width.Location = new System.Drawing.Point(3, 387);
            this.trackBar_MultiFrames_Width.Name = "trackBar_MultiFrames_Width";
            this.trackBar_MultiFrames_Width.Size = new System.Drawing.Size(338, 25);
            this.trackBar_MultiFrames_Width.TabIndex = 1;
            this.trackBar_MultiFrames_Width.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_MultiFrames_Width.ValueChanged += new System.EventHandler(this.trackBar_MultiFrames_Width_ValueChanged);
            // 
            // trackBar_MultiFrames_Center
            // 
            this.trackBar_MultiFrames_Center.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_MultiFrames_Center.Location = new System.Drawing.Point(3, 418);
            this.trackBar_MultiFrames_Center.Name = "trackBar_MultiFrames_Center";
            this.trackBar_MultiFrames_Center.Size = new System.Drawing.Size(338, 27);
            this.trackBar_MultiFrames_Center.TabIndex = 2;
            this.trackBar_MultiFrames_Center.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_MultiFrames_Center.ValueChanged += new System.EventHandler(this.trackBar_MultiFrames_Center_ValueChanged);
            // 
            // pictureBox_MultiFrames
            // 
            this.pictureBox_MultiFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_MultiFrames.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_MultiFrames.Name = "pictureBox_MultiFrames";
            this.pictureBox_MultiFrames.Size = new System.Drawing.Size(338, 347);
            this.pictureBox_MultiFrames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_MultiFrames.TabIndex = 3;
            this.pictureBox_MultiFrames.TabStop = false;
            // 
            // dataGridView_MultiFrames
            // 
            this.dataGridView_MultiFrames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_MultiFrames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MultiFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MultiFrames.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_MultiFrames.Name = "dataGridView_MultiFrames";
            this.dataGridView_MultiFrames.RowHeadersVisible = false;
            this.dataGridView_MultiFrames.Size = new System.Drawing.Size(343, 448);
            this.dataGridView_MultiFrames.TabIndex = 1;
            // 
            // MultiFrames_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.tableLayoutPanel_MultiFrames_Form);
            this.Name = "MultiFrames_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DICOM Reader - Multi Frames";
            this.Load += new System.EventHandler(this.MultiFrames_Form_Load);
            this.tableLayoutPanel_MultiFrames_Form.ResumeLayout(false);
            this.tableLayoutPanel_MultiFrames_Image.ResumeLayout(false);
            this.tableLayoutPanel_MultiFrames_Image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MultiFrames_FrameToDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MultiFrames_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MultiFrames_Center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MultiFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MultiFrames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MultiFrames_Form;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MultiFrames_Image;
        private System.Windows.Forms.TrackBar trackBar_MultiFrames_FrameToDisplay;
        private System.Windows.Forms.TrackBar trackBar_MultiFrames_Width;
        private System.Windows.Forms.TrackBar trackBar_MultiFrames_Center;
        private System.Windows.Forms.PictureBox pictureBox_MultiFrames;
        private System.Windows.Forms.DataGridView dataGridView_MultiFrames;


    }
}