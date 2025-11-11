using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tag_filter in .
/// Nesting mode: list
/// </summary>
public class AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformPropertyName("values")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Values { get; set; }

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
    public TerraformValue<bool>? ExcludeCompliantResources { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_compliance_details attribute.
    /// </summary>
    [TerraformPropertyName("include_compliance_details")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeComplianceDetails { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_arn_list attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn_list")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ResourceArnList { get; set; }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    [TerraformPropertyName("resource_type_filters")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ResourceTypeFilters { get; set; }

    /// <summary>
    /// Block for tag_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagFilter block(s) allowed")]
    [TerraformPropertyName("tag_filter")]
    public TerraformList<TerraformBlock<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock>>? TagFilter { get; set; }

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_mapping_list")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ResourceTagMappingList => new TerraformReference(this, "resource_tag_mapping_list");

}
