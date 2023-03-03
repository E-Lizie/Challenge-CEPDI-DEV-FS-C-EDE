using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.Models.Medicines
{
    public class ShowTableMedicinesModel
    {
        public ShowTableMedicinesModel()
        {
            Currentpage = 1;
            RecordPorPage = 5;
        }

        public int Currentpage { get; set; }
        public int RecordPorPage { get; set; }
    }
}
