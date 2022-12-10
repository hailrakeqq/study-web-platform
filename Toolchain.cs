namespace study_web_platform
{
    public class Toolchain
    {
        public static string GetStringFromDotEnv(string searchString)
        {
            DotNetEnv.Env.Load();
            return Environment.GetEnvironmentVariable(searchString) ?? "underfined";
        }
    }
}