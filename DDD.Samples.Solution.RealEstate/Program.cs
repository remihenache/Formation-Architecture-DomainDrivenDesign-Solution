using DDD.Samples.Solution.RealEstate.Adapters;
using DDD.Samples.Solution.RealEstate.Property;
using DDD.Samples.Solution.RealEstate.ValueObjects;

namespace DDD.Samples.Solution.RealEstate
{
    // Entité racine de l'agrégat


    class Program
    {
        static async Task Main(string[] args)
        {
            IPropertyRepository propertyRepository = new FakePropertyRepository();
            PropertyFactory propertyFactory = new FakePropertyFactory();
            try
            {
                // Créer un nouveau bien immobilier
                Property.Property property = propertyFactory.CreateProperty("123 Main St, Anytown", new Money(300000, "EUR"));
                
                Console.WriteLine($"Nouveau bien créé à l'adresse : {property.Address} avec un prix demandé de {property.AskingPrice.Amount} {property.AskingPrice.Currency}");

                // Ajouter une offre sur le bien immobilier
                var offerAmount = new Money(290000, "EUR");
                property.AddOffer(offerAmount);

                Console.WriteLine($"Offre ajoutée sur le bien à {property.Address} : {offerAmount} {offerAmount.Currency}");

                // Finaliser la transaction (simulant l'acceptation de l'offre la plus élevée)
                property.FinalizeTransaction();
                Console.WriteLine("Transaction finalisée.");

                await propertyRepository.SaveProperty(property);
                // Note : Dans une application réelle, les événements de domaine émis lors de l'acceptation de l'offre ou de la finalisation de la transaction devraient être gérés par un système de gestion d'événements.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
