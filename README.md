# StringExtensions
Minimum Visual Studio version = 10.0.40219.1
### Portability
##### Fully portable
- .NET Core
- ASP.NET Core
- Xamarin
#### Partialy portable
- .NET Framework >= 4.0
- Mono >=4.0
- .NET Standard >= 1.3
- UWP 10.0 & 10.1
### Assembly
StringExtensions
### Members

- #### LimitLength(int maxLength)

  ##### Summary

  Return substring of length maxLength.
  
  ##### Parameters
  
  - int maxLength
  
    Length of the substring returned by LimitLength invocation.

- #### RemoveDiacritical()

  ##### Summary

  Return the input string without diacriticals.

  Diacritics are replaced by their unaccented equivalents.

- #### RemoveNonAlphaNum(bool keepBlank=false)

  ##### Summary

  Return string without non-Alphanumeric chars.

  Non-Alphanumeric chars are removed.
  
  ##### Parameters
  
  - bool keepBlank
  
    default set to false.
    
    If set to true, blank are kept exept if they are at the end of the chain.
