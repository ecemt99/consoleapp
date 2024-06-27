using System.Runtime.CompilerServices;
using System;

public  class Seat
{
    public int Row {get; set;}
    public int Number{ get; set;}
    public bool IsReserved{ get; set;}
   
public Seat(int row, int number)
{
    Row = row;
    Number = number;
    IsReserved = false;
}   
public override string ToString()
    {
        return $"Koltuk: {Row}-{Number} {(IsReserved ? "Dolu" : "Boş")}";
    }
}
