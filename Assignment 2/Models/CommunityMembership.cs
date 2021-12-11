namespace Assignment_2.Models
{
    public class CommunityMembership
    {
        public int StudentId { get; set; }

        public string CommunityId { get; set; }

        public Student Student { get; set; }

        public Community Community { get; set; }
    }
}
