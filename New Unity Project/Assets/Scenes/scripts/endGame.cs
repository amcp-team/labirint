using UnityEngine;

public class endGame : MonoBehaviour
{

    public GameObject Pl;

   

    public bool isEnded;
    public GameObject EndMenu;

    void Start()
    {
        EndMenu.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject == Pl)
        {
            EndMenu.SetActive(true);
        }
    }
}
