﻿namespace WeatherApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WeatherPage();
	}
}
