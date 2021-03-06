﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Construct.Interaction
{
    public class InteractableCustom : MonoBehaviour
    {
        [Header("Attributes")]
        public bool throwable = false;
        public Vector3 PositionOffset;
        public Vector3 RotationOffset;
        public Vector3 ScaleOffset;

        [SerializeField]
        private int m_ID;


        public int GetID()
        {
            return m_ID;
        }
        public void SetID(int n)
        {
            m_ID = n;
        }

    }
}
