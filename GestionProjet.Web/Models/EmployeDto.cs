namespace GestionProjet.Web.Models
{
    public class EmployeDto
    {
        //employeId ferstName lastname gender description salair iamageURL
        public int EmployeId { get; set; }
        
        public string firstName { get; set; }

        public string lasttName { get; set; }

        public string gender { get; set; }

        public string description { get; set; }

        public double salaire { get; set; }
        public string ImageURL { get; set; }
        public bool isSuccess { get; internal set; }
    }
}
