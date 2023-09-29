namespace SfeAdminPortal.MyExtensions
{
    public static class IntExtention
    {
        public static int GetSmallerValue(this int i, int j)
        {
            if(i < j)
            {
                return i;
            }
            else
            {
                return j;
            }
        }
    }
}
