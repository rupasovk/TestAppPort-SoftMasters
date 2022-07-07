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
    /// Warehouse class
    /// </summary>
    [NavigationItem("Port")]
    public class Warehouse : BaseObject
    {
        #region fields
        
        string name;
        Person manager;
        string description;

        #endregion fields

        #region constructors
        public Warehouse(Session session) : base(session) { }
        #endregion constructors

        #region properties

        /// <summary>
        /// The name of Warehouse
        /// </summary>
        [RuleRequiredField("RuleRequiredField for Warehouse.Name",
    DefaultContexts.Save)]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }

        /// <summary>
        /// The manager who manages the Warehouse
        /// </summary>
        [RuleRequiredField("RuleRequiredField for Warehouse.Manager",
    DefaultContexts.Save)]
        public Person Manager
        {
            get { return manager; }
            set { SetPropertyValue(nameof(Manager), ref manager, value); }
        }

        /// <summary>
        /// Description of the Warehouse
        /// </summary>
        [Size(SizeAttribute.Unlimited)]
        [RuleRequiredField("RuleRequiredField for Warehouse.Description",
    DefaultContexts.Save)]
        public string Description
        {
            get { return description; }
            set { SetPropertyValue(nameof(Description), ref description, value); }
        }

        /// <summary>
        /// Platforms that are located in the Warehouse
        /// </summary>
        [Association]
        //    [RuleRequiredField("RuleRequiredField for Warehouse.Platforms",
        //DefaultContexts.Save)]
        public XPCollection<Platform> Platforms
        {
            get { return GetCollection<Platform>(nameof(Platforms)); }
        }

        /// <summary>
        /// Pickets that are located in the Warehouse
        /// </summary>
        [Association]
        //    [RuleRequiredField("RuleRequiredField for Warehouse.Platforms",
        //DefaultContexts.Save)]
        public XPCollection<Picket> Pickets
        {
            get { return GetCollection<Picket>(nameof(Pickets)); }
        }
        #endregion properties

    }
}
