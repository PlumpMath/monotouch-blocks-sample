using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MTBlockBuilder
{
//	public delegate string BBStringProducer();
//	public delegate void BBAsyncOpResult( NSObject result, NSError error );
//	public delegate void BBAsyncOp( BBAsyncOpResult handler );


	public delegate void SingleItemReaderCallback( NSObject item, NSError error );
	
	[BaseType (typeof (NSObject))]
	interface BlockBuilder
	{
		[Export ("createHelloBuilder") ]
		NSObject createHelloBuilder(); //creates objc block

		[Export ("itemsReaderWithRequest") ]
		NSObject itemsReaderWithRequest(); //creates objc block

		[Export ("itemsReaderCallback") ]
		NSObject itemsReaderCallback(); //creates objc block
	}


	[BaseType (typeof (NSObject))]
	[Category]
	interface BlockForRuby 
	{
		[Export ("objc_BlockSend:")]
		NSObject objcBlockSend(NSObject[] args);

		[Export ("objc_BlockSend_Noreturn:")]
		void objcBlockSend_NoReturn(NSObject[] args);

		[Export ("block_ExecuteWithCallback2:")]
		void block_ExecuteWithCallback2( SingleItemReaderCallback callback );
	}
}

namespace SitecoreMobileSDK
{
	[BaseType (typeof (NSObject))]
	interface SCItem
	{
		[Export ("itemId")]
		String itemId { get; }
	}
	
	
	
	[BaseType (typeof (NSObject))]
	interface SCApiContext
	{
		[Static] 
		[Export ("contextWithHost:login:password:")]
		SCApiContext contextWithHostLoginPassword( String host, String login, String password );
		
		[Static]
		[Export ("contextWithHost:")]
		SCApiContext contextWithHost( String host );
		
		[Export ("itemWithId:")]
		SCItem itemWithId( String itemId );

		[Export ("itemReaderForItemId:")]
		NSObject itemReaderForItemId( String itemId );
	}
}


