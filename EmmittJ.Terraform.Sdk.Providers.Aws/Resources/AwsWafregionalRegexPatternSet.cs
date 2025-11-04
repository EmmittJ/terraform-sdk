using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_wafregional_regex_pattern_set resource.
/// </summary>
public class AwsWafregionalRegexPatternSet : TerraformResource
{
    public AwsWafregionalRegexPatternSet(string name) : base("aws_wafregional_regex_pattern_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The regex_pattern_strings attribute.
    /// </summary>
    public HashSet<string>? RegexPatternStrings
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("regex_pattern_strings")?.Value;
        set => this.WithProperty("regex_pattern_strings", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
