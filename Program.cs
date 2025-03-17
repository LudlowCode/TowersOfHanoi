class Tower 
{
  //Attributes go here
  private int[] pole;
  private int pointer;
  private int maxSize;
  

  //Constructor to make a new object of class Car..
  public Tower(int aMaxSize){
    pointer = 0;
    maxSize = aMaxSize;
    pole = new int[aMaxSize];
  }

  public Boolean Push(int diskValue) {
      if (pointer == 0){
        pole[pointer] = diskValue;
        pointer = pointer + 1;
        return true;
      }
      else if (pointer < maxSize && pole[pointer - 1] > diskValue) {
        pole[pointer] = diskValue;
        pointer = pointer + 1;
        return true;
      }
      else {
        return false;
      }
  }


  public int Pop(){
    if (pointer == 0){
      return 999;
    }
    else{
      pointer--;
      return pole[pointer];
    }
  }

  public int Peek(){
    if (pointer == 0){
      return 999;
    }
    else{
      return pole[pointer];
    }
  }
  
  public void PrintTower(){
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Tower contents:\n");
    int i = pointer;
    while (i > 0){
      Console.WriteLine(i);
      i--;
    }
    Console.WriteLine("----------------------------------");
      

  }
  //Main runs automatically when the Program is run
  static void Main(string[] args)
  {
    //Calling the constructor of the Tower class to make a new Tower object
    Tower tower1 = new Tower(10);
    tower1.Push(3);
    tower1.Push(2);
    tower1.Push(1);
    tower1.PrintTower();
    tower1.Pop();
    tower1.PrintTower();
    tower1.Peek();
    tower1.PrintTower();
  }
}