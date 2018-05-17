using System;
using System.Linq;
using System.Collections.Generic;

namespace SharedTypes.Watchers.RegistryWatcherTypes
{
    [Serializable]
    public class RegistryChangedObject : IEquatable<RegistryChangedObject>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string OriginalValue { get; set; }

        public bool Equals(RegistryChangedObject other)
        {
            return ((this.Key == other.Key) && (this.Value == other.Value));
        }
    }

    public static class RegistryKeyValueObjectExtensions
    {
        public static IEnumerable<RegistryChangedObject> Except(this List<RegistryChangedObject> keyValueObjects, IEnumerable<RegistryChangedObject> keyValues)
        {
            foreach (RegistryChangedObject keyValueObject in keyValueObjects)
            {
                if (!keyValues.Contains(keyValueObject))
                {
                    // Find orginal value from second list
                    string orgValue = keyValues.FirstOrDefault(w => w.Key == keyValueObject.Key)?.Value;
                    keyValueObject.OriginalValue = string.IsNullOrEmpty(orgValue) ? string.Empty : orgValue;

                    yield return keyValueObject;
                }
            }
        }
    }
}
