using SimCorp.IMS.UnderstandingOOP.Images;
using System;

namespace SimCorp.IMS.UnderstandingOOP.MobilePhoneComponents {
    class RetinaScreen : ColorfulScreen {

        public RetinaScreen():base() { }

        public RetinaScreen(TouchScreenType tsType, double size, int[] pixels) : base(tsType, size, pixels) { }

        public override void Show(IScreenImage screenImage) { Console.WriteLine($"I am {nameof(RetinaScreen)}");}

        public override string ToString() { return "Retina Screen"; }
    }
}
