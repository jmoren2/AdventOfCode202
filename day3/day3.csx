public class coordinates {
    public coordinates(int x , int y)
    {
        this.x = x;
        this.y = y;
    }
    public int x {get; set;}
    public int y {get; set;}
}

public int treesEncountered(int xChange, int yChange){

    var list = System.IO.File.ReadAllLines("stuff.txt");
    var position = new coordinates(0,0);
    var trees = 0;

    while( position.y < list.Length )
    {
        char[] row = list[position.y].ToCharArray();
        char symbol = row[position.x];
        if(symbol == '#')
        {
            ++trees;
        }

        position.x += xChange; 
        position.y += yChange;

        var rowIndex = row.Length - 1; 
        if(position.x > rowIndex )
        {
            position.x = position.x - row.Length; 
        }
    }
    return trees;
}
var trees = treesEncountered(3, 1);
WriteLine("Trees encountered for part 1: {0}", trees);

var trees2 = treesEncountered(1, 1) * 
             treesEncountered(3, 1) * 
             treesEncountered(5, 1) *   
             treesEncountered(7, 1) * 
             treesEncountered(1, 2); 

WriteLine("Trees encountered for part 2: {0}", trees2);