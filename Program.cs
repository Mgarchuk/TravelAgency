using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.Adapter_pattern;


namespace Travel_agency
{
    static class Program
    {
        public static string client_login;
        public static List<Tour> active_tours_list = new List<Tour>();
        public static List<Tour> beach_tours_list = new List<Tour>();
        public static List<Country> countries = new List<Country>();
        public static int color = 1;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Transport Train = new Transport(TRANSPORT_TYPE.TRAIN, 0.15, 4.9);
            Transport Bus = new Transport(TRANSPORT_TYPE.BUS, 0.2, 4.9);
            Transport Airplane = new Transport(TRANSPORT_TYPE.AIRPLANE, 0.3, 4.9);
            Transport Car = new Transport(TRANSPORT_TYPE.CAR, 0.6, 4.9);

            Hotel Magma = new Hotel("Magma", 4, 23, 4.3);
            Hotel Sunfy = new Hotel("Sunfy", 4, 23, 4.2);

            Country Korea = new Country("Korea", "Seoul",  false, true);
            Country Portugal = new Country("Portugal", "Lisboa", true, false);
            Country Spain = new Country("Spain", "Madrid", true, false);
            Country Hungary = new Country("Hungary", "Budapesht", true, false);
            Country France = new Country("France", "Paris", true, false);
            Country Germany = new Country("Germany", "Berlin", true, false);



            countries.Add(Korea);
            countries.Add(Portugal);
            countries.Add(Spain);
            countries.Add(Hungary);
            countries.Add(France);
            countries.Add(Germany);

            active_tours_list.Add(new Active_Tour("Paris"));
            active_tours_list.Add(new Active_Tour("Budapest"));
            active_tours_list.Add(new Active_Tour("Berlin"));
            active_tours_list.Add(new Active_Tour("Seoul"));
            active_tours_list.Add(new Active_Tour("Madrid"));

            beach_tours_list.Add(new Beach_Tour("Madrid"));
            beach_tours_list.Add(new Beach_Tour("Lisbon"));


            /*
            Tour Korea_tour = new Tour(Magma, Korea, 7460, 12);
            Tour France_tour = new Tour(Sunfy, France, 1986, 4);
            Tour Germany_tour = new Tour(Sunfy, Germany, 1195, 5);
            Tour Portugal_tour = new Tour(Magma, Portugal, 3122, 9);
            Tour Hungary_tour = new Tour(Sunfy, Hungary, 1117, 6);
            Tour Spain_tour = new Tour( Sunfy, Spain, 3400, 9);

            tours.Add(Korea_tour);
            tours.Add(France_tour);
            tours.Add(Spain_tour);
            tours.Add(Hungary_tour);
            tours.Add(France_tour);
            tours.Add(Germany_tour);

            */

            Tour tour = new Tour();
            Hotel hotel = new Hotel();

            tour.Set_country(Korea);
            hotel.Set_title("Mjj");

            // сначала отель(временно)
            tour.Get(hotel);

            // страна(для дальнейшего)
            Country country = new Country();

            // используем адаптер
            IHotel country_adapted = new Country_to_hotel_adapter(country);

            // используем страну как отель
            tour.Get(country_adapted);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
