using System;


namespace NightTabHelper
public class Accent
{
    public Accent()
    {
        color = new Color();
    }
    private string overRide = "";
    public Color color;

    public string OverRide
    {
        get
        {
            return overRide;
        }
        set { overRide = value; }
    }
}
