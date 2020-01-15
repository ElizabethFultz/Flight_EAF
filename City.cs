using System;
using System.Collections.Generic;
using System.Text;

/**
 * This class represents a City with
 * a name, lat and long.
 * @author Rob Kelley
 * @version 1.0;
 * Lab04 - Solution
 * SP19
 */

namespace Flight_EAF
{
    class City
    {
		private readonly String name;
		private readonly double latitude;
		private readonly double longitude;

		/**
		 * Empty-argument constructor to put 
		 * object into a consistent state.
		 */
		private City()
		{
			name = "";
			latitude = 0.0;
			longitude = 0.0;
		}//end constructor

		/**
		 * Constructor to instantiate the object.
		 * @param name
		 * @param latitude
		 * @param longitude
		 */
		public City(String name, double latitude, double longitude)
		{
			this.name = name;
			this.latitude = latitude;
			this.longitude = longitude;
		}//end constructor

		/**
		 * Getter for name
		 * @return
		 */
		public String GetName()
		{
			return name;
		}//end GetName

		/**
		 * Getter for latitude
		 * @return
		 */
		public double GetLatitude()
		{
			return latitude;
		}//end GetName

		/**
		 * Getter for longitude
		 * @return
		 */
		public double GetLongitude()
		{
			return longitude;
		}//end GetLongitude

		public override String ToString()
			{
				return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
			}
	}
}
