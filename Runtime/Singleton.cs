using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{

    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {

        //Set Params

        //Static
        private static T m_instance = null;
        public static T Instance { get => m_instance; }

        //Non Static
        [Header("Singleton")]
        [SerializeField] private bool m_dontDestroyOnLoad = false;

        //Methods

        //MonoBehaviour
        protected virtual void Awake()
        {
            if (m_instance == null)
            {
                m_instance = this as T;
                if (m_dontDestroyOnLoad) DontDestroyOnLoad(gameObject);
            }

            else
            {

                Destroy(gameObject);
            }
        }
    }
}
