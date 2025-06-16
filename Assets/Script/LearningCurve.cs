using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public GameObject enemy;
    private int currentAge = 40;
    public int addAge = 1;
    public float pi = 3.14f;
    //public string name = "John";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {       
        Debug.Log("Awake is called");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable is called");
    }

    void Start()
    {
        Debug.Log("Start is called");
        ComputeAge();
        //Debug.Log(name);
        //Debug.Log($"My name is {name} ");

        //int[] ages = new int[5];
        int[] ages = { 1, 2, 3, 4, 5 };
        //int[] age = new int[] { 6, 7, 8, 9, 10 };
        /*
                for (int i = 0; i < ages.Length; i++)
                {
                    Debug.Log(ages[i]);
                }

                List<int> ageList = new List<int>();
                ageList.Add(10);
                ageList.Add(20);
                ageList.Add(30);


                for (int i = 0; i < ageList.Count; i++)
                {
                    Debug.Log(ageList[i]);
                }

                foreach (int age in ageList)
                {
                    Debug.Log(age);
                }
        */

        //public string name2 = "Tuan";

        Character spiderman = new Character();
        spiderman.DisplayInfo();

        Character superman = new Character("Clark Kent", 200);
        superman.DisplayInfo();

        Monster venom = new Monster("Venom", 300, 10);
        venom.DisplayInfo();

        Weapon wwWeapon = new Weapon("Sword", 10, 5);
        Character wonderwoman = new Character("Gal Gardot", 120, wwWeapon);
        wonderwoman.DisplayInfo();

    }

    void ComputeAge()
    {
        int i = (int) pi;

        //string abc = name2; 

        //Debug.Log(abc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
