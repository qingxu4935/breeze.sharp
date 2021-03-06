﻿using Breeze.Sharp.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Breeze.Sharp {

  /// <summary>
  /// Information about the result of an EntityManager.ImportEntities operation.
  /// </summary>
  public class ImportResult {

    internal ImportResult(IEnumerable<IEntity> entities, Dictionary<EntityKey, EntityKey> tempKeyMap) {
      _importedEntities = new SafeList<IEntity>(entities);
      _tempKeyMap = new ReadOnlyDictionary<EntityKey, EntityKey>(tempKeyMap);
    }

    public ReadOnlyCollection<IEntity> ImportedEntities {
      get { return _importedEntities.ReadOnlyValues;  }
    }

    public ReadOnlyDictionary<EntityKey, EntityKey> TempKeyMap {
      get { return _tempKeyMap; }
    }

    private SafeList<IEntity> _importedEntities;
    private ReadOnlyDictionary<EntityKey, EntityKey> _tempKeyMap;
  }

 
}
