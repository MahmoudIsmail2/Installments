using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstallments_App.Classes
{
    public class InstallmentDetails
    {
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public decimal ItemPurchasePrice { get; set; }
        public int? InstallmentPeriodType { get; set; }
        public int NumberOfInstallments { get; set; }
        public decimal InstallmentValue { get; set; }
        public decimal ProviderValue { get; set; }
        public DateTime InstallmentExpirayDate { get; set; }

     
    }
}
