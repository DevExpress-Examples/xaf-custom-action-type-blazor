using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.XtraRichEdit.Import.OpenXml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dxTestSolution.Module.BusinessObjects;
[DefaultClassOptions]
public class Order : BaseObject {
    public virtual string OrderNo { get; set; }
    public virtual DateTime Date { get; set; }
    public virtual bool Active { get; set; }


}


