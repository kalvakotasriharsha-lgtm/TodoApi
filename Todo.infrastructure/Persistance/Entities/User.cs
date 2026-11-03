namespace Todo.infrastructure.Persistance.Entities
{
    public class User: BaseAuditableEntity                              //Table name in the database is Users

   {
        public string FullName { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }

    }


}
