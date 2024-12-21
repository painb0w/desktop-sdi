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

        // map
        var localFrequencies = files.AsParallel().Select(file =>
        {
            var text = File.ReadAllText(file);

            return text
                .Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => wordSet.Contains(word, StringComparer.OrdinalIgnoreCase))
                .GroupBy(word => word, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.Count());
        }).ToList();

        // reduce
        var globalFrequencies = new ConcurrentDictionary<string, int>();

        foreach (var freq in localFrequencies)
        {
            foreach (var kvp in freq)
            {
                globalFrequencies.AddOrUpdate(kvp.Key, kvp.Value, (key, oldValue) => oldValue + kvp.Value);
            }
        }

        return globalFrequencies.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}
