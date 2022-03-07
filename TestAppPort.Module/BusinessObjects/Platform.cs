﻿using DevExpress.ExpressApp;
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
    /// Port class
    /// </summary>
    [NavigationItem("Port")]
    public class Platform : BaseObject
    {
        public Platform(Session session) : base(session) { }

        /// <summary>
        /// Name of the Platform
        /// </summary>
        string name;
        [RuleRequiredField("RuleRequiredField for Platform.Name",
    DefaultContexts.Save)]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }

        /// <summary>
        /// The cargo that is on the Platform
        /// </summary>
        float cargo;
        [RuleRequiredField("RuleRequiredField for Platform.Cargo",
    DefaultContexts.Save)]
        public float Cargo
        {
            get { return cargo; }
            set { SetPropertyValue(nameof(Cargo), ref cargo, value); }
        }

        /// <summary>
        /// The Warehouse where the Platform is located
        /// </summary>
        Warehouse warehouse;
        [Association]
        [RuleRequiredField("RuleRequiredField for Platform.Warehouse",
    DefaultContexts.Save)]
        public Warehouse Warehouse
        {
            get { return warehouse; }
            set { SetPropertyValue(nameof(Warehouse), ref warehouse, value); }
        }

        /// <summary>
        /// Pickets that are located in the Platform
        /// </summary>
        [Association]
        //    [RuleRequiredField("RuleRequiredField for Platform.Pickets",
        //DefaultContexts.Save)]
        public XPCollection<Picket> Pickets
        {
            get { return GetCollection<Picket>(nameof(Pickets)); }
        }
    }
}
