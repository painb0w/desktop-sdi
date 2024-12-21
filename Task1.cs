using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public static class TextAnalysisHelper
{
    public static Dictionary<string, int> ProcessTexts(string[] files, string[] words)
    {
        var wordSet = new HashSet<string>(words, StringComparer.OrdinalIgnoreCase);

        var frequencies = new ConcurrentDictionary<string, int>();

        Parallel.ForEach(files, file =>
        {
            var text = File.ReadAllText(file);

            var localFrequencies = text
                .Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => wordSet.Contains(word, StringComparer.OrdinalIgnoreCase))
                .GroupBy(word => word, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var kvp in localFrequencies)
            {
                frequencies.AddOrUpdate(kvp.Key, kvp.Value, (key, oldValue) => oldValue + kvp.Value);
            }
        });

        return frequencies.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}
