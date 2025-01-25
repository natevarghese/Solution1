using System;
using CoreLocation;
using CoreGraphics;
using Foundation;
using Mapbox.Maps;
using ObjCRuntime;
using UIKit;

namespace Mapbox.Maps
{
    // @interface MapInitOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps14MapInitOptions")]
    [DisableDefaultCtor]
    interface MapInitOptions
    {
        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface MapView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps7MapView")]
    interface MapView
    {
        // - (nonnull instancetype)initWithFrame:(CGRect)frame SWIFT_UNAVAILABLE;
        [Export("initWithFrame:mapInitOptions:")]
        IntPtr Constructor(CGRect frame, MapInitOptions mapInitOptions);

        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]
        [RequiresSuper]
        void AwakeFromNib();

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)didMoveToWindow;
        [Export("didMoveToWindow")]
        void DidMoveToWindow();
    }
}
