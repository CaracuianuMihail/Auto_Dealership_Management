namespace AutoDealership.Services
{
    public static class IdGenerator
    {
        private static int _nextId = 1;
        public static int GetNextId() => _nextId++;
    }
}
