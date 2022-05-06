
namespace Personal_Diary
{
    partial class Diary
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
            this.contentRichBox = new System.Windows.Forms.RichTextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.tagsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // contentRichBox
            // 
            this.contentRichBox.Location = new System.Drawing.Point(15, 81);
            this.contentRichBox.Name = "contentRichBox";
            this.contentRichBox.Size = new System.Drawing.Size(259, 328);
            this.contentRichBox.TabIndex = 2;
            this.contentRichBox.Text = "";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(53, 9);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(365, 22);
            this.titleTxtBox.TabIndex = 3;
            this.titleTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tagsCheckedListBox
            // 
            this.tagsCheckedListBox.CheckOnClick = true;
            this.tagsCheckedListBox.FormattingEnabled = true;
            this.tagsCheckedListBox.Location = new System.Drawing.Point(289, 81);
            this.tagsCheckedListBox.Name = "tagsCheckedListBox";
            this.tagsCheckedListBox.Size = new System.Drawing.Size(129, 327);
            this.tagsCheckedListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tags";
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tagsCheckedListBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.contentRichBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Diary";
            this.ShowIcon = false;
            this.Text = "Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Diary_FormClosing);
            this.Load += new System.EventHandler(this.Diary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contentRichBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.CheckedListBox tagsCheckedListBox;
        private System.Windows.Forms.Label label3;
    }
}