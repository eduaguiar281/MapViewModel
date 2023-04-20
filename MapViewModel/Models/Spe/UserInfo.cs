namespace MapViewModel
{
    public class UserInfo
    {
        public string access_token { get; set; }
        public string access_token_parceiro { get; set; }
        public string alias { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
        public List<School> schools { get; set; }
    }



}
