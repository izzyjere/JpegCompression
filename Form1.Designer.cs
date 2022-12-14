namespace JpegCompression
{
    partial class Jpeg
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
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.decodedPictureBox = new System.Windows.Forms.PictureBox();
            this.loadBttn = new System.Windows.Forms.Button();
            this.FirstStepsBttn = new System.Windows.Forms.Button();
            this.CuantComboBox = new System.Windows.Forms.ComboBox();
            this.nrTextBox = new System.Windows.Forms.TextBox();
            this.inverseStepsBttn = new System.Windows.Forms.Button();
            this.errorPictureBox = new System.Windows.Forms.PictureBox();
            this.errorBttn = new System.Windows.Forms.Button();
            this.factorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.smallOrigPictureBox = new System.Windows.Forms.PictureBox();
            this.smallDecodePictureBox = new System.Windows.Forms.PictureBox();
            this.clrBttn = new System.Windows.Forms.Button();
            this.dctCheckBox = new System.Windows.Forms.CheckBox();
            this.quantCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decodedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallOrigPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallDecodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.originalPictureBox.Location = new System.Drawing.Point(41, 34);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(256, 256);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OriginalPictureBox_MouseClick);
            // 
            // decodedPictureBox
            // 
            this.decodedPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.decodedPictureBox.Location = new System.Drawing.Point(321, 34);
            this.decodedPictureBox.Name = "decodedPictureBox";
            this.decodedPictureBox.Size = new System.Drawing.Size(256, 256);
            this.decodedPictureBox.TabIndex = 1;
            this.decodedPictureBox.TabStop = false;
            this.decodedPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DecodedPictureBox_MouseClick);
            // 
            // loadBttn
            // 
            this.loadBttn.Location = new System.Drawing.Point(41, 314);
            this.loadBttn.Name = "loadBttn";
            this.loadBttn.Size = new System.Drawing.Size(75, 23);
            this.loadBttn.TabIndex = 2;
            this.loadBttn.Text = "Load Image";
            this.loadBttn.UseVisualStyleBackColor = true;
            this.loadBttn.Click += new System.EventHandler(this.LoadBttn_Click);
            // 
            // FirstStepsBttn
            // 
            this.FirstStepsBttn.Location = new System.Drawing.Point(41, 357);
            this.FirstStepsBttn.Name = "FirstStepsBttn";
            this.FirstStepsBttn.Size = new System.Drawing.Size(75, 23);
            this.FirstStepsBttn.TabIndex = 3;
            this.FirstStepsBttn.Text = "Direct Steps";
            this.FirstStepsBttn.UseVisualStyleBackColor = true;
            this.FirstStepsBttn.Click += new System.EventHandler(this.FirstStepsBttn_Click);
            // 
            // CuantComboBox
            // 
            this.CuantComboBox.FormattingEnabled = true;
            this.CuantComboBox.Items.AddRange(new object[] {
            "ZigZag",
            "matrix simple calculator",
            "jpeg quality factor"});
            this.CuantComboBox.Location = new System.Drawing.Point(176, 357);
            this.CuantComboBox.Name = "CuantComboBox";
            this.CuantComboBox.Size = new System.Drawing.Size(175, 21);
            this.CuantComboBox.TabIndex = 4;
            // 
            // nrTextBox
            // 
            this.nrTextBox.Location = new System.Drawing.Point(176, 317);
            this.nrTextBox.Name = "nrTextBox";
            this.nrTextBox.Size = new System.Drawing.Size(121, 20);
            this.nrTextBox.TabIndex = 5;
            // 
            // inverseStepsBttn
            // 
            this.inverseStepsBttn.Location = new System.Drawing.Point(41, 403);
            this.inverseStepsBttn.Name = "inverseStepsBttn";
            this.inverseStepsBttn.Size = new System.Drawing.Size(75, 23);
            this.inverseStepsBttn.TabIndex = 6;
            this.inverseStepsBttn.Text = "Inverse Step";
            this.inverseStepsBttn.UseVisualStyleBackColor = true;
            this.inverseStepsBttn.Click += new System.EventHandler(this.InverseStepsBttn_Click);
            // 
            // errorPictureBox
            // 
            this.errorPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.errorPictureBox.Location = new System.Drawing.Point(606, 34);
            this.errorPictureBox.Name = "errorPictureBox";
            this.errorPictureBox.Size = new System.Drawing.Size(256, 256);
            this.errorPictureBox.TabIndex = 7;
            this.errorPictureBox.TabStop = false;
            this.errorPictureBox.Click += new System.EventHandler(this.errorPictureBox_Click);
            // 
            // errorBttn
            // 
            this.errorBttn.Location = new System.Drawing.Point(41, 448);
            this.errorBttn.Name = "errorBttn";
            this.errorBttn.Size = new System.Drawing.Size(75, 23);
            this.errorBttn.TabIndex = 8;
            this.errorBttn.Text = "Comp Errors";
            this.errorBttn.UseVisualStyleBackColor = true;
            this.errorBttn.Click += new System.EventHandler(this.ErrorBttn_Click);
            // 
            // factorTextBox
            // 
            this.factorTextBox.Location = new System.Drawing.Point(761, 302);
            this.factorTextBox.Name = "factorTextBox";
            this.factorTextBox.Size = new System.Drawing.Size(100, 20);
            this.factorTextBox.TabIndex = 9;
            this.factorTextBox.Text = "1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contrast Factor";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(867, 34);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(618, 516);
            this.richTextBox.TabIndex = 11;
            this.richTextBox.Text = "";
            // 
            // smallOrigPictureBox
            // 
            this.smallOrigPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.smallOrigPictureBox.Location = new System.Drawing.Point(115, 504);
            this.smallOrigPictureBox.Name = "smallOrigPictureBox";
            this.smallOrigPictureBox.Size = new System.Drawing.Size(64, 64);
            this.smallOrigPictureBox.TabIndex = 12;
            this.smallOrigPictureBox.TabStop = false;
            // 
            // smallDecodePictureBox
            // 
            this.smallDecodePictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.smallDecodePictureBox.Location = new System.Drawing.Point(431, 504);
            this.smallDecodePictureBox.Name = "smallDecodePictureBox";
            this.smallDecodePictureBox.Size = new System.Drawing.Size(64, 64);
            this.smallDecodePictureBox.TabIndex = 13;
            this.smallDecodePictureBox.TabStop = false;
            // 
            // clrBttn
            // 
            this.clrBttn.Location = new System.Drawing.Point(691, 504);
            this.clrBttn.Name = "clrBttn";
            this.clrBttn.Size = new System.Drawing.Size(75, 23);
            this.clrBttn.TabIndex = 14;
            this.clrBttn.Text = "Clear TxtBox";
            this.clrBttn.UseVisualStyleBackColor = true;
            this.clrBttn.Click += new System.EventHandler(this.ClrBttn_Click);
            // 
            // dctCheckBox
            // 
            this.dctCheckBox.AutoSize = true;
            this.dctCheckBox.Location = new System.Drawing.Point(691, 427);
            this.dctCheckBox.Name = "dctCheckBox";
            this.dctCheckBox.Size = new System.Drawing.Size(79, 17);
            this.dctCheckBox.TabIndex = 15;
            this.dctCheckBox.Text = "DCT Matrix";
            this.dctCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantCheckBox
            // 
            this.quantCheckBox.AutoSize = true;
            this.quantCheckBox.Location = new System.Drawing.Point(691, 452);
            this.quantCheckBox.Name = "quantCheckBox";
            this.quantCheckBox.Size = new System.Drawing.Size(116, 17);
            this.quantCheckBox.TabIndex = 16;
            this.quantCheckBox.Text = "Quantization Matrix";
            this.quantCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "8 x 8 Block";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Jpeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantCheckBox);
            this.Controls.Add(this.dctCheckBox);
            this.Controls.Add(this.clrBttn);
            this.Controls.Add(this.smallDecodePictureBox);
            this.Controls.Add(this.smallOrigPictureBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.factorTextBox);
            this.Controls.Add(this.errorBttn);
            this.Controls.Add(this.errorPictureBox);
            this.Controls.Add(this.inverseStepsBttn);
            this.Controls.Add(this.nrTextBox);
            this.Controls.Add(this.CuantComboBox);
            this.Controls.Add(this.FirstStepsBttn);
            this.Controls.Add(this.loadBttn);
            this.Controls.Add(this.decodedPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Name = "Jpeg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageCompression Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decodedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallOrigPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallDecodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox decodedPictureBox;
        private System.Windows.Forms.Button loadBttn;
        private System.Windows.Forms.Button FirstStepsBttn;
        private System.Windows.Forms.ComboBox CuantComboBox;
        private System.Windows.Forms.TextBox nrTextBox;
        private System.Windows.Forms.Button inverseStepsBttn;
        private System.Windows.Forms.PictureBox errorPictureBox;
        private System.Windows.Forms.Button errorBttn;
        private System.Windows.Forms.TextBox factorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox smallOrigPictureBox;
        private System.Windows.Forms.PictureBox smallDecodePictureBox;
        private System.Windows.Forms.Button clrBttn;
        private System.Windows.Forms.CheckBox dctCheckBox;
        private System.Windows.Forms.CheckBox quantCheckBox;
        private System.Windows.Forms.Label label2;
    }
}

