//
//  BlockBuilder.h
//  BlockBuilder
//
//  Created by Oleksandr Dodatko on 1/17/13.
//  Copyright (c) 2013 EmbeddedSources. All rights reserved.
//

@class NSError;



#import <Foundation/Foundation.h>


//typedef void (^BBAsyncOpResult)(id result, NSError *error);
//typedef void (^BBAsyncOp)(id handler);
//
//typedef NSString*(^BBStringProducer)(void);
//
//@interface BlockBuilder : NSObject
//
//-(BBStringProducer)createHelloBuilder;
//
//-(id)itemsReaderWithRequest;
//-(id)itemsReaderCallback;
//
//@end



typedef void (^BBAsyncOpResult)(id result, NSError *error);
typedef void (^BBAsyncOp)(BBAsyncOpResult handler);

typedef NSString*(^BBStringProducer)(void);

@interface BlockBuilder : NSObject

-(BBStringProducer)createHelloBuilder;

-(BBAsyncOp)itemsReaderWithRequest;
-(BBAsyncOpResult)itemsReaderCallback;

@end
