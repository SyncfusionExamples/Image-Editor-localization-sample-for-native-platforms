using System;
using CoreGraphics;
using Syncfusion.SfImageEditor.iOS;
using UIKit;

namespace GettingStarted
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SfImageEditor editor = new SfImageEditor();
            editor.Image = UIImage.FromBundle("image.jpg");
            editor.Frame = this.View.Frame;
            this.Add(editor);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
