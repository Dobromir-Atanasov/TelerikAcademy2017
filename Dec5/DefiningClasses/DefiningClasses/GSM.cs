using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class GSM
    {
        public static GSM iphone4s = new GSM("iPhone4s", "Apple", 100, "Gosho", new Battery("Iphone 4 battery 2000 mw", Battery.BatteryType.LiIon), new Display(4, 256));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        public Battery battery;
        public Display display;

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, string.Empty, new Battery("Unknown"), new Display(0,0))
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, string.Empty, new Battery("Unknown"), new Display(0,0))
        {
            this.price = price;
        }
        public GSM(string model, string manufacturer, string owner) :
            this(model, manufacturer, 0, owner, new Battery("Unknown"), new Display(0,0))
        {
            this.owner = owner;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name can't be empty!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name too long! Use up to 50 chars.");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Model can't be empty!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Model name too long! Use up to 50 chars.");
                }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cant drop below Zero! What are you doing?");
                }
                if (value > 1000000)
                {
                    throw new ArgumentException("A bit too expensive");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Are this only initials?");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Please, cut few chars! No name longer then 50 chars!");
                }
                this.owner = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------- GSM ---------");
            sb.AppendLine("Model: "+Model);
            sb.AppendLine("Manufacturer: "+Manufacturer);
            sb.AppendLine("Price: "+this.price.ToString("N2"));
            sb.AppendLine("Owner: "+owner);
            sb.AppendLine("Battery: --------------");
            sb.AppendLine("Model: " + battery.Model);
            sb.AppendLine("Display: --------------");
            sb.AppendLine("Size: " + display.Size);
            sb.AppendLine("Colors: " + display.NumberOfColors);
            return sb.ToString();
        }
    }
}
