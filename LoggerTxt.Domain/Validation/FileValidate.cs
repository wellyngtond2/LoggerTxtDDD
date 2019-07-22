using System.IO;

namespace LoggerTxt.Domain.Validation
{
    public static class FileValidate
    {
        public static void ValidatePath(string Path)
        {
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);
        }
    }
}
