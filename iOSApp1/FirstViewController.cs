using MapKit;

namespace iOSApp1;

public class FirstViewController : UIViewController
{
     UIButton Button;
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        Button = new UIButton(View.Frame);
        Button.SetTitle("Click me to go to map", new ());
        View.AddSubview(Button);
    }

    public override void ViewDidAppear(bool animated)
    {
        base.ViewDidAppear(animated);
        
        Button.TouchUpInside += ButtonOnTouchUpInside;
    }

    public override void ViewWillDisappear(bool animated)
    {
        base.ViewWillDisappear(animated);
        
        Button.TouchUpInside -= ButtonOnTouchUpInside;
    }
    
    

     void ButtonOnTouchUpInside(object? sender, EventArgs e)
    {
        NavigationController.PushViewController(new MapViewController(), true);
    }
}