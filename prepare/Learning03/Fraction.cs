using System;

class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public float GetTopNumber()
    {
        return _topNumber;
    }

    public void SetTopNumber (int topNumber)
    {
        _topNumber = topNumber;
    }

    public float GetBottomNumber()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber (int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString(){
            
        string numberString = $"{_topNumber}/{_bottomNumber}" ;
        return numberString;
    }

    public double GetDecimalValue(){
        return (double)_topNumber/ (double)_bottomNumber;
    }

}
