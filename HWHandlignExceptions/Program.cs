

int[] ages = new int[] { 1, 3, 5, 7 };
for (int i = 0; i <= ages.Length; i++)
{
    try
    {
        Console.WriteLine(ages[i]);
    }
    catch(Exception ex)
    {
        throw new Exception("There was an error at ", ex);
    }
   
}