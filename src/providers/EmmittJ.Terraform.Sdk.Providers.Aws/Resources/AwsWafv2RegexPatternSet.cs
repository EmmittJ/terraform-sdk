using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regular_expression in .
/// Nesting mode: set
/// </summary>
public class AwsWafv2RegexPatternSetRegularExpressionBlock : TerraformBlock
{
    /// <summary>
    /// The regex_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexString is required")]
    public required TerraformProperty<string> RegexString
    {
        set => SetProperty("regex_string", value);
    }

}

/// <summary>
/// Manages a aws_wafv2_regex_pattern_set resource.
/// </summary>
public class AwsWafv2RegexPatternSet : TerraformResource
{
    public AwsWafv2RegexPatternSet(string name) : base("aws_wafv2_regex_pattern_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("lock_token");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("scope");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for regular_expression.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafv2RegexPatternSetRegularExpressionBlock>? RegularExpression
    {
        set => SetProperty("regular_expression", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The lock_token attribute.
    /// </summary>
    public TerraformExpression LockToken => this["lock_token"];

}
