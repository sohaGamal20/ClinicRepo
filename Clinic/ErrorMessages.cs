using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public static class ErrorMessages
    {
        public static string patientID = "الرقم المرجعى: ";
        public static string patientName = "أسم المريض: ";

        public static string catchException = "failed due to forementioned exception ";

        public static string addedPatientInfo_ar = "تم اضافة المريض بنجاح ";
        public static string updatePatientInfo_ar = "تم تعديل البيانات بنجاح";

        public static string Medication = "كشف";
        public static string consultation = "استشارة";

        public static string visitAdded = "تم الاضافة بنجاح";
        public static string failedToAdd = "حدث خطأ فى الادخال";
        public static string failedToAdd_en = "Failed to Add";

        public static string unspecifiedaPatient = "failed to add due to unspecified patient";
        public static string failedToAddConsultation = "  لا يمكن حجز استشارة بسبب تعدى الفترة المسموحة ( 10 ايام) ";
        public static string failedToAddConsultationSameDayError = "لا يمكن اضافة استشارة لحجز موجود فى نفس اليوم";


    }
}
