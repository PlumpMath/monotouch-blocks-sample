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
	}
}

//namespace MonoTouch.Foundation
//{
//	[BaseType (typeof (NSObject))]
//	[Category]
//	interface NSObject 
//	{
//		[Export ("objc_BlockSend:")]
//		NSObject objcBlockSend(NSObject[] args);
//		
//		[Export ("objc_BlockSend_Noreturn:")]
//		void objcBlockSend_NoReturn(NSObject[] args);
//	}
//}

