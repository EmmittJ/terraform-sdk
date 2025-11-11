using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_aggregation_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigConfigurationAggregatorAccountAggregationSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountIds is required")]
    [TerraformProperty("account_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AccountIds { get; set; }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    [TerraformProperty("all_regions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllRegions { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Regions { get; set; }

}

/// <summary>
/// Block type for organization_aggregation_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    [TerraformProperty("all_regions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllRegions { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Regions { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Manages a aws_config_configuration_aggregator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConfigConfigurationAggregator : TerraformResource
{
    public AwsConfigConfigurationAggregator(string name) : base("aws_config_configuration_aggregator", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for account_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountAggregationSource block(s) allowed")]
    [TerraformProperty("account_aggregation_source")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>>? AccountAggregationSource { get; set; }

    /// <summary>
    /// Block for organization_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationAggregationSource block(s) allowed")]
    [TerraformProperty("organization_aggregation_source")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>>? OrganizationAggregationSource { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
