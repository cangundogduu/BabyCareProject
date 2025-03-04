namespace BabyCareProject.DataAccess.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string InstractorCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
    }
}
