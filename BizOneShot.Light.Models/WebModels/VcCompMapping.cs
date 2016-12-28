// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;

namespace BizOneShot.Light.Models.WebModels
{
    // VC_COMP_MAPPING
    public class VcCompMapping
    {
        public string CpMpCode { get; set; } // CP_MP_CODE
        public int CompSn { get; set; } // COMP_SN
        public int BaSn { get; set; } // BA_SN
        public string NumSn { get; set; } // NUM_SN
        public string SubNumSn { get; set; } // SUB_NUM_SN
        public string ConCode { get; set; } // CON_CODE
        public string TypeYn { get; set; } // TYPE_YN
        public string WriteYn { get; set; } // WRITE_YN
        public DateTime? RegDt { get; set; } // REG_DT
        public DateTime? UpdDt { get; set; } // UPD_DT
    }

}
