namespace AuthWindowWithEntity.Model
{
    public static class AccessToApp
    {
        static bool access = false;
        static public bool Access { get => access; set => access = value; }
        static public int Attempt { get; set; } = 0;
        static public bool Checks(Accounts account)
        {
            Attempt++;
            return AccountList.Find(account);
        }
    }
}
