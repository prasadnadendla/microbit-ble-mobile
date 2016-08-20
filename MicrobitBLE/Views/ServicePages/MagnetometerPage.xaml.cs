﻿using System;
using System.Collections.Generic;
using MicrobitBLE.MicrobitUtils.Services;
using Plugin.BLE.Abstractions.Contracts;
using Xamarin.Forms;

namespace MicrobitBLE.Views.ServicePages
{
	public partial class MagnetometerPage : ContentPage
	{
		private MagnetometerService _service;

		public MagnetometerPage(MagnetometerService service)
		{
			InitializeComponent();
			_service = service;
			BindingContext = _service;
		}

		protected override void OnAppearing()
		{
			_service.LoadCharacteristics();
		}

		protected override void OnDisappearing()
		{
			_service.StopUpdates();
		}
	}
}

