using SimCorp.IMS.UnderstandingOOP.Images;
using SimCorp.IMS.UnderstandingOOP.MobilePhoneComponents;
using System;

namespace SimCorp.IMS.UnderstandingOOP.MobilePhoneComponent {
    class OLEDScreen : ColorfulScreen {

        public OLEDScreen():base() { }

        public OLEDScreen(TouchScreenType tsType, double size, int[] pixels) : base(tsType, size, pixels) { }

        public override void Show (IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(OLEDScreen)}");
        }

        public override string ToString() {
            return "OLED Screen";
        }

    }
}
