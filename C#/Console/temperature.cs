void Main () {
    string another = "Y";

    do {
        Console.WriteLine ("Which temperature scale do you want to use (C/F)?");
        string scale = Console.ReadLine ();
        while ((scale != "C") && (scale != "F")) {
            Console.WriteLine ("Your input was not recognized. Please enter 'C' for Celcius or 'F' for Farenheight");
            Console.WriteLine ("\nWhich temperature scale do you want to use (C/F)?");
            scale = Console.ReadLine ();
        }

        Console.WriteLine ("Welcome, What temperature is it outside?");
        string temp = Console.ReadLine ();

        double tempParse = double.Parse(temp);

        if (scale == "F") {
            double Cel = (5.0 / 9.0) * (tempParse - 32.0);
            Console.WriteLine ("For the record, the temperature you entered in Farenheight is " + Cel + "Celcius");

            if (tempParse > 100) {
                Console.WriteLine ("It's Hot! Better Hydrate");
            } else if (tempParse <= 32) {
                Console.WriteLine ("It's Cold! Better pack long underwear");
            }
        }

        if (scale == "C") {
            double Far = (9.0 / 5.0) * (tempParse + 32.0);
            Console.WriteLine ("For the record, the temperature you entered in Celcius is " + Far + "Farenhieght");

            if (tempParse > 37) {
                Console.WriteLine ("It's Hot! Better Hydrate");
            } else if (tempParse <= 0) {
                Console.WriteLine ("It's Cold! Better pack long underwear");
            }
        }

        Console.WriteLine ("Want to try another temp (Y/N)?");
        another = Console.ReadLine ();

        if (another != "Y" && another != "N") {
            Console.WriteLine ("Sorry, I didn't get that...");

            Console.WriteLine ("\nWant to try another temp (Y/N)?");
            another = Console.ReadLine ();
        }
    }
    while (another == "Y");
}