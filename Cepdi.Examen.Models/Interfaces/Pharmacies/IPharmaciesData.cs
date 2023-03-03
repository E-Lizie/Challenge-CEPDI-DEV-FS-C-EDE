using Cepdi.Models.Models.Pharmacies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.Interfaces.Pharmacies
{
    public  interface IPharmaciesData
    {
        PharmaciesModel Get(int id);
    }
}
