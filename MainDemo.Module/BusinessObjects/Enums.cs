using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDemo.Module.BusinessObjects
{
    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };
    public enum Priority
    {
        [ImageName("State_Priority_Low")]
        Low,
        [ImageName("State_Priority_Normal")]
        Normal,
        [ImageName("State_Priority_High")]
        High
    }
}
