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
        public Warehouse(Session session) : base(session) { }

        /// <summary>
        /// The name of Warehouse
        /// </summary>
        string name;
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
        Person manager;
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
        string description;
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
    }
}
