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
    class PicketInPlatformHistory : BaseObject
    {
        #region fields
        PlatformHistory _platformHistory;
        Picket _picket;
        #endregion fields

        #region constructors
        #endregion constructors

        #region properties
        /// <summary>
        /// PlatformHistory
        /// </summary>
        [Association]
        [RuleRequiredField("RuleRequiredField for Picket.Number",
    DefaultContexts.Save)]
        public PlatformHistory Platform
        {
            get { return _platformHistory; }
            set { SetPropertyValue(nameof(_platformHistory), ref _platformHistory, value); } //method to implement the property’s setter.
        }
        #endregion properties

    }
}
