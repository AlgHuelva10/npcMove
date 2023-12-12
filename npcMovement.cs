using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class npcMovement : MonoBehaviour
{
    // Variable de vida para el NPC (pública)
    public int npcHealth = 5;

    // Variable de velocidad para el NPC (pública)
    public float npcSpeed = 1.2f;

    // Variable de nivel para el NPC (pública)
    public int npcLevel = 1;

    //Variable de movimiento para el NPC
    Vector3 position;

    /* Creamos diferentes variables para la rotación como:
     * Velocidad de rotación para el NPC */
    public float npcRotation = 0.5f;
    Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
       // Movimiento z del NPC (constante)
        position.z += npcSpeed * Time.deltaTime;
        transform.position = position;

        // Movimiento x del NPC (constante)
        position.x += npcSpeed * -1 * Time.deltaTime;
        transform.position = position;

        rotation.y += npcRotation * Time.deltaTime;
        transform.rotation = rotation;
    }
}
