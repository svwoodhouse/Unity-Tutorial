using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    Player warrior;
    Player archer;

    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;
    private AudioSource audioSource;
    private Animator anim;

    private Transform myTransform;

    // Awake is the first function that is called
    private void Awake()
    {
        
    }

    // 3rd function called
    void Start()
    {
        warrior = new Player(1, 2, "Sydnee");
        archer = new Player(20, 30, "Archer");

        warrior.Info();
        archer.Info();

        warrior.setHealth(20);
        // warrior.Health = 20;
        //  Debug.Log("The health of the warrior is: " + warrior.Health);

        Debug.Log("The health of the warrior is: " + warrior.getHealth());

        Warrior w = new Warrior(3, 5, "Warrior");
        w.Attack();
        w.Info();

        // You can access the components created in Unity for the Game Objects 
        myBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        audioSource.Play();

        //Tranform is inheritated from the MonoBehavior classw
        myTransform = transform;
        myTransform.position = new Vector3(10, 20, 30);
    }

}
