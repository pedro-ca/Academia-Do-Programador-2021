﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryControlModel
{
    class MaintenanceCall
    {
        private string titleName;
        private string descriptioName;
        private Equipment equipment;
        private DateTime openingDate;

        public string TitleName { get => titleName; set => titleName = value; }
        public string DescriptioName { get => descriptioName; set => descriptioName = value; }
        public Equipment Equipment { get => equipment; set => equipment = value; }
        public DateTime OpeningDate { get => openingDate; set => openingDate = value; }
    }
}
