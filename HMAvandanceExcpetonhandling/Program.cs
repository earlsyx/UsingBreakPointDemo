



MainMethod();
static void MethodSample()
{
    throw new Exception();

}


static void MainMethod()
{
	try
	{
		MethodSample();

    }
	catch (Exception)
	{

		throw;
	}
}
