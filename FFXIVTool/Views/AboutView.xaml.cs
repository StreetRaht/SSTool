﻿using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace FFXIVTool.Views
{
	/// <summary>
	/// Interaction logic for AboutView.xaml
	/// </summary>
	public partial class AboutView : UserControl
	{
		public AboutView()
		{
			InitializeComponent();
		}
		private void GitHubButton_OnClick(object sender, RoutedEventArgs e)
		{
			Process.Start("https://github.com/imchillin/SSTool");
		}
		private void DonateButton_OnClick(object sender, RoutedEventArgs e)
		{
			Process.Start("https://ko-fi.com/seibanaut");
		}

		private void DonateButton_OnClick2(object sender, RoutedEventArgs e)
		{
			Process.Start("http://ko-fi.com/leonblade");
		}

		private void DonateButton_OnClick3(object sender, RoutedEventArgs e)
		{
			Process.Start("http://ko-fi.com/krisanthyme");
		}

		private void ChatButton_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://twitter.com/ffxivsstool");
		}

		private void AboutDiscordBtn_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://discord.gg/hq3DnBa");
		}
	}
}
