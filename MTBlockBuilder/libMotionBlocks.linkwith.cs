using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMotionBlocks.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
