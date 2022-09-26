
//setting up constants for order types
const double BONE_LESS_WING = 7.99;
const double TRADITIONAL_WING = 9.99;
const double BOTH_WINGS = 17.98;

const double DISCOUNT_BOTH_WINGS = .18;

//setting up constants for the sauces
const double BUFFALO_SAUCE = 0.29;
const double MILD_SAUCE = 0.39;
const double BBQ_SAUCE = 0.29;
const double PLAIN = 0.0;

//setting up constants for the sides
const double WAFFLE_FRIES = 3.49;
const double ONION_RINGS = 2.49;
const double BOTH_SIDES = 5.98;
const double NO_SIDE = 0.0;

const double NY_STATE_SALES_TAX = 0.08;

const string BUSINESS_NAME_BANNER = "***HEAVENLY WINGS***";

Console.WriteLine(BUSINESS_NAME_BANNER);

Console.WriteLine("Type of wings");
Console.WriteLine("1. Boneless " + BONE_LESS_WING);
Console.WriteLine("2. Traditional " + TRADITIONAL_WING);
Console.WriteLine("3. Both "+ BOTH_WINGS);

double subtotal = 0;
string order = "";

Console.Write("Enter your selection:");
switch(Console.ReadLine())
{
    case "1":
        subtotal+=BONE_LESS_WING;
        order+="Boneless " + BONE_LESS_WING + "\n";
        break;
    case "2":
        subtotal+=TRADITIONAL_WING;
        order+="Traditional " + TRADITIONAL_WING + "\n";
        break;
    case "3":
        subtotal+=BOTH_WINGS;
        subtotal = subtotal - (subtotal * DISCOUNT_BOTH_WINGS);
        order+="Both " + BOTH_WINGS + "\n";
        break;

}

Console.WriteLine("What kind of sauce?");
Console.WriteLine("1. Buffalo Sauce " + BUFFALO_SAUCE);
Console.WriteLine("2. Mild Sauce "+ MILD_SAUCE);
Console.WriteLine("3. BBQ Sauce "+ BBQ_SAUCE);
Console.WriteLine("4. Plain " + PLAIN);

Console.Write("Enter your selection:");
switch(Console.ReadLine())
{
    case "1":
        subtotal+=BUFFALO_SAUCE;
        order+="Buffalo " + BUFFALO_SAUCE + "\n";
        break;
    case "2":
        subtotal+=MILD_SAUCE;
        order+="Mild "+ MILD_SAUCE + "\n";
        break;
    case "3":
        subtotal+=BBQ_SAUCE;
        order+="BBQ " + BBQ_SAUCE;
        break;
    case "4":
        subtotal+=PLAIN;
        order+="Plain " + PLAIN + "\n";
        break;

}

Console.WriteLine("DO you want a side order?");
Console.WriteLine("1. Waffle Fries "+ WAFFLE_FRIES );
Console.WriteLine("2. Onion Rings "+ ONION_RINGS);
Console.WriteLine("3. Both "+ BOTH_SIDES);
Console.WriteLine("4. None " + NO_SIDE);


Console.Write("Enter your selection:");
switch(Console.ReadLine())
{
    case "1":
        subtotal+=WAFFLE_FRIES;
        order+="Waffle Fries "+ WAFFLE_FRIES + "\n";
        break;
    case "2":
        subtotal+=ONION_RINGS;
        order+="Onion Rings " + ONION_RINGS + "\n";
        break;
    case "3":
        subtotal+=BOTH_SIDES;
        order+="Both Sides "+ BOTH_SIDES + "\n";
        break;
    case "4":
        subtotal+=NO_SIDE;
        order+="No sides "+ NO_SIDE;
        break;
    
}

Console.WriteLine("\n"+BUSINESS_NAME_BANNER);
Console.WriteLine(order);
Console.WriteLine("Subtotal " + subtotal);
double tax = subtotal * NY_STATE_SALES_TAX;
Console.WriteLine("Tax:"+ tax);
Console.WriteLine("Total:" + (tax+ subtotal) );


