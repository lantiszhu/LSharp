﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine
{
    public sealed class GameObject
    {
        Dictionary<string, Component> component = new Dictionary<string, Component>();
        public GameObject()
        {
            component["trans"] = new Transform();
        }
        public void Destory()
        {
            component.Clear();
        }
        public Transform transform
        {
            get
            {
                return component["trans"] as Transform;
            }
        }
        public static void Destory(GameObject obj)
        {
            obj.Destory();
        }

    }
    public class Component
    {

    }
    public class Transform:Component
    {
        public Transform()
        {

        }
    }
}
