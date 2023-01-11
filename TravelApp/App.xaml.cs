using TravelApp.CustomControl;
using TravelApp.Views;

namespace TravelApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

//		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BottomBorderEntry), (handler, view) =>
//		{
//			if (view is BottomBorderEntry)
//			{
//#if ANDROID

//				handler.PlatformView.SetBackgroundColor(Colors.LightGray.ToNative());

//#elif IOS || MACCATALYST
//                //handler.PlatformView.BackgroundColor = Colors.LightGray.ToNative();
//                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.Line;
//#elif WINDOWS
//                        handler.NativeView.Background = Colors.LightGray.ToNative();
//#endif
//            }

//        });

		MainPage = new NavigationPage(new GetStartedPage());
	}
}
