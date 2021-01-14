using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lr1.Models
{
    public class DTP
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Price { get; set; }
        public virtual ICollection<PDR> Pdrs { get; set; }
        
    }
    public class DTPPropertyValidator : ModelValidator
    {
        public DTPPropertyValidator(ModelMetadata metadata, ControllerContext context)
            : base(metadata, context)
        { }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            DTP d = container as DTP;
            if (d != null)
            {
                switch (Metadata.PropertyName)
                {
                    case "Name":
                        if (string.IsNullOrEmpty(d.Name))
                        {
                            return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="Name", Message="Введіть назву ДТП"}
                        };
                        }
                        break;
                    case "Type":
                        if (string.IsNullOrEmpty(d.Type))
                        {
                            return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="Type", Message="Введіть тип"}
                        };
                        }
                        break;
                    case "Price":
                        if (d.Price > 2000 || d.Price < 50)
                        {
                            return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="Price", Message="Введіть ціну"}
                        };
                        }
                        break;
                }
            }
            return Enumerable.Empty<ModelValidationResult>();
        }
    }
    public class MyValidationProvider : ModelValidatorProvider
    {
        public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context)
        {
            if (metadata.ContainerType == typeof(DTP))
            {
                return new ModelValidator[] { new DTPPropertyValidator(metadata, context) };
            }

            if (metadata.ModelType == typeof(DTP))
            {
                return new ModelValidator[] { new DTPValidator(metadata, context) };
            }

            return Enumerable.Empty<ModelValidator>();
        }
    }

    public class DTPValidator : ModelValidator
    {
        public DTPValidator(ModelMetadata metadata, ControllerContext context)
            : base(metadata, context)
        { }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            DTP d = (DTP)Metadata.Model;

            List<ModelValidationResult> errors = new List<ModelValidationResult>();

            if (d.Name == "Наїзд на нерухомий транспортний засіб" && d.Type == "Аварія" && d.Price == 1900)
            {
                errors.Add(new ModelValidationResult { MemberName = "", Message = "Створіть інше ДТП!" });
            }
            return errors;
        }
    }
}