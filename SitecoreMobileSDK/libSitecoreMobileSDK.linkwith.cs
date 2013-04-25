using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSitecoreMobileSDK.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
