using System.Data.Entity;
using Infra.Clinic.Entity;
namespace ClinicDB
{
    public class ClinicCustomDBInitializer:DropCreateDatabaseAlways<ContextDB>
    {
        protected override void Seed(ContextDB context)
        {
            //**************Discounts***********************
            IList<DiscountLookup> discounts = new List<DiscountLookup>();
            discounts.Add(new DiscountLookup() { Agency = "nkabt mohndsen", DiscountPercentage = 25 });
            discounts.Add(new DiscountLookup() { Agency = "nkabt atba2", DiscountPercentage = 20 });
            discounts.Add(new DiscountLookup() { Agency = "nkabt siadla", DiscountPercentage = 25 });
            context.Discounts.AddRange(discounts);

            //**************Treatments***********************
            IList<TreatmentLookup> treatment = new List<TreatmentLookup>();
            treatment.Add(new TreatmentLookup() { Treatment = "treatment 1" });
            treatment.Add(new TreatmentLookup() { Treatment = "treatment 2" });
            treatment.Add(new TreatmentLookup() { Treatment = "treatment 3" });
            context.Treatments.AddRange((IEnumerable<Treatment>)treatment);

            base.Seed(context);
        }
    }
}
