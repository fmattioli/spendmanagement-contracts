namespace SpendManagement.Contracts.V1.Entities
{
    public class Category
    {
        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
            CreatedDate = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
