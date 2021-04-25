using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollectionApp.Model
{
    public class LoanInformation
    {
        public int Id { get; set; }
        public DateTime LoadDate { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowerEmail { get; set; }
    }
}
