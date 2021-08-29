using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers_HW
{
    class TempMeasure : IComparable<TempMeasure>
    {
        public string City { get; set; }
        public int Date { get; set; }
        public float Degrees { get; set; }
        public int Humidity { get; set; }

        public TempMeasure(string city, int date, float degrees, int humidity)
        {
            City = city;
            Date = date;
            Degrees = degrees;
            Humidity = humidity;
        }

        public override string ToString()
        {
            return $"{City} day: {Date}, {Degrees} celsius, {Humidity} humidity";
        }

        public int CompareTo(TempMeasure other)
        {
            if (Humidity.CompareTo(other.Humidity) != 0)
                if (Degrees.CompareTo(other.Degrees) != 0)
                    if (City.CompareTo(other.City) == 0)
                        return City.CompareTo(other.City);

            if (Humidity.CompareTo(other.Humidity) != 0)
                if (Degrees.CompareTo(other.Degrees) != 0)
                    return Degrees.CompareTo(other.Degrees) * -1;

            return Humidity.CompareTo(other.Humidity);
        }
    }
}
