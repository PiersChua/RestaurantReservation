namespace RestaurantReservation.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string AddressesEndpoint = $"{Prefix}/addresses";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string FavouritesEndpoint = $"{Prefix}/favourites";
        public static readonly string MenusEndpoint = $"{Prefix}/menus";
        public static readonly string OperatingHoursEndpoint = $"{Prefix}/operatinghours";
        public static readonly string PaymentMethodsEndpoint = $"{Prefix}/paymentmethods";
        public static readonly string PromotionsEndpoint = $"{Prefix}/promotions";
        public static readonly string ReservationsEndpoint = $"{Prefix}/reservations";
        public static readonly string ReservationStatusesEndpoint = $"{Prefix}/reservationstatuses";
        public static readonly string RestaurantsEndpoint = $"{Prefix}/restaurants";
        public static readonly string RestaurantApplicationsEndpoint = $"{Prefix}/restaurantapplications";
        public static readonly string RestaurantOwnersEndpoint = $"{Prefix}/restaurantowners";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string SeatingCapacitiesEndpoint = $"{Prefix}/seatingcapacities";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string SubscriptionsEndpoint = $"{Prefix}/subscriptions";
    }
}
