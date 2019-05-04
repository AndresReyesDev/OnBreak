using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OnBreak.Business
{
    public enum BusinessType : byte
    {
        [Description("SPA")]
        SPA = 1,
        [Description("EIRL")]
        EIRL = 2,
        [Description("Limitada")]
        Limitada = 3,
        [Description("Sociedad Anónima")]
        SociedadAnonima = 4
    }
}
