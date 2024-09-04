using DEPI6InstructorCRUDMVCWebAPPTask.Contexts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace DEPI6InstructorCRUDMVCWebAPPTask.Validations
{
    public class UniqueValidation : ValidationAttribute
    {
        private readonly string _propertyName;

        public UniqueValidation(string propertyName)
        {
            _propertyName = propertyName;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult($"{_propertyName} is required.");
            }

            var dbContext = (InstructorCRUDMVCAppDbContext)validationContext.GetService(typeof(InstructorCRUDMVCAppDbContext));
            var entityType = validationContext.ObjectInstance.GetType();

            var propertyInfo = entityType.GetProperty(_propertyName);

            if (propertyInfo == null)
            {
                throw new ArgumentException("Property with this name not found");
            }

            // Use reflection to get the DbSet for the entity type
            var dbSet = dbContext.GetType()
                                 .GetMethod("Set", BindingFlags.Public | BindingFlags.Instance)
                                 ?.MakeGenericMethod(entityType)
                                 .Invoke(dbContext, null) as IQueryable;

            if (dbSet == null)
            {
                throw new InvalidOperationException("Could not retrieve the DbSet for the entity type.");
            }

            // Check for uniqueness
            var exists = dbSet.Cast<object>()
                              .Any(e => propertyInfo.GetValue(e)!.Equals(value));

            if (exists)
            {
                return new ValidationResult($"{_propertyName} must be unique.");
            }

            return ValidationResult.Success;
        }
    }
}
