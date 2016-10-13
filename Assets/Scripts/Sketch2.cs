using UnityEngine;
using System.Collections;
using Pathfinding.Serialization.JsonFx; //make sure you include this using


public class Sketch2 : MonoBehaviour {
    public GameObject myPrefab;
    // Put your URL here
    public string _WebsiteURL = "http://infosys320pweb047.azurewebsites.net/tables/AMBirds?ZUMO-API-VERSION=2.0.0";

    void Start()
    {
        //Reguest.GET can be called passing in your ODATA url as a string in the form:
        //http://{Your Site Name}.azurewebsites.net/tables/{Your Table Name}?zumo-api-version=2.0.0
        //The response produce is a JSON string
        string jsonResponse = Request.GET(_WebsiteURL);

        //Just in case something went wrong with the request we check the reponse and exit if there is no response.
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

        //We can now deserialize into an array of objects - in this case the class we created. The deserializer is smart enough to instantiate all the classes and populate the variables based on column name.
        Product[] products = JsonReader.Deserialize<Product[]>(jsonResponse);

        int i = 0;
        //We can now loop through the array of objects and access each object individually
        foreach (Product product in products)
        {
            //Example of how to use the object
            Debug.Log("This soldier's name is: " + product.CommonName);
            i++;
            float x = Random.Range(-12.0F, 12.0F);
            float y = 4.0f;
            float z = Random.Range(-12.0F, 12.0F);
            GameObject newSoldier = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
