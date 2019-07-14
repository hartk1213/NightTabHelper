using System;

namespace NightTabHelper { 
public class Color
{
    public Color()
    {

    }
    private string r = "0";
    private string g = "176";
    private string b = "0";

    public string R
    {
        get
        {
            return r;
        }
        set
        {
            r = value;
        }
    }

    public string G
    {
        get
        {
            return g;
        }
        set
        {
            g = value;
        }
    }

    public string B
    {
        get
        {
            return b;
        }
        set { b = value; }
    }
}
}
