using System;
using System.Text;
using System.Collections.Generic;
using Axelerate.BusinessLayerFrameWork.BLCore.Templates;
using Axelerate.BusinessLayerFrameWork.BLCore;
using Axelerate.BusinessLayerFrameWork.BLCore.Security;

namespace Axelerate.BusinessLogic.SharedBusinessLogic.Locks
{
    /// <summary>
    /// This class represents a collection of Types of Lock support
    /// <threadsafety static="true" instance="false"/>
    /// </summary>
    [Serializable(), SecurableClass(SecurableClassAttribute.SecurableTypes.CRUD)]
	public class clsPersistentLockTypes : BLListBase<clsPersistentLockTypes, clsPersistentLockType, clsPersistentLockType.BOGUIDDataKey>
    {
		#region "Factory Methods"
		#endregion

		#region "ExtendedFilters"
		#endregion
	}
}