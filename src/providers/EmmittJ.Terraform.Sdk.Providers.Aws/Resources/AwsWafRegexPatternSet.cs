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
        this.WithOutput("arn");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The regex_pattern_strings attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RegexPatternStrings
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("regex_pattern_strings");
        set => this.WithProperty("regex_pattern_strings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
