using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSitecoreMobileSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, IsCxx = true, Frameworks="MapKit, CoreLocation, CoreMotion, CoreMedia, CoreVideo, AVFoundation, AudioToolbox, MessageUI, Twitter, AddressBookUI, AddressBook, CFNetwork, UIKit, Foundation, CoreGraphics", WeakFrameworks="Social", LinkerFlags="-lxml2 -lz -lsqlite3 -lstdc++ -lc++ -liconv -fobjc-arc -ObjC -all_load")]

// [assembly: LinkWith ("libSitecoreMobileSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, IsCxx = true)]