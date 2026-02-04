using UnityEngine;

public class BaileViejo : MonoBehaviour
{

    [SerializeField] private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
            anim.SetBool("isMoving", true);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("isMoving", false);

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isMoving2", true);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("isMoving2", false);

        }
        //MOVIE
    }

}
 