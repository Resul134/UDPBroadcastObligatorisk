using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class Meassurements
    {
        private int _id;
        private double _pressure;
        private double _humdity;
        private double _temperature;
        private DateTime _timestamp;


        public Meassurements()
        {
        }

        public Meassurements(int id, double pressure, double humdity, double temperature, DateTime timestamp)
        {
            _id = id;
            _pressure = pressure;
            _humdity = humdity;
            _temperature = temperature;
            _timestamp = timestamp;
        }


        public DateTime TimeStamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public double Humdity
        {
            get { return _humdity; }
            set { _humdity = value; }
        }

        public double Pressure
        {
            get { return _pressure; }
            set { _pressure = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return $"{nameof(TimeStamp)}: {TimeStamp}, {nameof(Temperature)}: {Temperature}, {nameof(Humdity)}: {Humdity}, {nameof(Pressure)}: {Pressure}, {nameof(Id)}: {Id}";
        }
    }
}
