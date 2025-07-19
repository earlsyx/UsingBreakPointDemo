
string name = "";
try
{
    DifferentMethod();
    Console.Write("What is your name");
     name = Console.ReadLine();
    ComplextMethod(name);
    SimpleMethod();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("You should not be calling this messetheods.");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You for got to finish yout code1!!");
}
catch (Exception    ) when (name.ToLower() == "tim")
{
    Console.WriteLine("You used tim;'s name didnt you?");
    //Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    //Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("I always run");
}
void ComplextMethod(string name)
{
    if(name.ToLower() == "tim")
    {
        throw new InsufficientMemoryException("Tim is too tall for this method");
    }
    else
    {
        throw new ArgumentException("This pserson is not Tim");
    }
}

void DifferentMethod()
{
    Console.WriteLine("tHIS is the dfiferent method working proprerly");
}

Console.ReadLine();

static void SimpleMethod()
{
    throw new InvalidOperationException("You shouud not be calling the simple method");
}

//most ocmmon reason to call an exception is you are not the top dog
// we are on UI layer, we can talk directly to the user,
// theres a problem, throw it in Ui, hey dont do it, exit in method.
// library deos't have acces ot UI, epciton biubble up. if not handled.
// we allow higher up to handled

