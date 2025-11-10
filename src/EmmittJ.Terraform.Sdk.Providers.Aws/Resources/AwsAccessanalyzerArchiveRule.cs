using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAccessanalyzerArchiveRuleFilterBlock : TerraformBlock
{
    /// <summary>
    /// The contains attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Contains
    {
        get => GetProperty<List<TerraformProperty<string>>>("contains");
        set => WithProperty("contains", value);
    }

    /// <summary>
    /// The criteria attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    public required TerraformProperty<string> Criteria
    {
        get => GetProperty<TerraformProperty<string>>("criteria");
        set => WithProperty("criteria", value);
    }

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Eq
    {
        get => GetProperty<List<TerraformProperty<string>>>("eq");
        set => WithProperty("eq", value);
    }

    /// <summary>
    /// The exists attribute.
    /// </summary>
    public TerraformProperty<string>? Exists
    {
        get => GetProperty<TerraformProperty<string>>("exists");
        set => WithProperty("exists", value);
    }

    /// <summary>
    /// The neq attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Neq
    {
        get => GetProperty<List<TerraformProperty<string>>>("neq");
        set => WithProperty("neq", value);
    }

}

/// <summary>
/// Manages a aws_accessanalyzer_archive_rule resource.
/// </summary>
public class AwsAccessanalyzerArchiveRule : TerraformResource
{
    public AwsAccessanalyzerArchiveRule(string name) : base("aws_accessanalyzer_archive_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalyzerName is required")]
    public required TerraformProperty<string> AnalyzerName
    {
        get => GetProperty<TerraformProperty<string>>("analyzer_name");
        set => this.WithProperty("analyzer_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    public HashSet<AwsAccessanalyzerArchiveRuleFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsAccessanalyzerArchiveRuleFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

}
