using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Battery
    {
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;
        public Battery(string model)
        {
            this.model = model;
        }
        public Battery(string model, BatteryType type)
            : this(model, 0, 0, type)
        {
            this.type = type;
        }
        public Battery(string model, int idleH, int talkH, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = idleH;
            this.hoursTalk = talkH;
            this.type = type;
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Please type some info.");
                }
                this.model = value;
            }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cant be lower then Zero.");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cant be lower then Zero.");
                }
                this.hoursTalk = value;
            }
        }
    }
}
