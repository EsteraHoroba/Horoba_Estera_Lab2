using System;
using System.Collections.Generic;
using System.Text;

namespace Horoba_Estera_Lab2
{
  public  class Doughnut 
    {
    }
}
public enum DoughnutType
{
    Glazed,
    Sugar,
    Lemon,
    Chocolate,
    Vanilla
}
public class Doughnut
{
    private int mRaisedGlazed = 0;
    private int mRaisedSugar = 0;
    private int mFilledLemon = 0;
    private int mFilledChocolate = 0;
    private int mFilledVanilla = 0;
    private double Total = 0;
    private DoughnutType selectedDoughnut;

    private DoughnutType mFlavor;
    public DoughnutType Flavor
    {
        get
        {
            return mFlavor;
        }
        set
        {
            mFlavor = value;
        }
    }
    private float mPrice;
    public float Price
    {
        get
        {
            return mPrice;
        }
        set
        {
            mPrice = value;
        }
    }
    public Doughnut(DoughnutType aFlavor)// constructor
    {
        mFlavor = aFlavor;
    }
}