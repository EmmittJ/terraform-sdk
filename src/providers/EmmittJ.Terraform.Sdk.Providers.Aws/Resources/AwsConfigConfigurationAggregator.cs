using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_aggregation_source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationAggregatorAccountAggregationSourceBlock : TerraformBlock
{
    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountIds is required")]
    public List<TerraformProperty<string>>? AccountIds
    {
        set => SetProperty("account_ids", value);
    }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformProperty<bool>? AllRegions
    {
        set => SetProperty("all_regions", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        set => SetProperty("regions", value);
    }

}

/// <summary>
/// Block type for organization_aggregation_source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock : TerraformBlock
{
    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformProperty<bool>? AllRegions
    {
        set => SetProperty("all_regions", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

}

/// <summary>
/// Manages a aws_config_configuration_aggregator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigConfigurationAggregator : TerraformResource
{
    public AwsConfigConfigurationAggregator(string name) : base("aws_config_configuration_aggregator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for account_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountAggregationSource block(s) allowed")]
    public List<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>? AccountAggregationSource
    {
        set => SetProperty("account_aggregation_source", value);
    }

    /// <summary>
    /// Block for organization_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationAggregationSource block(s) allowed")]
    public List<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>? OrganizationAggregationSource
    {
        set => SetProperty("organization_aggregation_source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
