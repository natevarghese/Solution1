using Mapbox.Maps;
using Mapbox.Bindings.Objc;

namespace iOSApp1;

public class MapViewController : UIViewController
{
    MapViewFactory MapViewFactory;
    MapView? MapView;

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        var token = "pk.eyJ1IjoibmF0ZTA4bmlrZSIsImEiOiJjbTZheHdxczAwMmtnMnhvYjd4enpzcjZzIn0.aiXVLpa-r-eJnfOyIH2KyQ";//will invalidate soon
        var styleUrl = "https://api.mapbox.com/styles/v1/nate08nike/cm6ay0627006001qr0cyf2vy2?access_token=" + token;
        var myMapInitOptions = MapInitOptionsFactory.CreateWithAccessToken(token, styleUrl, 27.73210646271838, -81.32525266125424, 8);
        MapView = MapViewFactory.CreateWithFrame(new CGRect(0, 0, View.Frame.Size.Width, View.Frame.Size.Height), myMapInitOptions);
        MapView.TranslatesAutoresizingMaskIntoConstraints = false;
        View.InsertSubview(MapView, 0);

        View.AddConstraint(NSLayoutConstraint.Create(MapView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 0));
        View.AddConstraint(NSLayoutConstraint.Create(MapView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1, 0));
        View.AddConstraint(NSLayoutConstraint.Create(MapView, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, View, NSLayoutAttribute.Bottom, 1, 0));
        View.AddConstraint(NSLayoutConstraint.Create(MapView, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, View, NSLayoutAttribute.Trailing, 1, 0));
    }
}