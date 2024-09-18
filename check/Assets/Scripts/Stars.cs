
using UnityEngine;

public class Stars : MonoBehaviour
{

    [SerializeField] GameObject[] stars;
  
    void Start()
    {
        for (int i = 0; i < Random.Range(1, 3); i++)
        {
            stars[i].SetActive(true);
        }    
    }

}
