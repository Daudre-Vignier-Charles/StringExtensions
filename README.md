# StringExtensions

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
