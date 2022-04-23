using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppPort.Module.BusinessObjects
{
    /// <summary>
    /// Picket class
    /// </summary>
    [NavigationItem("Port")]
    public class Picket : BaseObject
    {
        #region fields
        int number;
        Warehouse warehouse;
        Platform platform;
        #endregion fields

        #region properties
        /// <summary>
        /// The Picket's number (required and identity field)
        /// </summary>
        [RuleRequiredField("RuleRequiredField for Picket.Number",
    DefaultContexts.Save)]
        public int Number
        {
            get { return number; }
            set { SetPropertyValue(nameof(Number), ref number, value); } //method to implement the property’s setter.
        }

        /// <summary>
        /// The Warehouse where the Picket is registered
        /// </summary>
        [Association]
        [RuleRequiredField("RuleRequiredField for Picket.Warehouse",
   DefaultContexts.Save)]
        public Warehouse Warehouse
        {
            get { return warehouse; }
            set { SetPropertyValue(nameof(Warehouse), ref warehouse, value); }
        }

        /// <summary>
        /// The Platform where the Picket is located
        /// </summary>
        //[RuleRequiredField("RuleRequiredField for Picket.Platform",
    //DefaultContexts.Save)]
        [Association]
        public Platform Platform
        {
            get { return platform; }
            set { SetPropertyValue(nameof(Platform), ref platform, value); }
        }

        #endregion properties

        #region constructors
        public Picket(Session session) : base(session) { }
        #endregion constructors

        #region methods
        #endregion methods

        //private XPCollection<AuditDataItemPersistent> changeHistory;
        //[CollectionOperationSet(AllowAdd = false, AllowRemove = false)]
        //public XPCollection<AuditDataItemPersistent> ChangeHistory
        //{
        //    get
        //    {
        //        if (changeHistory == null)
        //        {
        //            changeHistory = AuditedObjectWeakReference.GetAuditTrail(Session, this);
        //        }
        //        return changeHistory;
        //    }
        //}
    }
}

