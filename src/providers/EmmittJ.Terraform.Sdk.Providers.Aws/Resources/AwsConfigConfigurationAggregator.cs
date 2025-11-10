using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_aggregation_source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationAggregatorAccountAggregationSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountIds is required")]
    [TerraformPropertyName("account_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AccountIds { get; set; }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    [TerraformPropertyName("all_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllRegions { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Regions { get; set; }

}

/// <summary>
/// Block type for organization_aggregation_source in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    [TerraformPropertyName("all_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllRegions { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Regions { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Manages a aws_config_configuration_aggregator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigConfigurationAggregator : TerraformResource
{
    public AwsConfigConfigurationAggregator(string name) : base("aws_config_configuration_aggregator", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for account_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountAggregationSource block(s) allowed")]
    [TerraformPropertyName("account_aggregation_source")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>>? AccountAggregationSource { get; set; } = new();

    /// <summary>
    /// Block for organization_aggregation_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationAggregationSource block(s) allowed")]
    [TerraformPropertyName("organization_aggregation_source")]
    public TerraformList<TerraformBlock<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>>? OrganizationAggregationSource { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
