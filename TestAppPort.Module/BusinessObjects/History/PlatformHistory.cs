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
    class PlatformHistory : BaseObject
    {
        #region fields
        //Guid _oid;
        DateTime _dateOfNote;
        Platform _platform;
        #endregion fields

        #region constructors

        #endregion constructors

        #region properties
        /// <summary>
        /// The History note's Id (required and identity field)
        /// </summary>
        //    [RuleRequiredField("RuleRequiredField for Picket.Number",
        //DefaultContexts.Save)]
        //    public Guid Id
        //    {
        //        get { return _oid; }
        //    }

        /// <summary>
        /// Date of the history note
        /// </summary>
        [RuleRequiredField("RuleRequiredField for Picket.Number",
    DefaultContexts.Save)]
        public DateTime DateOfNote
        {
            get { return _dateOfNote; }
            set { SetPropertyValue(nameof(_dateOfNote), ref _dateOfNote, value); } //method to implement the property’s setter.
        }

        /// <summary>
        /// Platform
        /// </summary>
        [Association]
        [RuleRequiredField("RuleRequiredField for Picket.Number",
    DefaultContexts.Save)]
        public Platform Platform
        {
            get { return _platform; }
            set { SetPropertyValue(nameof(_platform), ref _platform, value); } //method to implement the property’s setter.
        }

        /// <summary>
        /// Picket on platform
        /// </summary>
        [Association]
        [RuleRequiredField("RuleRequiredField for Picket.Number",
    DefaultContexts.Save)]
        public XPCollection<PicketInPlatformHistory> PicketsInPlatformHistory
        {
            get { return GetCollection<PicketInPlatformHistory>(nameof(PicketsInPlatformHistory)); }
        }

        #endregion properties

        #region 

        #endregion
    }
}
