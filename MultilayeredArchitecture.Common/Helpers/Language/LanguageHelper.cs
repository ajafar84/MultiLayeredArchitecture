using MultilayeredArchitecture.Common.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace MultilayeredArchitecture.Common.Helpers.Language
{
    public static class LanguageHelper
    {
        public static Expression<Func<TSource, string>> GetSourceMapExpression<TSource>(string field, Dictionary<CultureCode, string> languageIdentifiers)
        {
            string ar = CultureCode.ar.ToString();
            string en = CultureCode.en.ToString();
            string culture = CultureInfo.CurrentUICulture.Name;

            var parameterExpression = Expression.Parameter(typeof(TSource));
            var property = Expression.Property(parameterExpression,
                culture == ar ? $"{field}{languageIdentifiers[CultureCode.ar]}" :
                culture == en ? $"{field}{languageIdentifiers[CultureCode.en]}" :
                $"{field}{languageIdentifiers[CultureCode.ar]}");

            return Expression.Lambda<Func<TSource, string>>(property, parameterExpression);
        }
    }
}
