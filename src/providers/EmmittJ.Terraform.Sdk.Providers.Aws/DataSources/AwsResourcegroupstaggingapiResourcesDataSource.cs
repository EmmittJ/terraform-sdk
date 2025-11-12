using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tag_filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock() : TerraformBlock("tag_filter")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformProperty("values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_resourcegroupstaggingapi_resources.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsResourcegroupstaggingapiResourcesDataSource : TerraformDataSource
{
    public AwsResourcegroupstaggingapiResourcesDataSource(string name) : base("aws_resourcegroupstaggingapi_resources", name)
    {
    }

    /// <summary>
    /// The exclude_compliant_resources attribute.
    /// </summary>
    [TerraformProperty("exclude_compliant_resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeCompliantResources { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_compliance_details attribute.
    /// </summary>
    [TerraformProperty("include_compliance_details")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeComplianceDetails { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_arn_list attribute.
    /// </summary>
    [TerraformProperty("resource_arn_list")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ResourceArnList { get; set; }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    [TerraformProperty("resource_type_filters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ResourceTypeFilters { get; set; }

    /// <summary>
    /// Block for tag_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagFilter block(s) allowed")]
    [TerraformProperty("tag_filter")]
    public TerraformList<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock> TagFilter { get; set; } = new();

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    [TerraformProperty("resource_tag_mapping_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ResourceTagMappingList { get; }

}
