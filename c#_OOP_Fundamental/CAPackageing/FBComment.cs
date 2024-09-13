using Humanizer;
namespace CAFileStream
{
    class FBComment
    { 
       public string Owner {get;set;}
        public string Comment {get; set;}
        public DateTime CreatedAt {get;set;}

        public override string ToString()
        {
            return $"{Owner} says : \n" +
                   $"\t\t\"{Comment}\"" +
                   $"\n\t\t\t\t {CreatedAt.Humanize()}";
        }


    }

}// End Of Namespace