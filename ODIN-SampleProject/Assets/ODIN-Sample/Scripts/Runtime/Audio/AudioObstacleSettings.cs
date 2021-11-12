﻿using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace ODIN_Sample.Scripts.Runtime.Audio
{
    [CreateAssetMenu(fileName = "AudioObstacle", menuName = "Odin-Sample/AudioObstacle", order = 0)]
    public class AudioObstacleSettings : ScriptableObject
    {
        [FormerlySerializedAs("data")] [FormerlySerializedAs("lowpass")] public AudioObstacleEffect effect;
    }
}