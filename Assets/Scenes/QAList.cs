using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAList : MonoBehaviour
{
    [SerializeField] List<Question> list = new List<Question>();

    // Start is called before the first frame update
    void Start()
    {
        list.Add(new Question("Do homework or hang out with friends", new string[] {"ans0", "ans1"}));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
