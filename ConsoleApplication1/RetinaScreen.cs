using System;

namespace MobilePhone {
    class RetinaScreen : ColorfulScreen {

        public RetinaScreen():base() { }

        public RetinaScreen(TouchScreenType tsType, double size, int[] pixels) : base(tsType, size, pixels) { }

        public override void Show(IScreenImage screenImage) { Console.WriteLine($"I am {nameof(RetinaScreen)}");}

        public override string ToString() { return "Retina Screen"; }
    }
}
