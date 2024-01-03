using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Logi
{
	// Token: 0x02000005 RID: 5
	public class CyclingGradient : UserControl, IComponentConnector
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000A3D0 File Offset: 0x000085D0
		public CyclingGradient()
		{
			this.InitializeComponent();
			base.Loaded += this.onLoaded;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000A3F0 File Offset: 0x000085F0
		private void onLoaded(object sender, RoutedEventArgs e)
		{
			this.onColorChange();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000A3F8 File Offset: 0x000085F8
		private void onColorChange()
		{
			Storyboard storyboard = this.storyBoardControl;
			storyboard.Duration = CyclingGradient._animDuration;
			storyboard.Children.Clear();
			DoubleAnimation doubleAnimation = new DoubleAnimation(CyclingGradient._gs2Start, CyclingGradient._gs2End, CyclingGradient._segmentDuration);
			doubleAnimation.BeginTime = new TimeSpan?(CyclingGradient._ts1);
			Storyboard.SetTargetName(doubleAnimation, "GradientStop2");
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(GradientStop.OffsetProperty));
			storyboard.Children.Add(doubleAnimation);
			DoubleAnimation doubleAnimation2 = new DoubleAnimation(CyclingGradient._gs3Start, CyclingGradient._gs3End, CyclingGradient._segmentDuration);
			doubleAnimation2.BeginTime = new TimeSpan?(CyclingGradient._ts1);
			Storyboard.SetTargetName(doubleAnimation2, "GradientStop3");
			Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(GradientStop.OffsetProperty));
			storyboard.Children.Add(doubleAnimation2);
			DoubleAnimation doubleAnimation3 = new DoubleAnimation(CyclingGradient._gs2Start, CyclingGradient._gs2End, CyclingGradient._segmentDuration);
			doubleAnimation3.BeginTime = new TimeSpan?(CyclingGradient._ts2);
			Storyboard.SetTargetName(doubleAnimation3, "GradientStop2");
			Storyboard.SetTargetProperty(doubleAnimation3, new PropertyPath(GradientStop.OffsetProperty));
			storyboard.Children.Add(doubleAnimation3);
			DoubleAnimation doubleAnimation4 = new DoubleAnimation(CyclingGradient._gs3Start, CyclingGradient._gs3End, CyclingGradient._segmentDuration);
			doubleAnimation4.BeginTime = new TimeSpan?(CyclingGradient._ts2);
			Storyboard.SetTargetName(doubleAnimation4, "GradientStop3");
			Storyboard.SetTargetProperty(doubleAnimation4, new PropertyPath(GradientStop.OffsetProperty));
			storyboard.Children.Add(doubleAnimation4);
			DoubleAnimation doubleAnimation5 = new DoubleAnimation(CyclingGradient._gs2Start, CyclingGradient._gs2End, CyclingGradient._segmentDuration);
			doubleAnimation5.BeginTime = new TimeSpan?(CyclingGradient._ts3);
			Storyboard.SetTargetName(doubleAnimation5, "GradientStop2");
			Storyboard.SetTargetProperty(doubleAnimation5, new PropertyPath(GradientStop.OffsetProperty));
			storyboard.Children.Add(doubleAnimation5);
			DoubleAnimation doubleAnimation6 = new DoubleAnimation(CyclingGradient._gs3Start, CyclingGradient._gs3End, CyclingGradient._segmentDuration);
			doubleAnimation6.BeginTime = new TimeSpan?(CyclingGradient._ts3);
			Storyboard.SetTargetName(doubleAnimation6, "GradientStop3");
			Storyboard.SetTargetProperty(doubleAnimation6, new PropertyPath(GradientStop.OffsetProperty));
			storyboard.Children.Add(doubleAnimation6);
			ColorAnimationUsingKeyFrames colorAnimationUsingKeyFrames = new ColorAnimationUsingKeyFrames();
			colorAnimationUsingKeyFrames.Duration = CyclingGradient._animDuration;
			colorAnimationUsingKeyFrames.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color2, CyclingGradient._ts1));
			colorAnimationUsingKeyFrames.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color3, CyclingGradient._ts2));
			colorAnimationUsingKeyFrames.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color1, CyclingGradient._ts3));
			Storyboard.SetTargetName(colorAnimationUsingKeyFrames, "GradientStop1");
			Storyboard.SetTargetProperty(colorAnimationUsingKeyFrames, new PropertyPath(GradientStop.ColorProperty));
			storyboard.Children.Add(colorAnimationUsingKeyFrames);
			ColorAnimationUsingKeyFrames colorAnimationUsingKeyFrames2 = new ColorAnimationUsingKeyFrames();
			colorAnimationUsingKeyFrames2.Duration = CyclingGradient._animDuration;
			colorAnimationUsingKeyFrames2.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color2, CyclingGradient._ts1));
			colorAnimationUsingKeyFrames2.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color3, CyclingGradient._ts2));
			colorAnimationUsingKeyFrames2.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color1, CyclingGradient._ts3));
			Storyboard.SetTargetName(colorAnimationUsingKeyFrames2, "GradientStop2");
			Storyboard.SetTargetProperty(colorAnimationUsingKeyFrames2, new PropertyPath(GradientStop.ColorProperty));
			storyboard.Children.Add(colorAnimationUsingKeyFrames2);
			ColorAnimationUsingKeyFrames colorAnimationUsingKeyFrames3 = new ColorAnimationUsingKeyFrames();
			colorAnimationUsingKeyFrames3.Duration = CyclingGradient._animDuration;
			colorAnimationUsingKeyFrames3.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color1, CyclingGradient._ts1));
			colorAnimationUsingKeyFrames3.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color2, CyclingGradient._ts2));
			colorAnimationUsingKeyFrames3.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color3, CyclingGradient._ts3));
			Storyboard.SetTargetName(colorAnimationUsingKeyFrames3, "GradientStop3");
			Storyboard.SetTargetProperty(colorAnimationUsingKeyFrames3, new PropertyPath(GradientStop.ColorProperty));
			storyboard.Children.Add(colorAnimationUsingKeyFrames3);
			ColorAnimationUsingKeyFrames colorAnimationUsingKeyFrames4 = new ColorAnimationUsingKeyFrames();
			colorAnimationUsingKeyFrames4.Duration = CyclingGradient._animDuration;
			colorAnimationUsingKeyFrames4.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color1, CyclingGradient._ts1));
			colorAnimationUsingKeyFrames4.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color2, CyclingGradient._ts2));
			colorAnimationUsingKeyFrames4.KeyFrames.Add(new DiscreteColorKeyFrame(this.Color3, CyclingGradient._ts3));
			Storyboard.SetTargetName(colorAnimationUsingKeyFrames4, "GradientStop4");
			Storyboard.SetTargetProperty(colorAnimationUsingKeyFrames4, new PropertyPath(GradientStop.ColorProperty));
			storyboard.Children.Add(colorAnimationUsingKeyFrames4);
			storyboard.Begin(this.GradientBG, true);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000A88B File Offset: 0x00008A8B
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000A89D File Offset: 0x00008A9D
		public new Brush OpacityMask
		{
			get
			{
				return (Brush)base.GetValue(CyclingGradient.OpacityMaskProperty);
			}
			set
			{
				base.SetValue(CyclingGradient.OpacityMaskProperty, value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000A8AB File Offset: 0x00008AAB
		// (set) Token: 0x06000012 RID: 18 RVA: 0x0000A8BD File Offset: 0x00008ABD
		public Color Color1
		{
			get
			{
				return (Color)base.GetValue(CyclingGradient.Color1Property);
			}
			set
			{
				if (value != (Color)base.GetValue(CyclingGradient.Color1Property))
				{
					base.SetValue(CyclingGradient.Color1Property, value);
					this.onColorChange();
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000A8EE File Offset: 0x00008AEE
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000A900 File Offset: 0x00008B00
		public Color Color2
		{
			get
			{
				return (Color)base.GetValue(CyclingGradient.Color2Property);
			}
			set
			{
				if (value != (Color)base.GetValue(CyclingGradient.Color2Property))
				{
					base.SetValue(CyclingGradient.Color2Property, value);
					this.onColorChange();
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000A931 File Offset: 0x00008B31
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000A943 File Offset: 0x00008B43
		public Color Color3
		{
			get
			{
				return (Color)base.GetValue(CyclingGradient.Color3Property);
			}
			set
			{
				if (value != (Color)base.GetValue(CyclingGradient.Color3Property))
				{
					base.SetValue(CyclingGradient.Color3Property, value);
					this.onColorChange();
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000A974 File Offset: 0x00008B74
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/lghub_installer;component/components/cyclinggradient.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.GradientBG = (Rectangle)target;
				return;
			case 2:
				this.GradientStop1 = (GradientStop)target;
				return;
			case 3:
				this.GradientStop2 = (GradientStop)target;
				return;
			case 4:
				this.GradientStop3 = (GradientStop)target;
				return;
			case 5:
				this.GradientStop4 = (GradientStop)target;
				return;
			case 6:
				this.storyBoardControl = (Storyboard)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000098 RID: 152
		private static TimeSpan _ts1 = new TimeSpan(0, 0, 0, 0, 0);

		// Token: 0x04000099 RID: 153
		private static TimeSpan _ts2 = new TimeSpan(0, 0, 0, 1, 500);

		// Token: 0x0400009A RID: 154
		private static TimeSpan _ts3 = new TimeSpan(0, 0, 0, 3, 0);

		// Token: 0x0400009B RID: 155
		private static double _gs2Start = -0.6;

		// Token: 0x0400009C RID: 156
		private static double _gs2End = 1.0;

		// Token: 0x0400009D RID: 157
		private static double _gs3Start = 0.0;

		// Token: 0x0400009E RID: 158
		private static double _gs3End = 1.6;

		// Token: 0x0400009F RID: 159
		private static Duration _segmentDuration = new Duration(new TimeSpan(0, 0, 0, 1, 500));

		// Token: 0x040000A0 RID: 160
		private static Duration _animDuration = new Duration(new TimeSpan(0, 0, 0, 4, 500));

		// Token: 0x040000A1 RID: 161
		public new static readonly DependencyProperty OpacityMaskProperty = DependencyProperty.Register("OpacityMask", typeof(Brush), typeof(CyclingGradient));

		// Token: 0x040000A2 RID: 162
		public static readonly DependencyProperty Color1Property = DependencyProperty.Register("Color1", typeof(Color), typeof(CyclingGradient), new PropertyMetadata(Color.FromArgb(byte.MaxValue, 0, 149, byte.MaxValue)));

		// Token: 0x040000A3 RID: 163
		public static readonly DependencyProperty Color2Property = DependencyProperty.Register("Color2", typeof(Color), typeof(CyclingGradient), new PropertyMetadata(Color.FromArgb(byte.MaxValue, 0, 230, 156)));

		// Token: 0x040000A4 RID: 164
		public static readonly DependencyProperty Color3Property = DependencyProperty.Register("Color3", typeof(Color), typeof(CyclingGradient), new PropertyMetadata(Color.FromArgb(byte.MaxValue, 160, 71, byte.MaxValue)));

		// Token: 0x040000A5 RID: 165
		internal Rectangle GradientBG;

		// Token: 0x040000A6 RID: 166
		internal GradientStop GradientStop1;

		// Token: 0x040000A7 RID: 167
		internal GradientStop GradientStop2;

		// Token: 0x040000A8 RID: 168
		internal GradientStop GradientStop3;

		// Token: 0x040000A9 RID: 169
		internal GradientStop GradientStop4;

		// Token: 0x040000AA RID: 170
		internal Storyboard storyBoardControl;

		// Token: 0x040000AB RID: 171
		private bool _contentLoaded;
	}
}
