namespace Facade
{
    class SkiResortFacade
    {
        private SkiRent _skiRent = new SkiRent();
        private SkiResortTicketSystem _skiResortTicketSystem = new SkiResortTicketSystem();
        private HotelBookingSystem _hotelBookingSystem = new HotelBookingSystem();

        public int HaveGoodRest(int height, int weight, int feetSize, int skierLevel, int roomQuality)
        {
            int skiPrice = _skiRent.RentSki(weight, skierLevel);
            int skiBootsPrice = _skiRent.RentBoots(feetSize, skierLevel);
            int polePrice = _skiRent.RentPole(height);
            int oneDayTicketPr = _skiResortTicketSystem.BuyOneDayTicket();
            int hotelPrice = _hotelBookingSystem.BookRoom(roomQuality);
            return skiPrice + skiBootsPrice + polePrice + oneDayTicketPr + hotelPrice;
        }

        public int HaveRestWithOwnSkis()
        {
            int oneDayTicketPrice = _skiResortTicketSystem.BuyOneDayTicket();
            return oneDayTicketPrice;
        }
    }
}
