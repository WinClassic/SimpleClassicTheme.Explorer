
namespace SimpleClassicThemeExplorer
{
	partial class ExplorerForm
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
			this.explorerControl = new SimpleClassicThemeExplorer.ExplorerControl();
			this.SuspendLayout();
			// 
			// explorerControl
			// 
			this.explorerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.explorerControl.Location = new System.Drawing.Point(0, 0);
			this.explorerControl.Name = "explorerControl";
			this.explorerControl.Size = new System.Drawing.Size(645, 416);
			this.explorerControl.TabIndex = 0;
			// 
			// ExplorerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 416);
			this.Controls.Add(this.explorerControl);
			this.Name = "ExplorerForm";
			this.Text = "SCT Explorer";
			this.ResumeLayout(false);

		}

		#endregion

		private ExplorerControl explorerControl;
	}
}