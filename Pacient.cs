using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace MIS
{
    public class DiagnosisType
    {
        public int ID { get; set; }
        [DisplayName("Диагноз")]
        public String name { get; set; }
        [DisplayName("Описание")]
        [DataType(DataType.MultilineText)]
        public String description { get; set; }
    }
    public class Diagnosis
    {
        public int ID { get; set; }
        [DisplayName("Диагноз")]
        public DiagnosisType type { get; set; }
        [DisplayName("Комментарий")]
        [DataType(DataType.MultilineText)]
        public String comment { get; set; }

    }
    public class VisitDate
    {
        public int ID { get; set; }
        public int DoctorID {  get; set; }
        [DisplayName("Дата приёма")]
        public DateTime date { get; set; }
    }
    public class Pacient
    {

    }
}
