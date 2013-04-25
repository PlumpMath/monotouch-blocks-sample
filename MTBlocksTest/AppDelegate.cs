using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MTBlockBuilder;
using SitecoreMobileSDK;

namespace MTBlocksTest
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		MTBlocksTestViewController viewController;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);


			MTBlockBuilder.BlockBuilder bb = new MTBlockBuilder.BlockBuilder();
			NSObject helloBlock = bb.createHelloBuilder();

			NSObject[] helloArgs = new NSObject[0];
			NSObject hello = helloBlock.objcBlockSend( helloArgs );
			Console.WriteLine( hello );


			NSObject operation = bb.itemsReaderWithRequest();
			NSObject callback  = bb.itemsReaderCallback();

			NSObject[] operationArgs = new NSObject[1];
			operationArgs[0] = callback;
			operation.objcBlockSend_NoReturn( operationArgs );



			SCApiContext context = SCApiContext.contextWithHostLoginPassword( "ws-alr1.dk.sitecore.net:8094/-/item", "sitecore\\admin", "b" );
			NSObject loader = context.itemReaderForItemId( "{110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9}" );

			SingleItemReaderCallback loaderCallback = delegate( NSObject receivedObject, NSError error )
			{
				SCItem receivedItem = (SCItem)receivedObject;
				
				Console.WriteLine( receivedItem.itemId );
				Console.WriteLine( "===Loaded===" );
			};

			loader.block_ExecuteWithCallback2( loaderCallback );

			viewController = new MTBlocksTestViewController ();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

