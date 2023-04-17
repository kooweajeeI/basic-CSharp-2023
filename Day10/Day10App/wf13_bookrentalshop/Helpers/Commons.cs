namespace wf13_bookrentalshop.Helpers
{
    internal class Commons
    {
        // 모든 프로그램상에서 다 사용가능
        // DB연결 문자열은 여기서만 수정하면됨
        public static readonly string ConnString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";

        // 로그인 사용자 아이디 저장변수
        public static string LoginID = string.Empty;
    }
}
