using System.Text;

namespace testrec
{
    internal class Program
    {
        public record Person(string FirstName, string LastName);

        public static void Main()
        {
            Person person = new("Nancy", "Davolio");
            Console.WriteLine(person);
            // output: Person { FirstName = Nancy, LastName = Davolio }
        }
    }

    //This code example produces the following output:
    //
    //The linked list values:
    //the fox jumps over the dog

    //Test 1: Add 'today' to beginning of the list:
    //today the fox jumps over the dog

    //Test 2: Move first node to be last node:
    //the fox jumps over the dog today

    //Test 3: Change the last node to 'yesterday':
    //the fox jumps over the dog yesterday

    //Test 4: Move last node to be first node:
    //yesterday the fox jumps over the dog

    //Test 5: Indicate last occurence of 'the':
    //the fox jumps over (the) dog

    //Test 6: Add 'lazy' and 'old' after 'the':
    //the fox jumps over (the) lazy old dog

    //Test 7: Indicate the 'fox' node:
    //the (fox) jumps over the lazy old dog

    //Test 8: Add 'quick' and 'brown' before 'fox':
    //the quick brown (fox) jumps over the lazy old dog

    //Test 9: Indicate the 'dog' node:
    //the quick brown fox jumps over the lazy old (dog)

    //Test 10: Throw exception by adding node (fox) already in the list:
    //Exception message: The LinkedList node belongs a LinkedList.

    //Test 11: Move a referenced node (fox) before the current node (dog):
    //the quick brown jumps over the lazy old fox (dog)

    //Test 12: Remove current node (dog) and attempt to indicate it:
    //Node 'dog' is not in the list.

    //Test 13: Add node removed in test 11 after a referenced node (brown):
    //the quick brown (dog) jumps over the lazy old fox

    //Test 14: Remove node that has the value 'old':
    //the quick brown dog jumps over the lazy fox

    //Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':
    //the quick brown dog jumps over the lazy rhinoceros

    //Test 16: Copy the list to an array:
    //the
    //quick
    //brown
    //dog
    //jumps
    //over
    //the
    //lazy
    //rhinoceros

    //Test 17: Clear linked list. Contains 'jumps' = False
    //
}
    
