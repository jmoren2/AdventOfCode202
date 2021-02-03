public class PasswordPolicy{
    public int position1 {get; set;}
    public int position2 {get; set;}
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
    policies.position1 = Int32.Parse( temp1[0].ToString() ) - 1;
    
    var temp2 = temp1[1].Split(' ');

    policies.position2 = Int32.Parse( temp2[0].ToString() ) - 1;
    policies.password = temp2[2];

    policies.letter = temp2[1].Split(':')[0].ToCharArray()[0];

    var firstLetter = policies.password[policies.position1];
    var secondLetter = policies.password[policies.position2];

    if(firstLetter != secondLetter)
    {
        if(firstLetter == policies.letter || secondLetter == policies.letter)
        {
            ++validPasswords;
        }
    }
}

WriteLine("Valid Passwords: {0}", validPasswords);