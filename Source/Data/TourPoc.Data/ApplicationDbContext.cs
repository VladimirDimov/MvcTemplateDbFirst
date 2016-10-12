namespace TourPoc.Data
{
    using System.Data.Entity.Validation;
    using System.Diagnostics;

    public class ApplicationDbContext : TourPocDbFirstEntities
    {
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw new DbEntityValidationException();
            }
        }
    }
}
