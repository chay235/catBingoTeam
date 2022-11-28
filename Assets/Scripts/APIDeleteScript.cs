using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIDeleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Delete_Student()
    {
        WebRequest myRequest =
        WebRequest.Create("https://catbingochild.azurewebsites.net/api/CatBingoState/3");
        myRequest.Method = "DELETE";
        WebResponse myResponse = myRequest.GetResponse();
        Debug.Log(myResponse);
    }


}
