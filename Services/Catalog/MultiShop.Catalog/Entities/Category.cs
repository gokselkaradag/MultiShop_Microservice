using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities;

public class Category
{
    [BsonId] // Veritabanında "_id" olarak görünür.
    [BsonRepresentation(BsonType.ObjectId)] // Uygulamaya ID olduğunu belirtir.
    public string CategoryId { get; set; }
    public string CategoryName { get; set; }
}