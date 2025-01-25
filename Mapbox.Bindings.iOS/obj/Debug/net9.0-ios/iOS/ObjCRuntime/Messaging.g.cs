//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace ApiDefinition {
	static partial class Messaging {
		internal const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";
		static internal System.Reflection.Assembly this_assembly = typeof (Messaging).Assembly;
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend (IntPtr receiever, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper (IntPtr receiever, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend_IntPtr (IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static double Double_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static double Double_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double_Double_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3, double arg4, double arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_Double_Double_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3, double arg4, double arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_CGRect_NativeHandle (IntPtr receiver, IntPtr selector, CGRect arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (IntPtr receiver, IntPtr selector, CGRect arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_Double_Double_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2, double arg3, double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_Double_Double_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2, double arg3, double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_UIEdgeInsets_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, global::UIKit.UIEdgeInsets arg3, double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_UIEdgeInsets_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, global::UIKit.UIEdgeInsets arg3, double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_CGPoint_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, CGPoint arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_CGPoint_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, CGPoint arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static CGPoint CGPoint_objc_msgSend_NativeHandle_CGPoint (IntPtr receiver, IntPtr selector, NativeHandle arg1, CGPoint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static CGPoint CGPoint_objc_msgSendSuper_NativeHandle_CGPoint (IntPtr receiver, IntPtr selector, NativeHandle arg1, CGPoint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		public unsafe extern static CGPoint CGPoint_objc_msgSend_stret_NativeHandle_CGPoint (IntPtr receiver, IntPtr selector, NativeHandle arg1, CGPoint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		public unsafe extern static CGPoint CGPoint_objc_msgSendSuper_stret_NativeHandle_CGPoint (IntPtr receiver, IntPtr selector, NativeHandle arg1, CGPoint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, NativeHandle arg5, NativeHandle arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, NativeHandle arg5, NativeHandle arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, byte arg5, NativeHandle arg6, double arg7, NativeHandle arg8, NativeHandle arg9, NativeHandle arg10);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, byte arg5, NativeHandle arg6, double arg7, NativeHandle arg8, NativeHandle arg9, NativeHandle arg10);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, NativeHandle arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, NativeHandle arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_Double_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, byte arg5, NativeHandle arg6, double arg7, NativeHandle arg8, NativeHandle arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_Double_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, byte arg5, NativeHandle arg6, double arg7, NativeHandle arg8, NativeHandle arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_Double_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, double arg5, NativeHandle arg6, NativeHandle arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_Double_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, double arg5, NativeHandle arg6, NativeHandle arg7);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_Double_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, double arg5, NativeHandle arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_Double_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, byte arg4, double arg5, NativeHandle arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_bool_Double_Double_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5, NativeHandle arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_bool_Double_Double_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5, NativeHandle arg6);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_bool_Double_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_bool_Double_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, double arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_bool_Double_Double_Double_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5, double arg6, NativeHandle arg7, NativeHandle arg8, NativeHandle arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_bool_Double_Double_Double_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5, double arg6, NativeHandle arg7, NativeHandle arg8, NativeHandle arg9);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_bool_Double_Double_Double_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5, double arg6, NativeHandle arg7, NativeHandle arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_bool_Double_Double_Double_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, double arg4, double arg5, double arg6, NativeHandle arg7, NativeHandle arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_Double (IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_Double_Double_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5, double arg6, double arg7, NativeHandle arg8);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_Double_Double_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5, double arg6, double arg7, NativeHandle arg8);
	}
}
