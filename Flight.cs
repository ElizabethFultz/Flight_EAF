using System;
using System.Collections.Generic;
using System.Text;

/**
 * This object represents a flight
 * @author Rob Kelley
 * @version 1.0
 * Lab04 - Solution
 * SP19
 */

namespace Flight_EAF
{
    class Flight
    {

		private String airLineName;
		private City originCity;
		private City destinationCity;
		private String flightNumber;

		/**
		 * Empty-argument constructor to put 
		 * the object into a consistent state.
		 */
		public Flight()
		{
			airLineName = null;
			originCity = null;
			destinationCity = null;
			flightNumber = null;
		}//end constructor

		/**
		 * Preferred constructor for this object
		 * @param aln - airline number
		 * @param fn - flight number
		 * @param o - origin city
		 * @param d - destination city
		 */
		public Flight(String aln, String fn, City o, City d)
		{

			SetAirLineName(aln);
			SetFlightNumber(fn);
			SetOriginCity(o);
			SetDestinationCity(d);

		}//end constructor

		/**
		 * Method uses the haversine formulae
		 * to calculate the distance around the 
		 * globe from one city to another.
		 * @return - distance in miles
		 */
		public double CalcDistanceToFly()
		{

			double R = 6371000;
			double lat1 = originCity.GetLatitude();
			double lat2 = destinationCity.GetLatitude();
			double lon1 = originCity.GetLongitude();
			double lon2 = destinationCity.GetLongitude();

			double lat1Radians = (Math.PI/180.0)*lat1;
			double lat2Radians = (Math.PI/180.0)*lat2;
			double lon1Radians = (Math.PI/180.0)*lon1;
			double lon2Radians = (Math.PI/180.0)*lon2;

			double deltaLat = (Math.PI/180.0)*(lat2 - lat1);
			double deltaLon = (Math.PI/180.0)*(lon2 - lon1);

			double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos(lat1Radians) * Math.Cos(lat2Radians) * Math.Pow(Math.Sin(deltaLon / 2), 2);

			double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

			double distance = R * c;

			return distance * 0.000621371;
		}//end 

		/**
		 * This method will return all of the flight
		 * details including the airline, flight number,
		 * and distance between two city objects.
		 * @return -String representing the flight details
		 */
		public String PrintFlightDetails()
		{ 

			StringBuilder sb = new StringBuilder();

			sb.Append(airLineName + " " + flightNumber + "\n");
			sb.Append(originCity.GetName() + " to " + destinationCity.GetName() + "\n");
			sb.Append("Distance: " + Math.Round(this.CalcDistanceToFly(),3) + " miles.\n");

			return sb.ToString();
		}//end PrintFlightDetails

		/**
		 * getter for airLineName
		 * @return
		 */
		public String GetAirLineName() 
		{
			return airLineName;
		}//end GetAirline

		/**
		 * Setter for airLineName
		 * @param airLineName
		 */
		public void SetAirLineName(String airLineName)
		{
			this.airLineName = airLineName;
		}//end SetAirLineName

		/**
		 * Getter for flightNumber
		 * @return
		 */
		public String GetFlightNumber()
		{
			return flightNumber;
		}//end GetFlightNumber

		/**
		 * Setter for flightNumber
		 * @param flightNumber
		 */
		public void SetFlightNumber(String flightNumber)
		{
			this.flightNumber = flightNumber;
		}//end SetFlightNumber

		/**
		 * Getter for originCity
		 * @return
		 */
		public City GetOriginCity()
		{
			return originCity;
		}//end GetOriginCity

		/**
		 * Setter for originCity
		 * @param originCity
		 */
		public void SetOriginCity(City originCity)
		{
			this.originCity = originCity;
		}//end SetOriginCity

		/**
		 * Getter for destinationCity
		 * @return
		 */
		public City GetDestinationCity()
		{
			return destinationCity;
		}//end GetDestinationCity

		/**
		 * Setter for destinationCity
		 * @param destinationCity
		 */
		public void SetDestinationCity(City destinationCity)
		{
			this.destinationCity = destinationCity;
		}//end SetDestinationCity

		public override String ToString()
			{
				return "Flight [airLineName=" + airLineName + ", originCity=" + originCity + ", destinationCity="
						+ destinationCity + ", flightNumber=" + flightNumber + "]";
			}//end toString

	}
}
