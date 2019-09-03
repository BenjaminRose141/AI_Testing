using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float aggroRange = 20f;
    [SerializeField] private float meleeRange = 3f;
    [SerializeField] private bool think = false;

    [SerializeField] private BunnyBrain bunnyBrain = null;

    public string currentAction;


    public GameObject Player { get => player; set => player = value; }
    public float AggroRange { get => aggroRange; }
    public float MeleeRange { get => meleeRange; }

    private void Update()
    {
        if(think)
        {
            string result = bunnyBrain.Think();
            if (result != "none")
            {
                currentAction = result;
            }
        }

    }
}