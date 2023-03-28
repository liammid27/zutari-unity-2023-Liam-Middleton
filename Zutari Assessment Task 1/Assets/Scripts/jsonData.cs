using System;
using System.Collections.Generic;

[Serializable]
public class jsonData
{
    public coord coord;
    public List<weather> weather;
    public string @base;
    public main main;
    public int visibility;
    public wind wind;
    public clouds clouds;
    public int dt;
    public sys sys;
    public int timezone;
    public int id;
    public string name;
    public int cod;

}

[Serializable]
public class coord
{
    public double lon;
    public double lat;
}

[Serializable]
public class weather
{
    public int id;
    public string main;
    public string description;
    public string icon;
}

[Serializable]
public class main
{
    public double temp;
    public double feels_like;
    public double temp_min;
    public double temp_max;
    public int pressure;
    public int humidity;
}

[Serializable]
public class wind
{
    public int id;
    public string main;
    public string description;
    public string icon;
}

[Serializable]
public class clouds
{
    public int all;
}

[Serializable]
public class sys
{
    public int type;
    public int id;
    public string country;
    public int sunrise;
    public int sunset;
}
