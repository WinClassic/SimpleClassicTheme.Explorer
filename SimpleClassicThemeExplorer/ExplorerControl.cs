using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleClassicThemeExplorer
{
	public partial class ExplorerControl : UserControl
	{
		private string title = "SCT Explorer";

		[Category("Appearance"), Description("Gets the title for this SCT Explorer control."), ReadOnly(true)]
		public string Title { get => title; set { title = value; TitleChanged?.Invoke(this, EventArgs.Empty); } }

		[Category("Property Changed"), Description("Occurs whenever the title of this SCT Explorer control changes.")]
		public EventHandler TitleChanged;

		public ExplorerControl()
		{
			InitializeComponent();
		}
	}
}
