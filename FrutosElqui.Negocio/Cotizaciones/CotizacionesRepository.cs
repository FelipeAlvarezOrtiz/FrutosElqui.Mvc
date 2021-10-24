using FrutosElqui.Core.Cotizaciones;
using MongoDB.Driver;

namespace FrutosElqui.Negocio.Cotizaciones
{
    public class CotizacionesRepository
    {
        private const string collectionName = "Cotizaciones";

        private readonly IMongoCollection<Cotizacion> dbCollection;
        private readonly FilterDefinitionBuilder<Cotizacion> filterBuilder = Builders<Cotizacion>.Filter;

        public CotizacionesRepository()
        {
            var mongoCliente = new MongoClient("mongodb://localhost:27017");
            var database = mongoCliente.GetDatabase("FrutosElqui");
            dbCollection = database.GetCollection<Cotizacion>(collectionName);
        }


    }
}
