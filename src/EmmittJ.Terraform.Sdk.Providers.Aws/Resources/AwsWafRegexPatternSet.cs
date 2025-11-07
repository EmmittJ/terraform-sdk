using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_waf_regex_pattern_set resource.
/// </summary>
public class AwsWafRegexPatternSet : TerraformResource
{
    public AwsWafRegexPatternSet(string name) : base("aws_waf_regex_pattern_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The regex_pattern_strings attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? RegexPatternStrings
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("regex_pattern_strings");
        set => this.WithProperty("regex_pattern_strings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
