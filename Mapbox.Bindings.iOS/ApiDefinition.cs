using Mapbox.Maps;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Mapbox.Bindings.Objc;
using Foundation;
using CoreGraphics;
using System;
using UIKit;

namespace Mapbox.Bindings.Objc
{
	// @interface LatLng : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20Mapbox_Bindings_Objc6LatLng")]
	interface LatLng
	{
		// @property (nonatomic) double lat;
		[Export ("lat")]
		double Lat { get; set; }

		// @property (nonatomic) double lon;
		[Export ("lon")]
		double Lon { get; set; }
	}

	// @interface MapBounds : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20Mapbox_Bindings_Objc9MapBounds")]
	interface MapBounds
	{
		// @property (nonatomic, strong) LatLng * _Nullable northEast;
		[NullAllowed, Export ("northEast", ArgumentSemantic.Strong)]
		LatLng NorthEast { get; set; }

		// @property (nonatomic, strong) LatLng * _Nullable southWest;
		[NullAllowed, Export ("southWest", ArgumentSemantic.Strong)]
		LatLng SouthWest { get; set; }

		// @property (nonatomic, strong) LatLng * _Nullable center;
		[NullAllowed, Export ("center", ArgumentSemantic.Strong)]
		LatLng Center { get; set; }

		// @property (nonatomic) double zoom;
		[Export ("zoom")]
		double Zoom { get; set; }
	}

	// @interface MapInitOptionsFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20Mapbox_Bindings_Objc21MapInitOptionsFactory")]
	interface MapInitOptionsFactory
	{
		// +(MapInitOptions * _Nonnull)createWithAccessToken:(NSString * _Nonnull)accessToken style:(NSString * _Nonnull)style centerLat:(double)centerLat centerLon:(double)centerLon zoom:(double)zoom __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithAccessToken:style:centerLat:centerLon:zoom:")]
		MapInitOptions CreateWithAccessToken (string accessToken, string style, double centerLat, double centerLon, double zoom);
	}

	// @interface MapViewFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20Mapbox_Bindings_Objc14MapViewFactory")]
	interface MapViewFactory
	{
		// @property (copy, nonatomic) void (^ _Nullable)(NSString * _Nullable) emitLog;
		[NullAllowed, Export ("emitLog", ArgumentSemantic.Copy)]
		Action<NSString> EmitLog { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(MapView * _Nullable) mapLoaded;
		[NullAllowed, Export ("mapLoaded", ArgumentSemantic.Copy)]
		Action<MapView> MapLoaded { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(MapView * _Nullable) styleLoaded;
		[NullAllowed, Export ("styleLoaded", ArgumentSemantic.Copy)]
		Action<MapView> StyleLoaded { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(MapView * _Nullable) cameraChanged;
		[NullAllowed, Export ("cameraChanged", ArgumentSemantic.Copy)]
		Action<MapView> CameraChanged { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(BOOL) viewportUpdate;
		[NullAllowed, Export ("viewportUpdate", ArgumentSemantic.Copy)]
		Action<bool> ViewportUpdate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(LatLng * _Nullable) locationUpdate;
		[NullAllowed, Export ("locationUpdate", ArgumentSemantic.Copy)]
		Action<LatLng> LocationUpdate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(MapView * _Nullable) locationAnimationCompleted;
		[NullAllowed, Export ("locationAnimationCompleted", ArgumentSemantic.Copy)]
		Action<MapView> LocationAnimationCompleted { get; set; }

		// -(MapView * _Nonnull)createWithFrame:(CGRect)frame mapInitOptions:(MapInitOptions * _Nonnull)mapInitOptions __attribute__((warn_unused_result("")));
		[Export ("createWithFrame:mapInitOptions:")]
		MapView CreateWithFrame (CGRect frame, MapInitOptions mapInitOptions);

		// -(void)setStyleWithMapView:(MapView * _Nonnull)mapView style:(NSString * _Nonnull)style completed:(void (^ _Nonnull)(BOOL))completed;
		[Export ("setStyleWithMapView:style:completed:")]
		void SetStyleWithMapView (MapView mapView, string style, Action<bool> completed);

		// -(void)setCenterAndZoomWithMapView:(MapView * _Nonnull)mapView latitude:(double)latitude longitude:(double)longitude zoom:(double)zoom;
		[Export ("setCenterAndZoomWithMapView:latitude:longitude:zoom:")]
		void SetCenterAndZoomWithMapView (MapView mapView, double latitude, double longitude, double zoom);

		// -(void)moveCameraToBoundsWithMapView:(MapView * _Nonnull)mapView bounds:(NSArray<LatLng *> * _Nonnull)bounds padding:(UIEdgeInsets)padding duration:(double)duration;
		[Export ("moveCameraToBoundsWithMapView:bounds:padding:duration:")]
		void MoveCameraToBoundsWithMapView (MapView mapView, LatLng[] bounds, UIEdgeInsets padding, double duration);

		// -(void)featuresAtPointWithMapView:(MapView * _Nonnull)mapView point:(CGPoint)point completed:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull))completed;
		[Export ("featuresAtPointWithMapView:point:completed:")]
		void FeaturesAtPointWithMapView (MapView mapView, CGPoint point, Action<NSArray<NSString>> completed);

		// -(CGPoint)CoordinatePointAtPointWithMapView:(MapView * _Nonnull)mapView point:(CGPoint)point __attribute__((warn_unused_result("")));
		[Export ("CoordinatePointAtPointWithMapView:point:")]
		CGPoint CoordinatePointAtPointWithMapView (MapView mapView, CGPoint point);

		// -(MapBounds * _Nonnull)getBoundsWithMapView:(MapView * _Nonnull)mapView __attribute__((warn_unused_result("")));
		[Export ("getBoundsWithMapView:")]
		MapBounds GetBoundsWithMapView (MapView mapView);

		// -(BOOL)styleImageExistsWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("styleImageExistsWithMapView:id:")]
		bool StyleImageExistsWithMapView (MapView mapView, string id);

		// -(void)addStyleImageWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id base64:(NSString * _Nonnull)base64;
		[Export ("addStyleImageWithMapView:id:base64:")]
		void AddStyleImageWithMapView (MapView mapView, string id, string base64);

		// -(NSArray<NSString *> * _Nonnull)getAllLayerIdentifiersWithMapView:(MapView * _Nonnull)mapView __attribute__((warn_unused_result("")));
		[Export ("getAllLayerIdentifiersWithMapView:")]
		string[] GetAllLayerIdentifiersWithMapView (MapView mapView);

		// -(void)removeLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id;
		[Export ("removeLayerWithMapView:id:")]
		void RemoveLayerWithMapView (MapView mapView, string id);

		// -(BOOL)layerExistsWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("layerExistsWithMapView:id:")]
		bool LayerExistsWithMapView (MapView mapView, string id);

		// -(void)setLayerVisibilityWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id visible:(BOOL)visible;
		[Export ("setLayerVisibilityWithMapView:id:visible:")]
		void SetLayerVisibilityWithMapView (MapView mapView, string id, bool visible);

		// -(void)addLineLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId visible:(BOOL)visible predicateId:(NSString * _Nullable)predicateId referenceLayer:(NSString * _Nullable)referenceLayer;
		[Export ("addLineLayerWithMapView:id:sourceId:visible:predicateId:referenceLayer:")]
		void AddLineLayerWithMapView (MapView mapView, string id, string sourceId, bool visible, [NullAllowed] string predicateId, [NullAllowed] string referenceLayer);

		// -(void)addLineLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId sourceLayer:(NSString * _Nonnull)sourceLayer visible:(BOOL)visible color:(UIColor * _Nonnull)color lineWidth:(double)lineWidth predicateKey:(NSString * _Nonnull)predicateKey predicateId:(NSString * _Nullable)predicateId referenceLayer:(NSString * _Nullable)referenceLayer;
		[Export ("addLineLayerWithMapView:id:sourceId:sourceLayer:visible:color:lineWidth:predicateKey:predicateId:referenceLayer:")]
		void AddLineLayerWithMapView (MapView mapView, string id, string sourceId, string sourceLayer, bool visible, UIColor color, double lineWidth, string predicateKey, [NullAllowed] string predicateId, [NullAllowed] string referenceLayer);

		// -(void)updateLineLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId visible:(BOOL)visible predicateId:(NSString * _Nullable)predicateId;
		[Export ("updateLineLayerWithMapView:id:sourceId:visible:predicateId:")]
		void UpdateLineLayerWithMapView (MapView mapView, string id, string sourceId, bool visible, [NullAllowed] string predicateId);

		// -(void)updateLineLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId sourceLayer:(NSString * _Nonnull)sourceLayer visible:(BOOL)visible color:(UIColor * _Nonnull)color lineWidth:(double)lineWidth predicateKey:(NSString * _Nonnull)predicateKey predicateId:(NSString * _Nullable)predicateId;
		[Export ("updateLineLayerWithMapView:id:sourceId:sourceLayer:visible:color:lineWidth:predicateKey:predicateId:")]
		void UpdateLineLayerWithMapView (MapView mapView, string id, string sourceId, string sourceLayer, bool visible, UIColor color, double lineWidth, string predicateKey, [NullAllowed] string predicateId);

		// -(void)addFillLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId visible:(BOOL)visible predicateId:(NSString * _Nullable)predicateId referenceLayer:(NSString * _Nullable)referenceLayer;
		[Export ("addFillLayerWithMapView:id:sourceId:visible:predicateId:referenceLayer:")]
		void AddFillLayerWithMapView (MapView mapView, string id, string sourceId, bool visible, [NullAllowed] string predicateId, [NullAllowed] string referenceLayer);

		// -(void)updateFillLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId visible:(BOOL)visible predicateId:(NSString * _Nullable)predicateId;
		[Export ("updateFillLayerWithMapView:id:sourceId:visible:predicateId:")]
		void UpdateFillLayerWithMapView (MapView mapView, string id, string sourceId, bool visible, [NullAllowed] string predicateId);

		// -(void)addSymbolLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId visible:(BOOL)visible minZoom:(double)minZoom predicateId:(NSString * _Nullable)predicateId referenceLayer:(NSString * _Nullable)referenceLayer;
		[Export ("addSymbolLayerWithMapView:id:sourceId:visible:minZoom:predicateId:referenceLayer:")]
		void AddSymbolLayerWithMapView (MapView mapView, string id, string sourceId, bool visible, double minZoom, [NullAllowed] string predicateId, [NullAllowed] string referenceLayer);

		// -(void)updateSymbolLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id sourceId:(NSString * _Nonnull)sourceId visible:(BOOL)visible minZoom:(double)minZoom predicateId:(NSString * _Nullable)predicateId;
		[Export ("updateSymbolLayerWithMapView:id:sourceId:visible:minZoom:predicateId:")]
		void UpdateSymbolLayerWithMapView (MapView mapView, string id, string sourceId, bool visible, double minZoom, [NullAllowed] string predicateId);

		// -(void)setDisputedBoundriesWithMapView:(MapView * _Nonnull)mapView ids:(NSArray<NSString *> * _Nonnull)ids key:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export ("setDisputedBoundriesWithMapView:ids:key:value:")]
		void SetDisputedBoundriesWithMapView (MapView mapView, string[] ids, string key, string value);

		// -(void)addRasterTileLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id visible:(BOOL)visible minZoom:(double)minZoom maxZoom:(double)maxZoom referenceLayer:(NSString * _Nullable)referenceLayer;
		[Export ("addRasterTileLayerWithMapView:id:visible:minZoom:maxZoom:referenceLayer:")]
		void AddRasterTileLayerWithMapView (MapView mapView, string id, bool visible, double minZoom, double maxZoom, [NullAllowed] string referenceLayer);

		// -(void)updateRasterTileLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id visible:(BOOL)visible minZoom:(double)minZoom maxZoom:(double)maxZoom;
		[Export ("updateRasterTileLayerWithMapView:id:visible:minZoom:maxZoom:")]
		void UpdateRasterTileLayerWithMapView (MapView mapView, string id, bool visible, double minZoom, double maxZoom);

		// -(BOOL)sourceExistsWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("sourceExistsWithMapView:id:")]
		bool SourceExistsWithMapView (MapView mapView, string id);

		// -(NSArray<NSString *> * _Nonnull)getAllSourceIdentifiersWithMapView:(MapView * _Nonnull)mapView __attribute__((warn_unused_result("")));
		[Export ("getAllSourceIdentifiersWithMapView:")]
		string[] GetAllSourceIdentifiersWithMapView (MapView mapView);

		// -(void)addSourceWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id geoJson:(NSString * _Nonnull)geoJson;
		[Export ("addSourceWithMapView:id:geoJson:")]
		void AddSourceWithMapView (MapView mapView, string id, string geoJson);

		// -(void)updateSourceWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id geoJson:(NSString * _Nonnull)geoJson;
		[Export ("updateSourceWithMapView:id:geoJson:")]
		void UpdateSourceWithMapView (MapView mapView, string id, string geoJson);

		// -(void)removeSourceWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id;
		[Export ("removeSourceWithMapView:id:")]
		void RemoveSourceWithMapView (MapView mapView, string id);

		// -(void)addRasterTileSourceWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id urls:(NSArray<NSString *> * _Nonnull)urls tileSize:(double)tileSize;
		[Export ("addRasterTileSourceWithMapView:id:urls:tileSize:")]
		void AddRasterTileSourceWithMapView (MapView mapView, string id, string[] urls, double tileSize);

		// -(void)addVectorTileSourceWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id url:(NSString * _Nonnull)url;
		[Export ("addVectorTileSourceWithMapView:id:url:")]
		void AddVectorTileSourceWithMapView (MapView mapView, string id, string url);

		// -(void)addImageOverlaySourceWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id url:(NSString * _Nonnull)url;
		[Export ("addImageOverlaySourceWithMapView:id:url:")]
		void AddImageOverlaySourceWithMapView (MapView mapView, string id, string url);

		// -(void)addHeatMapLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id visible:(BOOL)visible intensity:(double)intensity opacity:(double)opacity radius:(double)radius stops:(NSArray<NSNumber *> * _Nonnull)stops colors:(NSArray<UIColor *> * _Nonnull)colors referenceLayer:(NSString * _Nullable)referenceLayer;
		[Export ("addHeatMapLayerWithMapView:id:visible:intensity:opacity:radius:stops:colors:referenceLayer:")]
		void AddHeatMapLayerWithMapView (MapView mapView, string id, bool visible, double intensity, double opacity, double radius, NSNumber[] stops, UIColor[] colors, [NullAllowed] string referenceLayer);

		// -(void)updateHeatMapLayerWithMapView:(MapView * _Nonnull)mapView id:(NSString * _Nonnull)id visible:(BOOL)visible intensity:(double)intensity opacity:(double)opacity radius:(double)radius stops:(NSArray<NSNumber *> * _Nonnull)stops colors:(NSArray<UIColor *> * _Nonnull)colors;
		[Export ("updateHeatMapLayerWithMapView:id:visible:intensity:opacity:radius:stops:colors:")]
		void UpdateHeatMapLayerWithMapView (MapView mapView, string id, bool visible, double intensity, double opacity, double radius, NSNumber[] stops, UIColor[] colors);

		// -(void)startUserLocationTrackingWithMapView:(MapView * _Nonnull)mapView zoom:(double)zoom;
		[Export ("startUserLocationTrackingWithMapView:zoom:")]
		void StartUserLocationTrackingWithMapView (MapView mapView, double zoom);

		// -(void)StopUserLocationTrackingWithMapView:(MapView * _Nonnull)mapView;
		[Export ("StopUserLocationTrackingWithMapView:")]
		void StopUserLocationTrackingWithMapView (MapView mapView);
	}

	// @interface OfflineManagerBridge : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20Mapbox_Bindings_Objc20OfflineManagerBridge")]
	interface OfflineManagerBridge
	{
		// @property (copy, nonatomic) void (^ _Nullable)(NSString * _Nullable) emitLog;
		[NullAllowed, Export ("emitLog", ArgumentSemantic.Copy)]
		Action<NSString> EmitLog { get; set; }

		// -(void)getAllTileRegionsWithCompleted:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull))completed;
		[Export ("getAllTileRegionsWithCompleted:")]
		void GetAllTileRegionsWithCompleted (Action<NSArray<NSString>> completed);

		// -(void)RemoveTileRegionWithId:(NSString * _Nonnull)id;
		[Export ("RemoveTileRegionWithId:")]
		void RemoveTileRegionWithId (string id);

		// -(void)downloadTileRegionWithAccessToken:(NSString * _Nonnull)accessToken id:(NSString * _Nonnull)id style:(NSString * _Nonnull)style metadata:(NSDictionary * _Nonnull)metadata bounds:(NSArray<LatLng *> * _Nonnull)bounds minZoom:(double)minZoom maxZoom:(double)maxZoom completed:(void (^ _Nonnull)(BOOL))completed;
		[Export ("downloadTileRegionWithAccessToken:id:style:metadata:bounds:minZoom:maxZoom:completed:")]
		void DownloadTileRegionWithAccessToken (string accessToken, string id, string style, NSDictionary metadata, LatLng[] bounds, double minZoom, double maxZoom, Action<bool> completed);
	}
}
