using UnityEngine;
[RequireComponent(typeof(Animator))]
public class PlayerThrow : MonoBehaviour
{
    Animator anim;

    [SerializeField]
    GameObject shuriken;

    [SerializeField]
  public  Transform hand;
 

    [SerializeField]
    private float shurikenSpeed;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (transform.localScale.x > 0)
            {
                GameObject sh = Instantiate(shuriken, hand.position, Quaternion.identity);

                sh.GetComponent<Rigidbody2D>().velocity = hand.right * shurikenSpeed * GetComponent<ninjamouvement>().speed;
                sh.transform.up = sh.GetComponent<Rigidbody2D>().velocity;
                anim.SetTrigger("Throw");
                Destroy(sh, 5f);
                GetComponent<Animator>().SetBool("Throw", true);
            }
            if (transform.localScale.x < 0)
            {
                GameObject sh = Instantiate(shuriken, hand.position, Quaternion.identity);

                sh.GetComponent<Rigidbody2D>().velocity = hand.right * -shurikenSpeed * GetComponent<ninjamouvement>().speed;
                sh.transform.up = sh.GetComponent<Rigidbody2D>().velocity;
                anim.SetTrigger("Throw");
                Destroy(sh, 5f);
                GetComponent<Animator>().SetBool("Throw", true);
            }
        }
        else
        {
            GetComponent<Animator>().SetBool("Throw", false);
            
        }
    }
}
