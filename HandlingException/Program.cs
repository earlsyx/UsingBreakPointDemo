

// Handling Exceptions.


try
{
    BadCall();
}
catch (Exception ex)
{

    Console.WriteLine("There was an execption thron in our app");
    Console.WriteLine(ex.Message);
}
Console.ReadLine();
// when code does something unexcepted
// outside what the processor complier can handle.

//Stack Trace.
// Where  +

//Inner exception, maybe in parent exceptoon. 

//Stack Trace - where exactly the exceppton occurured
// who called it and who called that allw thway back through
static void BadCall()
{
    int[] ages = new int[] { 1, 3, 5 };

    for (int i = 0; i <= ages.Length; i++)
    {
        try
        {
            Console.WriteLine(ages[i]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("We had an erro");
            Console.WriteLine(ex.Message);
            throw new Exception("Tehre was an error ", ex);
            // not an exepction state so does not crash.
            //eating our exceptions.
            // not good.
        }
    }

}