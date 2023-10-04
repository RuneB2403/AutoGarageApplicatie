namespace AutoGarageApplicatie.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<Car>? Cars { get; set; }
    }
}
