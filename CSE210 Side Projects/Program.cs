// See https://aka.ms/new-console-template for more information




    Console.WriteLine("Hello, World!");
    // call the constructor of the Blind class to construct or create a new instance of the blind class called kitchen
    Blind kitchen = new Blind();

    kitchen._width = 60;
    kitchen._height = 40;
    kitchen._color = "white";

    // we are going to add a location property to the Blind class to make our list code work at the bottom of this file
    kitchen._location = "kitchen";

    // call the GetArea method of the kitchen instance
    double kitchenRoomArea = kitchen.GetArea();
    Console.WriteLine($"The area of the kitchen blind is: {kitchenRoomArea} square units.");


    // call the constructor of the Blind class to construct or create a new instance of the blind class called livingRoom
    Blind LivingRoom = new Blind();
    LivingRoom._width = 72;
    LivingRoom._height = 52;
    LivingRoom._color = "white";

    // we are going to add a location property to the Blind class to make our list code work at the bottom of this file
    LivingRoom._location = "living room";

    // call the GetArea method of the LivingRoom instance
    double livingRoomArea = LivingRoom.GetArea();
    Console.WriteLine($"The area of the LivingRoom blind is: {livingRoomArea} square units.");

   
    // call the constructor of the House class to construct or create a new instance of the house class called johnsonHome
    House johnsonHome = new House();
    // set the _owner property of the johnsonHome instance
    johnsonHome._owner = "Johnson Family";
    // set the _kitchen property of the johnsonHome instance
    // johnsonHome._kitchen = new Blind();
    // this will set the _kitchen property of the johnsonHome instance to the kitchen instance that is already created above

    johnsonHome._kitchen = kitchen;

    // set the _livingRoom property of the johnsonHome instance
    // johnsonHome._livingRoom = new Blind();
    // **if we use the line above, it creates a completely new instance of the Blind class and we will have to give 
    // the new instance values again. Width and height and color will need to be declared again like this:
    // johnsonHome._livingRoom._width = 72;
    // johnsonHome._livingRoom._height = 52;
    // johnsonHome._livingRoom._color = "white";
    // but we don't want to do that because we already have the values in the LivingRoom instance above.


    // INSTEAD WE can write it like this...this will set the _livingRoom property of the johnsonHome instance to the LivingRoom instance that is already created above
    johnsonHome._livingRoom = LivingRoom;

    // print the _owner property of the johnsonHome instance
    Console.WriteLine($"Home Owner: {johnsonHome._owner}");
    // print the _kitchen property of the johnsonHome instance  
    Console.WriteLine($"Kitchen Blind Area: {johnsonHome._kitchen.GetArea()} square units.");
    // print the _livingRoom property of the johnsonHome instance
    Console.WriteLine($"Living Room Blind Area: {johnsonHome._livingRoom.GetArea()} square units.");


// OR WE COULD WRITE THE CODE SO HOUSE CLASS CONTAINS A LIST OF BLINDS
johnsonHome._blinds.Add(kitchen);
johnsonHome._blinds.Add(LivingRoom);
    // print the _blinds property of the johnsonHome instance
    foreach (Blind blind in johnsonHome._blinds)
    {
        Console.WriteLine($"Blind Area: {blind.GetArea()} square units.");
    // }
// This will print Blind Area: 2400 square units. and Blind Area: 3744 square units.  If we want to print the name of the location of the blinds,
// we can add a property to the Blind class called _location and set it to the name of the location of the blind.
// so in section above that has kitchn._color = "white", we can add kitchen._location = "kitchen"; and do the same for the LivingRoom instance
// and then in the foreach loop above, we can print the _location property of the blind instance like this: 
        Console.WriteLine($"Blind Location: {blind._location}  Blind Area:  {blind.GetArea()} square units. ");
    }