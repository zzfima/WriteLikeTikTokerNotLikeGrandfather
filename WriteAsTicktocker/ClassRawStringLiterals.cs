internal class ClassRawStringLiterals
{
    private static void MainRawStringLiterals(string[] args)
    {
        //{"key": "value"}
        var sampleJson1 = "{ \"key\" : \"value\" }";
        var sampleJson2 = "{ 'key' : 'value' }";
        var sampleJson3 = @"{ ""key"" : ""value"" }";
        var sampleJson4 = """{ "key" : "value" }""";

        string key = nameof(key);
        string value = nameof(value);

        string jsonWithFormat = $$"""{ "{{key}}" : "{{value}}" }""";
        string jsonWithMultipleFormat =
        $$"""
        { 
            "{{key}}" : "{{value}}",
            "{{key}}" : "{{value}}"
        }
        """;

        Console.Read();
    }
}