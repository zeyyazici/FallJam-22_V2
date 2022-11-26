using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class a : MonoBehaviour
{
    private Camera _camera;
    private NavMeshAgent _agent;
    private bool isChoice = false;
    private KeyCode[] keyCodes = { KeyCode.D, KeyCode.E, KeyCode.V, KeyCode.I, KeyCode.L };
    private int currentIndex = 0;
    private KeyCode currentKeyCode;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main; ;

        if(_camera == null)
        {
            Debug.LogError(message: "The Camera is null on the player controller.");
        }
        _agent = GetComponent<NavMeshAgent>();

        currentKeyCode = keyCodes[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();

    }

    private void HandleMovement()
    {


        // Eðer basýlan input istenilene eþitse destination set et
        if (Input.GetKeyDown(currentKeyCode))
        {
            RaycastHit hit;
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                _agent.destination = hit.point;
            }


            // Sonraki input'u seç
            currentIndex += 1;
            if (currentIndex == 5) { currentIndex = 0; }

            currentKeyCode = keyCodes[currentIndex];


        }



    }


}
