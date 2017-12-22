using System;
using System.Collections;

namespace MobilePhone {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; set; }
        public abstract Keyboard Keyboard { get; set; }
        public abstract Battery Battery { get; set; }
        public abstract SimCard SimCard { get; set; }
        public abstract OperatingSystem OperatingSystem { get; set; }
        public abstract Camera Camera { get; set; }

        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        public void CreateMobile() {
            Console.WriteLine(Screen.ToString());
           
            Keyboard.ToString();
            Battery.ToString();
            SimCard.ToString();
            OperatingSystem.ToString();
            Camera.ToString();

        }

        public ScreenBase defineScreen() {
            ScreenBase result = new ColorfulScreen();
            Console.WriteLine("Choose screen type index:");
            Console.WriteLine($"0 - {nameof(MonochromeScreen)}");
            Console.WriteLine($"1 - {nameof(ColorfulScreen)}");
            int screenType = Convert.ToInt32(Console.ReadLine());
            if (screenType == 0)
            {
                result = new MonochromeScreen();
            }
            if (screenType == 1)
            {
                Console.WriteLine("Choose ColorfulScreen type index:");
                Console.WriteLine($"0 - {nameof(OLEDScreen)}");
                Console.WriteLine($"1 - {nameof(RetinaScreen)}");
                int colorfulScreenType = Convert.ToInt32(Console.ReadLine());
                if (colorfulScreenType == 0) {
                    result = new OLEDScreen();
                }
                else if (colorfulScreenType == 1) {
                    result = new RetinaScreen();
                }
            }
            return result;
        }

        public int defineKeyBoardParams() {
            Console.WriteLine("Chose keyboard type index:");
            foreach (string item in Enum.GetNames(typeof(KeybordType))) {
                Console.WriteLine($"{Enum.Parse(typeof(KeybordType),item).GetHashCode()} - {item.ToString()}");
            }
            int result =Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public int defineLanguageParams() {
            Console.WriteLine("Chose language index:");
            foreach (string item in Enum.GetNames(typeof(Language))) {
                Console.WriteLine($"{Enum.Parse(typeof(Language), item).GetHashCode()} - {item.ToString()}");
            }
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public int defineBatteryTypeParams() {
            Console.WriteLine("Chose battery type index:");
            foreach (string item in Enum.GetNames(typeof(BatteryType)))
            {
                Console.WriteLine($"{Enum.Parse(typeof(BatteryType), item).GetHashCode()} - {item.ToString()}");
            }
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public int defineSimCardFormatParams() {
            Console.WriteLine("Chose simcard formst type index:");
            foreach (string item in Enum.GetNames(typeof(SimFormat)))
            {
                Console.WriteLine($"{Enum.Parse(typeof(SimFormat), item).GetHashCode()} - {item.ToString()}");
            }
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public int defineEnumParam(string type) {
            Console.WriteLine($"Choose {type} index:");
            type = "MobilePhone." + type;
            Type currentType = Type.GetType(type);
            object thisObjectItem = Activator.CreateInstance(currentType);
            IEnumerable enumItem = thisObjectItem as IEnumerable;
            
            foreach (string item in Enum.GetNames(thisObjectItem.GetType()))
            {
                Console.WriteLine($"{Enum.Parse(thisObjectItem.GetType(), item).GetHashCode()} - {item.ToString()}");
            }
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }


    }
}
