namespace photobooth
{
    partial class Form1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.load1 = new System.Windows.Forms.Button();
			this.load2 = new System.Windows.Forms.Button();
			this.load3 = new System.Windows.Forms.Button();
			this.renderBtn = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.streamBtn = new System.Windows.Forms.Button();
			this.streamCam = new System.Windows.Forms.PictureBox();
			this.framBtn = new System.Windows.Forms.Button();
			this.frameBox = new System.Windows.Forms.PictureBox();
			this.activeCamList = new System.Windows.Forms.ComboBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.printBtn = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.projectBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.streamCam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(252, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 150);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(252, 215);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 150);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new System.Drawing.Point(252, 371);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 150);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// load1
			// 
			this.load1.Location = new System.Drawing.Point(472, 118);
			this.load1.Name = "load1";
			this.load1.Size = new System.Drawing.Size(75, 23);
			this.load1.TabIndex = 3;
			this.load1.Text = "capture #1";
			this.load1.UseVisualStyleBackColor = true;
			this.load1.Click += new System.EventHandler(this.load1_Click);
			// 
			// load2
			// 
			this.load2.Location = new System.Drawing.Point(472, 276);
			this.load2.Name = "load2";
			this.load2.Size = new System.Drawing.Size(75, 23);
			this.load2.TabIndex = 4;
			this.load2.Text = "capture #2";
			this.load2.UseVisualStyleBackColor = true;
			this.load2.Click += new System.EventHandler(this.load2_Click);
			// 
			// load3
			// 
			this.load3.Location = new System.Drawing.Point(472, 436);
			this.load3.Name = "load3";
			this.load3.Size = new System.Drawing.Size(75, 23);
			this.load3.TabIndex = 5;
			this.load3.Text = "capture #3";
			this.load3.UseVisualStyleBackColor = true;
			this.load3.Click += new System.EventHandler(this.load3_Click);
			// 
			// renderBtn
			// 
			this.renderBtn.Location = new System.Drawing.Point(579, 208);
			this.renderBtn.Name = "renderBtn";
			this.renderBtn.Size = new System.Drawing.Size(59, 159);
			this.renderBtn.TabIndex = 6;
			this.renderBtn.Text = "render";
			this.renderBtn.UseVisualStyleBackColor = true;
			this.renderBtn.Click += new System.EventHandler(this.renderBtn_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.Location = new System.Drawing.Point(664, 59);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(331, 462);
			this.pictureBox4.TabIndex = 7;
			this.pictureBox4.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// streamBtn
			// 
			this.streamBtn.Location = new System.Drawing.Point(24, 28);
			this.streamBtn.Name = "streamBtn";
			this.streamBtn.Size = new System.Drawing.Size(75, 23);
			this.streamBtn.TabIndex = 8;
			this.streamBtn.Text = "open cam";
			this.streamBtn.UseVisualStyleBackColor = true;
			this.streamBtn.Click += new System.EventHandler(this.streamBtn_Click);
			// 
			// streamCam
			// 
			this.streamCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.streamCam.Location = new System.Drawing.Point(24, 59);
			this.streamCam.Name = "streamCam";
			this.streamCam.Size = new System.Drawing.Size(202, 150);
			this.streamCam.TabIndex = 9;
			this.streamCam.TabStop = false;
			// 
			// framBtn
			// 
			this.framBtn.Location = new System.Drawing.Point(24, 229);
			this.framBtn.Name = "framBtn";
			this.framBtn.Size = new System.Drawing.Size(75, 23);
			this.framBtn.TabIndex = 10;
			this.framBtn.Text = "load frame";
			this.framBtn.UseVisualStyleBackColor = true;
			this.framBtn.Click += new System.EventHandler(this.framBtn_Click);
			// 
			// frameBox
			// 
			this.frameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.frameBox.Location = new System.Drawing.Point(24, 258);
			this.frameBox.Name = "frameBox";
			this.frameBox.Size = new System.Drawing.Size(202, 263);
			this.frameBox.TabIndex = 11;
			this.frameBox.TabStop = false;
			// 
			// activeCamList
			// 
			this.activeCamList.FormattingEnabled = true;
			this.activeCamList.Location = new System.Drawing.Point(105, 30);
			this.activeCamList.Name = "activeCamList";
			this.activeCamList.Size = new System.Drawing.Size(121, 21);
			this.activeCamList.TabIndex = 12;
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(664, 540);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(138, 45);
			this.saveBtn.TabIndex = 13;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// printBtn
			// 
			this.printBtn.Location = new System.Drawing.Point(808, 540);
			this.printBtn.Name = "printBtn";
			this.printBtn.Size = new System.Drawing.Size(187, 45);
			this.printBtn.TabIndex = 14;
			this.printBtn.Text = "Print";
			this.printBtn.UseVisualStyleBackColor = true;
			this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
			// 
			// projectBox
			// 
			this.projectBox.Location = new System.Drawing.Point(327, 30);
			this.projectBox.Name = "projectBox";
			this.projectBox.Size = new System.Drawing.Size(125, 20);
			this.projectBox.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(249, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Project name:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1021, 611);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.projectBox);
			this.Controls.Add(this.printBtn);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.activeCamList);
			this.Controls.Add(this.frameBox);
			this.Controls.Add(this.framBtn);
			this.Controls.Add(this.streamCam);
			this.Controls.Add(this.streamBtn);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.renderBtn);
			this.Controls.Add(this.load3);
			this.Controls.Add(this.load2);
			this.Controls.Add(this.load1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.streamCam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button load1;
        private System.Windows.Forms.Button load2;
        private System.Windows.Forms.Button load3;
        private System.Windows.Forms.Button renderBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button streamBtn;
        private System.Windows.Forms.PictureBox streamCam;
        private System.Windows.Forms.Button framBtn;
        private System.Windows.Forms.PictureBox frameBox;
		private System.Windows.Forms.ComboBox activeCamList;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button printBtn;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox projectBox;
		private System.Windows.Forms.Label label1;
	}
}

