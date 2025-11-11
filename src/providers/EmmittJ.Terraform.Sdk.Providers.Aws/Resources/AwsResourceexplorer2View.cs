using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public partial class AwsResourceexplorer2ViewFiltersBlock : TerraformBlockBase
{
    /// <summary>
    /// The filter_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterString is required")]
    [TerraformProperty("filter_string")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FilterString { get; set; }

}

/// <summary>
/// Block type for included_property in .
/// Nesting mode: list
/// </summary>
public partial class AwsResourceexplorer2ViewIncludedPropertyBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_resourceexplorer2_view resource.
/// </summary>
public partial class AwsResourceexplorer2View : TerraformResource
{
    public AwsResourceexplorer2View(string name) : base("aws_resourceexplorer2_view", name)
    {
    }

    /// <summary>
    /// The default_view attribute.
    /// </summary>
    [TerraformProperty("default_view")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DefaultView { get; set; }

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
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("filters")]
    public TerraformList<TerraformBlock<AwsResourceexplorer2ViewFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// Block for included_property.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("included_property")]
    public TerraformList<TerraformBlock<AwsResourceexplorer2ViewIncludedPropertyBlock>>? IncludedProperty { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
