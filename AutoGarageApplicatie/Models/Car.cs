namespace AutoGarageApplicatie.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Brand { get; set; }

        public string? Color { get; set; }

        public Owner? Owner { get; set; }

        public int OwnerId { get; set; }
    }
}
