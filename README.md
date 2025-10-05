# Image-Editor-localization-sample-for-native-platforms
This repository contain samples demonstrating localization support for native platforms using Syncfusion Xamarin SfImageEditor on [Android](https://help.syncfusion.com/cr/xamarin-android/Syncfusion.SfImageEditor.Android.SfImageEditor.html) and [iOS](https://help.syncfusion.com/cr/xamarin-ios/Syncfusion.SfImageEditor.iOS.SfImageEditor.html).

## Syncfusion controls:

This project used the following Syncfusion control(s):
* SfImageEditor for Android.
* SfImageEditor for iOS.

## Supported platforms

### Android

<table>
    <tr>
        <th>Platform<br/>
            <br/></th>        
        <th>
          Device Types
            <br/>
            <br/>
        </th>
          <th>
            Controls
            <br/>
            <br/>
        </th>
        <th>
            Supported versions
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="2">
            Android
            <br/>
            <br/>
        </td>
        <td rowspan="2">
        Phone, Tablet
        <br/>
        <br/>
        </td>
        <td>
            SfPdfViewer, SfCheckBox
            <br/>
            <br/>
        </td>
         <td>
            API level 21 and later versions
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            All other controls 
            <br/>
            <br/>
        </td>
         <td>
            API level 19 and later versions
            <br/>
            <br/>
        </td>
    </tr>
</table>

### iOS

<table>
    <tr>
        <th>Platform<br/>
            <br/></th>        
        <th>
          Device Types
            <br/>
            <br/>
        </th>
          <th>
            Controls
            <br/>
            <br/>
        </th>
        <th>
            Supported versions
            <br/>
            <br/>
        </th>
    </tr>
	<tr>
        <td>
            iOS
            <br/>
            <br/>
        </td>
        <td>
            iPhone, iPod, iPad
            <br/>
            <br/>
        </td>
          <td>
            All controls 
            <br/>
            <br/>
        </td>
        <td>
            iOS 9.0 and later versions
            <br/>
            <br/>
        </td>
    </tr>
</table>

## Requirements to run the sample

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)

Refer to the following link for more details - [Android](https://help.syncfusion.com/xamarin-android/system-requirements), [iOS](https://help.syncfusion.com/xamarin-ios/system-requirements).

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*
   
2. Register your license key as demonstrated in the following code.

    ### Android

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Register Syncfusion<sup>®</sup> license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

    ### iOS

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            //Register Syncfusion<sup>®</sup> license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            // create a new window instance based on the screen size
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            // If you have defined a root view controller, set it here:
            // Window.RootViewController = myViewController;

            // make the window visible
            Window.MakeKeyAndVisible();

            return true;
        }
		
	Refer to this links ([Android](https://help.syncfusion.com/xamarin-android/licensing/overview), [iOS](https://help.syncfusion.com/xamarin-ios/licensing/overview)) for more details.
	
3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.