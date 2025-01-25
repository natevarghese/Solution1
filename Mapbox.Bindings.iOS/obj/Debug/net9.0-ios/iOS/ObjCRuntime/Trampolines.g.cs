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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSArray<NSString>>))]
		unsafe internal delegate void DActionArity1V0 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::System.Action<NSArray<NSString>>))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSArray<NSString>>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<global::Foundation.NSArray<NSString>> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSArray<NSString>>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSArray<NSString>> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V0), nameof (Invoke));
			}
		} /* class SDActionArity1V0 */
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSArray<NSString>>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSArray<NSString>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSArray<NSString> obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString>))]
		unsafe internal delegate void DActionArity1V3 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V3 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::System.Action<NSString>))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSString>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSString> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSString>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSString> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V3), nameof (Invoke));
			}
		} /* class SDActionArity1V3 */
		internal sealed class NIDActionArity1V3 : TrampolineBlockBase {
			DActionArity1V3 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V3 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V3> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSString>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V3 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V3 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::Mapbox.Bindings.Objc.LatLng>))]
		unsafe internal delegate void DActionArity1V4 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V4 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::System.Action<global::Mapbox.Bindings.Objc.LatLng>))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<global::Mapbox.Bindings.Objc.LatLng>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<Mapbox.Bindings.Objc.LatLng> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<global::Mapbox.Bindings.Objc.LatLng>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<global::Mapbox.Bindings.Objc.LatLng> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V4), nameof (Invoke));
			}
		} /* class SDActionArity1V4 */
		internal sealed class NIDActionArity1V4 : TrampolineBlockBase {
			DActionArity1V4 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V4 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V4> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::Mapbox.Bindings.Objc.LatLng>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::Mapbox.Bindings.Objc.LatLng>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V4 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Mapbox.Bindings.Objc.LatLng obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V4 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::Mapbox.Maps.MapView>))]
		unsafe internal delegate void DActionArity1V2 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::System.Action<global::Mapbox.Maps.MapView>))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<global::Mapbox.Maps.MapView>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<Mapbox.Maps.MapView> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<global::Mapbox.Maps.MapView>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<global::Mapbox.Maps.MapView> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V2), nameof (Invoke));
			}
		} /* class SDActionArity1V2 */
		internal sealed class NIDActionArity1V2 : TrampolineBlockBase {
			DActionArity1V2 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::Mapbox.Maps.MapView>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::Mapbox.Maps.MapView>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Mapbox.Maps.MapView obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V2 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<bool>))]
		unsafe internal delegate void DActionArity1V1 (IntPtr block, byte obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::System.Action<bool>))]
			internal static unsafe void Invoke (IntPtr block, byte obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<bool>> (block);
				if (del is not null) {
					del (obj != 0);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<bool>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<bool> callback)
			{
				delegate* unmanaged<IntPtr, byte, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V1), nameof (Invoke));
			}
		} /* class SDActionArity1V1 */
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool obj)
			{
				invoker (BlockPointer, obj ? (byte) 1 : (byte) 0);
			}
		} /* class NIDActionArity1V1 */
	}
}
