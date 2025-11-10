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
        set => SetProperty("contains", value);
    }

    /// <summary>
    /// The criteria attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    public required TerraformProperty<string> Criteria
    {
        set => SetProperty("criteria", value);
    }

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Eq
    {
        set => SetProperty("eq", value);
    }

    /// <summary>
    /// The exists attribute.
    /// </summary>
    public TerraformProperty<string>? Exists
    {
        set => SetProperty("exists", value);
    }

    /// <summary>
    /// The neq attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Neq
    {
        set => SetProperty("neq", value);
    }

}

/// <summary>
/// Manages a aws_accessanalyzer_archive_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAccessanalyzerArchiveRule : TerraformResource
{
    public AwsAccessanalyzerArchiveRule(string name) : base("aws_accessanalyzer_archive_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("analyzer_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("rule_name");
    }

    /// <summary>
    /// The analyzer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalyzerName is required")]
    public required TerraformProperty<string> AnalyzerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("analyzer_name");
        set => SetProperty("analyzer_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_name");
        set => SetProperty("rule_name", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    public HashSet<AwsAccessanalyzerArchiveRuleFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

}
