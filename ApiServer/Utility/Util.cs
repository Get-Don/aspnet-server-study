using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace ApiServer.Utility;

public static class Util
{
    public static void LoadCsv<T>(string file, Action<List<T>> action)
    {
        try
        {
            using var streamReader = new StreamReader(file);
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            var records = csvReader.GetRecords<T>().ToList();

            action(records);

            Console.WriteLine($"Csv file Loaded {file}. Count: {records.Count}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static Func<string, string> CombinePath(string dir)
    {
        return (string fileName) => Path.Combine(dir, fileName);
    }
}
