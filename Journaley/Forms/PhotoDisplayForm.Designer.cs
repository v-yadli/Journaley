﻿namespace Journaley.Forms
{
    partial class PhotoDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoDisplayForm));
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelFormCaption = new Journaley.Controls.TitleLabel();
            this.panelTitlebar.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.Controls.Add(this.labelFormCaption);
            this.panelTitlebar.Size = new System.Drawing.Size(243, 20);
            this.panelTitlebar.Controls.SetChildIndex(this.labelFormCaption, 0);
            // 
            // panelPhoto
            // 
            this.panelPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPhoto.AutoScroll = true;
            this.panelPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhoto.Controls.Add(this.pictureBox);
            this.panelPhoto.Location = new System.Drawing.Point(0, 20);
            this.panelPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(243, 263);
            this.panelPhoto.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelFormCaption
            // 
            this.labelFormCaption.AutoSize = true;
            this.labelFormCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFormCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelFormCaption.Location = new System.Drawing.Point(3, 3);
            this.labelFormCaption.Name = "labelFormCaption";
            this.labelFormCaption.Size = new System.Drawing.Size(78, 15);
            this.labelFormCaption.TabIndex = 5;
            this.labelFormCaption.Text = "Image Viewer";
            // 
            // PhotoDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 283);
            this.Controls.Add(this.panelPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhotoDisplayForm";
            this.Text = "Image Viewer";
            this.Controls.SetChildIndex(this.panelPhoto, 0);
            this.Controls.SetChildIndex(this.panelTitlebar, 0);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.panelPhoto.ResumeLayout(false);
            this.panelPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.PictureBox pictureBox;
        protected Controls.TitleLabel labelFormCaption;
    }
}