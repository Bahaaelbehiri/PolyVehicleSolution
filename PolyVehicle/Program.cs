namespace PolyVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {

   
            Vehicle[] fleet = new Vehicle[5];
            fleet[0] = new SunbeamTiger();
            fleet[1] = new FordF250();
            fleet[2] = new SunbeamTiger();
            fleet[3] = new FordF250();
            fleet[4] = new SunbeamTiger();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(fleet[i].Start());    
        }
    }
}