namespace learningDependencyInjection.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateOnly CreatedDate { get; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
