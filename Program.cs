// Main

Console.Clear();
int choice = GetUserChoice();

while (choice != 3) {

if (choice > 3 || choice < 1) {
    Console.Clear();
    Console.WriteLine("Invalid input, please choose again.");
    continue;
}

if (choice==1) {
    GetFull();
}

if (choice==2) {
    GetPartial();
}

if (choice==3) {
    Console.Clear();
    break;
}

Console.WriteLine("\n(Press any key to continue.)");
Console.ReadKey();
choice = GetUserChoice();

}


// End Main


// Methods

static int GetUserChoice(){
    Console.Clear();
    Console.WriteLine("Enter '1' for a full triangle, '2' for a partial triangle, or '3' to exit program.");
    return int.Parse(Console.ReadLine());
}

static void GetFull() {
    Console.Clear();
    Console.WriteLine("Enter the number of rows you want in your full triangle. (Minimum of 3)");
    int rows = 0;
    rows = int.Parse(Console.ReadLine());
    Console.Clear();
    
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j <= i; j++) {
            Console.Write("0");
        }
        Console.Write("\n");
    }
}

static void GetPartial() {
    Console.Clear();
    Console.WriteLine("Enter the number of rows you want in your partial triangle. (Minimum of 3)");
    int rows = 0;
    rows = int.Parse(Console.ReadLine());
    Console.Clear();

    Random rnd = new Random();
    
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j <= i; j++) {
            
                int number = rnd.Next(100);  // out of 100

                if (number > 69) {           // gives a 30% chance that block is missing
                    Console.Write(" ");
                }

                else {
                    Console.Write("0");
                }
            
        }
        Console.Write("\n");
    }
}

// End Methods