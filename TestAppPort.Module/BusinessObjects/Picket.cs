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
    public class Picket : BaseObject
    {
        public Picket(Session session) : base(session) { }

        /// <summary>
        /// The Picket's number (required and identity field)
        /// </summary>
        int number;
        [RuleRequiredField("RuleRequiredField for Picket.Number",
    DefaultContexts.Save)]
        public int Number
        {
            get { return number; }
            set { SetPropertyValue(nameof(Number), ref number, value); } //method to implement the property’s setter.
        }

        ////     /// <summary>
        ////     /// The Warehouse where the Picket is registered
        ////     /// </summary>
        ////     Warehouse warehouse;
        ////     [Association]
        ////     [RuleRequiredField("RuleRequiredField for Picket.Warehouse",
        ////DefaultContexts.Save)]
        ////     public Warehouse Warehouse
        ////     {
        ////         get { return warehouse; }
        ////         set { SetPropertyValue(nameof(Warehouse), ref warehouse, value); }
        ////     }

        /// <summary>
        /// The Platform where the Picket is located
        /// </summary>
        Platform platform;
        [RuleRequiredField("RuleRequiredField for Picket.Platform",
    DefaultContexts.Save)]
        [Association]
        public Platform Platform
        {
            get { return platform; }
            set { SetPropertyValue(nameof(Platform), ref platform, value); }
        }

        private XPCollection<AuditDataItemPersistent> changeHistory;
        [CollectionOperationSet(AllowAdd = false, AllowRemove = false)]
        public XPCollection<AuditDataItemPersistent> ChangeHistory
        {
            get
            {
                if (changeHistory == null)
                {
                    changeHistory = AuditedObjectWeakReference.GetAuditTrail(Session, this);
                }
                return changeHistory;
            }
        }
    }
}

