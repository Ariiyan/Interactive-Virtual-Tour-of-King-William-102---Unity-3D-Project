using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;
public class Timeline : MonoBehaviour
{
    public TMP_Text text;

    public Transform cameraP;
    public string[] anims;
    public GameObject player;
    public TMP_Text questionText;
    [SerializeField] private Animator  animationController;


    /*    public AnimationClip[] talk_animations;

        public TMP_Text speechText;
        public TMP_Text questionText;


        public GameObject askerUI;
        public GameObject answererUI;

        



        [Header("TIMELINE-SPECH")]
        public float question_one_dur;
        public float question_two_dur;
        public float question_three_dur;


        public float initializationTime =  3.0f;


        public bool chatReady  = false;


        // Start is called before the first frame update
        void Start()
        {
            Invoke("Initiailze", initializationTime);
        }

        // Update is called once per frame
        void Update()
        {


            if (chatReady)
            {
                StartCoroutine(PassDialogue("Wow..wue", question_one_dur));

                StartCoroutine(PassDialogue("next one now", question_two_dur));
                StartCoroutine(PassDialogue("hehe, question three", question_three_dur));
                return;
            }


            return;
        }


        public void Initiailze()
        {
            // Chat system initailized

            Debug.Log("Ready...");
            chatReady = true;



        }

        public IEnumerator PassDialogue(string dialogue, float afterTime)
        {
            Debug.Log(dialogue);


            yield return new WaitForSeconds(afterTime);
        }
    */
    public void LoadAnswer( string message)
    {
        text.text = message;
        animationController.Play(anims[Random.Range(0, anims.Length)]);
        animationController.Play("Idle");
    }
    public void AskQuestion(string question)
    {
        text.text = question;

    }
    public void DestroyText()
    {
        Destroy(text.gameObject, 5);
    }
    public void SpawnPlayer()
    {
        SC_FPSController.player.canMove = true;
    }

}











