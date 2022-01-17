﻿using UnityEngine;

namespace ODIN_Sample.Scripts.Runtime.Odin
{
    /// <summary>
    /// Scriptable object used to define a string property. This is used e.g. for defining room names or for storing the
    /// player name across different scenes.
    /// </summary>
    [CreateAssetMenu(fileName = "OdinStringVariable", menuName = "Odin-Sample/StringVariable", order = 0)]
    public class OdinStringVariable : ScriptableObject
    {
        /// <summary>
        /// The variable's string value.
        /// </summary>
        [field: SerializeField]
        public string Value { get; set; } = "default";

        public static implicit operator string(OdinStringVariable v) => v.Value;
        
        public override string ToString()
        {
            return Value;
        }
    }
}