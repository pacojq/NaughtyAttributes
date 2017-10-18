// This class is auto generated

using System;
using System.Collections.Generic;

namespace NaughtyAttributes.Editor
{
    public static class DrawerDatabase
    {
        private static Dictionary<Type, PropertyDrawer> drawersByAttributeType;

        static DrawerDatabase()
        {
            drawersByAttributeType = new Dictionary<Type, PropertyDrawer>();
            drawersByAttributeType[typeof(HideIfAttribute)] = new HideIfPropertyDrawer();
drawersByAttributeType[typeof(ShowIfAttribute)] = new ShowIfPropertyDrawer();

        }

        public static PropertyDrawer GetDrawerForAttribute(Type attributeType)
        {
            PropertyDrawer drawer;
            if (drawersByAttributeType.TryGetValue(attributeType, out drawer))
            {
                return drawer;
            }
            else
            {
                return null;
            }
        }
    }
}

