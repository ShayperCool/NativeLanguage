extern "C"
{
    char* NativeLocale_GetLanguage()
    {
        NSString * language = [[NSLocale preferredLanguages] firstObject];
        
        return cStringCopy([language UTF8String]);
    }
}

char* cStringCopy(const char* string)
{
    if (string == NULL)
        return NULL;

    char* res = (char*)malloc(strlen(string) + 1);
    strcpy(res, string);

    return res;
}