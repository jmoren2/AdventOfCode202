public class PasswordPolicy{
    public int min {get; set;}
    public int max {get; set;}
    public char letter{get; set;}
    public string password{get; set;}   
}


var list = System.IO.File.ReadAllLines("stuff.txt")
            .ToList();
int validPasswords = 0;

foreach(var x in list)
{
    var policies = new PasswordPolicy();
    var temp1 = x.Split('-');
    policies.min = Int32.Parse( temp1[0].ToString() );
    
    var temp2 = temp1[1].Split(' ');

    policies.max = Int32.Parse( temp2[0].ToString() );
    policies.password = temp2[2];

    policies.letter = temp2[1].Split(':')[0].ToCharArray()[0];

    var letterInPassword = policies.password.Count( x => x == policies.letter);
    if( letterInPassword >= policies.min && letterInPassword <= policies.max)
    {
        ++validPasswords;
    }
}

WriteLine("Valid Passwords: {0}", validPasswords);