using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tag_filter in .
/// Nesting mode: list
/// </summary>
public class AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformPropertyName("values")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_resourcegroupstaggingapi_resources.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsResourcegroupstaggingapiResourcesDataSource : TerraformDataSource
{
    public AwsResourcegroupstaggingapiResourcesDataSource(string name) : base("aws_resourcegroupstaggingapi_resources", name)
    {
    }

    /// <summary>
    /// The exclude_compliant_resources attribute.
    /// </summary>
    [TerraformPropertyName("exclude_compliant_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExcludeCompliantResources { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_compliance_details attribute.
    /// </summary>
    [TerraformPropertyName("include_compliance_details")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeComplianceDetails { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_arn_list attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ResourceArnList { get; set; }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    [TerraformPropertyName("resource_type_filters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ResourceTypeFilters { get; set; }

    /// <summary>
    /// Block for tag_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagFilter block(s) allowed")]
    [TerraformPropertyName("tag_filter")]
    public TerraformList<TerraformBlock<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock>>? TagFilter { get; set; } = new();

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_mapping_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ResourceTagMappingList => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resource_tag_mapping_list");

}
