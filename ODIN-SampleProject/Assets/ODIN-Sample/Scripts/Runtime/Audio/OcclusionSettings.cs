﻿using UnityEngine;
using UnityEngine.Serialization;

namespace ODIN_Sample.Scripts.Runtime.Audio
{
    [CreateAssetMenu(fileName = "OcclusionSettings", menuName = "Odin-Sample/OcclusionSettings", order = 0)]
    public class OcclusionSettings : ScriptableObject
    {
        [Header("Automatic Occlusion")]
        public float audioSourceDetectionRange = 100.0f;
        public LayerMask audioSourceDetectionLayer = ~0;
        /// <summary>
        /// Maps from the thickness of colliders between the Audio listener and a Source to the Cutoff Frequency used
        /// in the lowpass filter.
        /// </summary>
       public AnimationCurve occlusionCurve;

    }
    
    
}