﻿using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class AnimatedIcon
	{
		public IconSource FallbackIconSource
		{
			get => (IconSource)GetValue(FallbackIconSourceProperty);
			set => SetValue(FallbackIconSourceProperty, value);
		}

		public static DependencyProperty FallbackIconSourceProperty { get; } =
			DependencyProperty.Register(nameof(FallbackIconSource), typeof(IconSource), typeof(AnimatedIcon), new PropertyMetadata(null, OnFallbackIconSourcePropertyChanged));

		public bool MirroredWhenRightToLeft
		{
			get => (bool)GetValue(MirroredWhenRightToLeftProperty);
			set => SetValue(MirroredWhenRightToLeftProperty, value);
		}

		public static DependencyProperty MirroredWhenRightToLeftProperty { get; } =
			DependencyProperty.Register(nameof(MirroredWhenRightToLeft), typeof(bool), typeof(AnimatedIcon), new PropertyMetadata(false, OnMirroredWhenRightToLeftPropertyChanged));

		public IAnimatedVisualSource2 Source
		{
			get => (IAnimatedVisualSource2)GetValue(SourceProperty);
			set => SetValue(SourceProperty, value);
		}

		public static DependencyProperty SourceProperty { get; } =
			DependencyProperty.Register(nameof(Source), typeof(IAnimatedVisualSource2), typeof(AnimatedIcon), new PropertyMetadata(null, OnSourcePropertyChanged));

		public string State
		{
			get => (string)GetValue(StateProperty);
			set => SetValue(StateProperty, value);
		}

		public static readonly DependencyProperty StateProperty =
			DependencyProperty.Register(nameof(State), typeof(string), typeof(AnimatedIcon), new PropertyMetadata(null, OnAnimatedIconStatePropertyChanged));

		private static void OnFallbackIconSourcePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
		{
			var owner = sender as AnimatedIcon;
			owner?.OnFallbackIconSourcePropertyChanged(args);
		}

		private static void OnMirroredWhenRightToLeftPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
		{
			var owner = sender as AnimatedIcon;
			owner?.OnMirroredWhenRightToLeftPropertyChanged(args);
		}

		private static void OnSourcePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
		{
			var owner = sender as AnimatedIcon;
			owner?.OnFallbackIconSourcePropertyChanged(args);
		}
	}
}
