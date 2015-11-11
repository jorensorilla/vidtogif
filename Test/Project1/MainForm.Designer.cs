/*
 * Created by SharpDevelop.
 * User: juan.l.d.sorilla
 * Date: 10/12/2015
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtTRPath;
		private System.Windows.Forms.Button btnTRPath;
		private System.Windows.Forms.TextBox txtBMPath;
		private System.Windows.Forms.Label lblTRPath;
		private System.Windows.Forms.Label lblBMPath;
		private System.Windows.Forms.Button btnBMPath;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button btnStart;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTRPath = new System.Windows.Forms.Button();
			this.txtBMPath = new System.Windows.Forms.TextBox();
			this.lblTRPath = new System.Windows.Forms.Label();
			this.lblBMPath = new System.Windows.Forms.Label();
			this.btnBMPath = new System.Windows.Forms.Button();
			this.txtTRPath = new System.Windows.Forms.TextBox();
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnTRPath
			// 
			this.btnTRPath.Location = new System.Drawing.Point(301, 12);
			this.btnTRPath.Name = "btnTRPath";
			this.btnTRPath.Size = new System.Drawing.Size(75, 20);
			this.btnTRPath.TabIndex = 1;
			this.btnTRPath.Text = "Browse";
			this.btnTRPath.UseVisualStyleBackColor = true;
			this.btnTRPath.Click += new System.EventHandler(this.btnTRPath_Click);
			// 
			// txtBMPath
			// 
			this.txtBMPath.Location = new System.Drawing.Point(73, 40);
			this.txtBMPath.Name = "txtBMPath";
			this.txtBMPath.Size = new System.Drawing.Size(221, 20);
			this.txtBMPath.TabIndex = 2;
			// 
			// lblTRPath
			// 
			this.lblTRPath.Location = new System.Drawing.Point(4, 13);
			this.lblTRPath.Name = "lblTRPath";
			this.lblTRPath.Size = new System.Drawing.Size(104, 19);
			this.lblTRPath.TabIndex = 3;
			this.lblTRPath.Text = "TR Path";
			// 
			// lblBMPath
			// 
			this.lblBMPath.Location = new System.Drawing.Point(4, 40);
			this.lblBMPath.Name = "lblBMPath";
			this.lblBMPath.Size = new System.Drawing.Size(63, 20);
			this.lblBMPath.TabIndex = 4;
			this.lblBMPath.Text = "BM Path";
			// 
			// btnBMPath
			// 
			this.btnBMPath.Location = new System.Drawing.Point(301, 40);
			this.btnBMPath.Name = "btnBMPath";
			this.btnBMPath.Size = new System.Drawing.Size(75, 20);
			this.btnBMPath.TabIndex = 5;
			this.btnBMPath.Text = "Browse";
			this.btnBMPath.UseVisualStyleBackColor = true;
			this.btnBMPath.Click += new System.EventHandler(this.btnBMPath_Click);
			// 
			// txtTRPath
			// 
			this.txtTRPath.Location = new System.Drawing.Point(73, 12);
			this.txtTRPath.Name = "txtTRPath";
			this.txtTRPath.Size = new System.Drawing.Size(222, 20);
			this.txtTRPath.TabIndex = 6;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(12, 80);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(282, 173);
			this.listBox.TabIndex = 7;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(301, 80);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 8;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 271);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.txtTRPath);
			this.Controls.Add(this.btnBMPath);
			this.Controls.Add(this.lblBMPath);
			this.Controls.Add(this.lblTRPath);
			this.Controls.Add(this.txtBMPath);
			this.Controls.Add(this.btnTRPath);
			this.Name = "MainForm";
			this.Text = "Attendance Checker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
