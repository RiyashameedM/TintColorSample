using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TintColorSimpleSample
{
	public partial class MainPage : ContentPage
	{
		public View View1 { get; set; }
		public View View2 { get; set; }
		public View View3 { get; set; }
		public MainPage()
		{
			InitializeComponent();
			this.View1 = this.Resources["View1"] as View;
			this.View2 = this.Resources["View2"] as View;
			this.View3 = this.Resources["View3"] as View;
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				if (button.Text == "View1")
				{
					((this.Content as StackLayout).Children[1] as ContentView).BindingContext = new TestSampleViewModel1();
					((this.Content as StackLayout).Children[1] as ContentView).Content = this.View2;
					button.Text = "View2";
				}
				else if (button.Text == "View2")
				{
					((this.Content as StackLayout).Children[1] as ContentView).BindingContext = new TestSampleViewModel2();
					((this.Content as StackLayout).Children[1] as ContentView).Content = this.View3;
					button.Text = "View3";
				}
				else if (button.Text == "View3")
				{
					((this.Content as StackLayout).Children[1] as ContentView).BindingContext = new TestSampleViewModel();
					((this.Content as StackLayout).Children[1] as ContentView).Content = this.View1;
					button.Text = "View1";
				}
			}
		}
	}
	public class TestSampleViewModel : INotifyPropertyChanged
	{
		public TestSampleViewModel()
		{

		}

		private int selected = 0;

		public event PropertyChangedEventHandler? PropertyChanged;

		public int Selected
		{
			get { return selected; }
			set { selected = value; OnPropertyChanged("Selected"); }
		}
		protected virtual void OnPropertyChanged(string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public class TestSampleViewModel2 : INotifyPropertyChanged
	{
		public TestSampleViewModel2()
		{
			Selected = 1;
		}

		private int selected = 0;

		public event PropertyChangedEventHandler? PropertyChanged;

		public int Selected
		{
			get { return selected; }
			set { selected = value; OnPropertyChanged("Selected"); }
		}

		protected virtual void OnPropertyChanged(string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	public class TestSampleViewModel1 : INotifyPropertyChanged
	{
		public TestSampleViewModel1()
		{

		}

		private int selected = 1;

		public event PropertyChangedEventHandler? PropertyChanged;

		public int Selected
		{
			get { return selected; }
			set { selected = value; OnPropertyChanged("Selected"); }
		}

		protected virtual void OnPropertyChanged(string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
