
namespace max_textbox_size
{
    partial class MainForm
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
            this.textBoxCompose = new System.Windows.Forms.TextBox();
            this.MessageField = new System.Windows.Forms.Panel();
            this.buttonMe = new System.Windows.Forms.Button();
            this.buttonYou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCompose
            // 
            this.textBoxCompose.Location = new System.Drawing.Point(32, 12);
            this.textBoxCompose.Name = "textBoxCompose";
            this.textBoxCompose.PlaceholderText = "What\'s on your mind?";
            this.textBoxCompose.Size = new System.Drawing.Size(519, 31);
            this.textBoxCompose.TabIndex = 1;
            this.textBoxCompose.TabStop = false;
            // 
            // MessageField
            // 
            this.MessageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageField.Location = new System.Drawing.Point(32, 56);
            this.MessageField.Name = "MessageField";
            this.MessageField.Size = new System.Drawing.Size(624, 1165);
            this.MessageField.TabIndex = 6;
            // 
            // buttonMe
            // 
            this.buttonMe.Enabled = false;
            this.buttonMe.Font = new System.Drawing.Font("Arial Narrow", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMe.Location = new System.Drawing.Point(558, 13);
            this.buttonMe.Name = "buttonMe";
            this.buttonMe.Size = new System.Drawing.Size(46, 30);
            this.buttonMe.TabIndex = 7;
            this.buttonMe.Text = "ME";
            this.buttonMe.UseVisualStyleBackColor = true;
            // 
            // buttonYou
            // 
            this.buttonYou.Enabled = false;
            this.buttonYou.Font = new System.Drawing.Font("Arial Narrow", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonYou.Location = new System.Drawing.Point(610, 13);
            this.buttonYou.Name = "buttonYou";
            this.buttonYou.Size = new System.Drawing.Size(46, 30);
            this.buttonYou.TabIndex = 7;
            this.buttonYou.Text = "YOU";
            this.buttonYou.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 1260);
            this.Controls.Add(this.buttonYou);
            this.Controls.Add(this.buttonMe);
            this.Controls.Add(this.MessageField);
            this.Controls.Add(this.textBoxCompose);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCompose;
        private System.Windows.Forms.Panel MessageField;
        private System.Windows.Forms.Button buttonMe;
        private System.Windows.Forms.Button buttonYou;
    }
}

