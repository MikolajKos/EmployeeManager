
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Relationship : One to many
        [JsonIgnore]
        public List<Employee>? Empoyees { get; set; }
    }
}
