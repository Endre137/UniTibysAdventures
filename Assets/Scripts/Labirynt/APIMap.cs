using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class APIMap : MonoBehaviour
{
    private const string API_URL = "http://localhost:5054/map/GetById/1";

    public int[,]map1 = new int [40,40];

    void Start()
    {
        //StartCoroutine(GetDataFromAPI());
    }

    IEnumerator GetDataFromAPI()
    {
        UnityWebRequest request = UnityWebRequest.Get(API_URL);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            string response = request.downloadHandler.text;
            // Process the response data
            Debug.Log(response);

            // Deserialize JSON response
            ResponseData responseData = JsonUtility.FromJson<ResponseData>(response);

            // Extract data from the response
            List<MapData> dataList = new List<MapData>(responseData.data);

            // Print the extracted data
            foreach (var mapData in dataList)
            {
                map1[mapData.xcoordinate,mapData.ycoordinate]=mapData.mapEntityType.code;
            }
            /*
           for (int i = 0; i < map1.GetLength(0); i++)
{
            for (int j = 0; j < map1.GetLength(1); j++)
            {
                if(map1[i, j]>0)
                    Debug.Log("map1[" + i + "," + j + "]: " + map1[i, j]);
            }
}*/
        }
        else
        {
            Debug.LogError("Error: " + request.error);
        }
    }

    [System.Serializable]
    private class ResponseData
    {
        public List<MapData> data;
        public bool success;
        public string message;
    }

    [System.Serializable]
    private class MapData
    {
        public int mapEntityTypeid;
        public MapEntityType mapEntityType;
        public int xcoordinate;
        public int ycoordinate;
    }

    [System.Serializable]
    private class MapEntityType
    {
        public int code;
        public string name;
    }

}