using ExceptionProjectLibrary;
namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Customer c = new Customer();
			try
			{
                Console.WriteLine("Enter the cust id:");
                c.Custid=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter cust name:");
                c.CustName=Console.ReadLine();
                Console.WriteLine("Enter cust city");
                c.City=Console.ReadLine();
            }
			catch (ArgumentNullException ex)
			{

                Console.WriteLine( ex.Source);
                
            }
            catch (AccessViolationException es)
            {
                Console.WriteLine(es.Message);
            }
            catch(CustomerNotFoundException et)
            {
                Console.WriteLine(et.Message);
            }
            finally
            {
                Console.WriteLine("Finally block called..");
            }
        }
    }
}