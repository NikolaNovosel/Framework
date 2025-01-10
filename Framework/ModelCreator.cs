namespace Framework
{
    public static class ModelCreator
    {
        public static Model ReturnOperatingSystemOs() => new (DataReader.GetParameter(DataReader.Parameter.operatingSystem));
        public static Model ReturnMachine() => new (DataReader.GetParameter(DataReader.Parameter.machine));
        public static Model ReturnGpu() => new (DataReader.GetParameter(DataReader.Parameter.gpu));
        public static Model ReturnSsd() => new (DataReader.GetParameter(DataReader.Parameter.ssd));
        public static Model ReturnRegion() => new (DataReader.GetParameter(DataReader.Parameter.region));
    }
}
