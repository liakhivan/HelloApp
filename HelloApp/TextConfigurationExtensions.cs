using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp
{
    public static class TextConfigurationExtensions
    {

        private static IConfigurationBuilder AddTextFile(this IConfigurationBuilder builder, string path)
        { 
            if(builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            if(string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Шлях до файлу не вказаний.");
            }

            var source = new TextConfigurationSource(path);
            builder.Add(source);
            return builder;
        }
    }
}
