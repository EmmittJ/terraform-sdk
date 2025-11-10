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
        get => GetProperty<List<TerraformProperty<string>>>("account_ids");
        set => WithProperty("account_ids", value);
    }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformProperty<bool>? AllRegions
    {
        get => GetProperty<TerraformProperty<bool>>("all_regions");
        set => WithProperty("all_regions", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        get => GetProperty<List<TerraformProperty<string>>>("regions");
        set => WithProperty("regions", value);
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
        get => GetProperty<TerraformProperty<bool>>("all_regions");
        set => WithProperty("all_regions", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        get => GetProperty<List<TerraformProperty<string>>>("regions");
        set => WithProperty("regions", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for account_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountAggregationSource block(s) allowed")]
    public List<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>? AccountAggregationSource
    {
        get => GetProperty<List<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>>("account_aggregation_source");
        set => this.WithProperty("account_aggregation_source", value);
    }

    /// <summary>
    /// Block for organization_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationAggregationSource block(s) allowed")]
    public List<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>? OrganizationAggregationSource
    {
        get => GetProperty<List<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>>("organization_aggregation_source");
        set => this.WithProperty("organization_aggregation_source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
