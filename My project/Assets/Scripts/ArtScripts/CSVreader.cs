using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVreader : MonoBehaviour
{
    /*public string StationFileName = "StationMapping";
    public string QuakesFileName = "QuakeMapping";


    public GameObject theMoon;
    private SphereCollider moonCollider;
    private float radius;
    public GameObject theButton;
    private Vector3 myVector;

    private List<Vector3> vectorOfVectors;

    void Start()
    {
        vectorOfVectors = StationMapping();
        plotAll();

        var render = theMoon.GetComponent<Renderer>();
        moonCollider = theMoon.GetComponent<SphereCollider>();
        radius = (render.bounds.extents.magnitude / 2);
        radius *= 1.1f;


        

        //List<List<string>> lines = ReadCSVFile(StationFileName);
        //Debug.Log("First value in CSV: " + lines[1][0]);

    }



    List<List<string>> ReadCSVFile(string fileName)
    {
        List<List<string>> data = new List<List<string>>();

        TextAsset csvFile = Resources.Load<TextAsset>(fileName);

        if (csvFile != null)
        {
            StringReader reader = new StringReader(csvFile.text);

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                List<string> row = new List<string>(line.Split(','));
                data.Add(row);
            }
        }
        else
        {
            Debug.LogError("CSV file not found: " + fileName);
        }

        return data;
    }

    List<Vector3> StationMapping()
    {
        List<List<string>> stationData = ReadCSVFile(StationFileName);
        List<Vector3> output = new List<Vector3>();
        string longitude;
        string lat;
        for (int i = 1; i < 7; i++)
        {
            lat = stationData[i][1];
            longitude = stationData[i][2];

            Debug.Log(float.Parse(lat) + "lat");
            Debug.Log(float.Parse(longitude) + "long");
            Debug.Log("GPS" + GPSLocation(float.Parse(lat), float.Parse(longitude)));
            output.Add(GPSLocation(float.Parse(lat), float.Parse(longitude)));
        }

        for (int i = 1; i < 6; i++)
        {
            Debug.Log(output[i]);
        }
        return output;
    }




    List<Vector3> QuakeMapping()
    {
        List<List<string>> quakeData = ReadCSVFile(QuakesFileName);
        List<Vector3> output = new List<Vector3>();
        string longitude;
        string lat;
        for (int i = 1; i < 29; i++)
        {
            lat = quakeData[i][6];
            longitude = quakeData[i][7];
            output.Add(GPSLocation(float.Parse(lat), float.Parse(longitude)));
        }
        return output;
    }

    void plotAll()
    {

        for (int i = 0; i < vectorOfVectors.Count; i++)
        {
            Debug.Log(vectorOfVectors[i]);
            Instantiate(theButton, vectorOfVectors[i], Quaternion.identity, theMoon.transform);
            
        }
    }

    private Vector3 GPSLocation(float Lat, float Lon)
    {
        //something is happenign here
        Vector3 result;
        float ltR = Lat * Mathf.Deg2Rad;
        float lnR = Lon * Mathf.Deg2Rad;

        float xPos = (radius * transform.lossyScale.z) * Mathf.Cos(ltR) * Mathf.Cos(lnR);
        float zPos = (radius * transform.lossyScale.z) * Mathf.Cos(ltR) * Mathf.Sin(lnR);
        float yPos = (radius * transform.lossyScale.z) * Mathf.Sin(ltR);



        Vector3 earthPositon = theMoon.transform.position;
        result = new Vector3(xPos + earthPositon.x, yPos + earthPositon.y, zPos + earthPositon.z);


        return result;
    }*/
}