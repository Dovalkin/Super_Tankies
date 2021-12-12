using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanky
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(IP_Tank_Inputs))]
    public class IP_Tank_Controller : MonoBehaviour
    {

        #region Variables

        private Rigidbody rb;
        private IP_Tank_Inputs input;
        #endregion

        #region Builtin Methods
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            input = GetComponent<IP_Tank_Inputs>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion
    }
}
