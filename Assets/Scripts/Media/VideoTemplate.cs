﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace VRControlls.Media
{

}
[CreateAssetMenu(menuName = "VR Media/New Video")]
public class VideoTemplate : ScriptableObject
{

    public string VideoName;
    public VideoClip Video;

}
