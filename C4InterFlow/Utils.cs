﻿using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using C4InterFlow.Automation;
using C4InterFlow.Cli;
using C4InterFlow.Elements;
using C4InterFlow.Elements.Interfaces;
using C4InterFlow.Elements.Relationships;

namespace C4InterFlow
{
    public class Utils
    {
        public static IEnumerable<T> GetNestedInstances<T>(string? alias) where T : Structure
        {
            return ArchitectureAsCodeReaderContext.Strategy.GetNestedInstances<T>(alias);
        }

        public static T? GetInstance<T>(string? alias) where T : Structure
        {
            return ArchitectureAsCodeReaderContext.Strategy.GetInstance<T>(alias);
        }

        public static T Clone<T>(T source)
        {
            var result = default(T);

            if (source != null)
            {
                var json = JsonSerializer.Serialize(source);
                result = JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions() { IncludeFields = true});
            }

            return result;
        }

        public static string? GetLabel(string? text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            return Regex.Replace(Regex.Replace(Regex.Replace(text.Replace("\"", string.Empty), "([A-Z]+)([A-Z][a-z])", "$1 $2"), "((?<=[a-z])[A-Z]|A-Z)", " $1"), "((?<=[a-zA-Z])[0-9]|(?<=[0-9])[a-zA-Z])", " $1").Trim();
        }
    }
}
