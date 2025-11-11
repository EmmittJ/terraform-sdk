using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudformation in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruResourceCollectionCloudformationBlock : TerraformBlockBase
{
    /// <summary>
    /// The stack_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackNames is required")]
    [TerraformProperty("stack_names")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? StackNames { get; set; }

}

/// <summary>
/// Block type for tags in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruResourceCollectionTagsBlock : TerraformBlockBase
{
    /// <summary>
    /// The app_boundary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBoundaryKey is required")]
    [TerraformProperty("app_boundary_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppBoundaryKey { get; set; }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    [TerraformProperty("tag_values")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? TagValues { get; set; }

}

/// <summary>
/// Manages a aws_devopsguru_resource_collection resource.
/// </summary>
public partial class AwsDevopsguruResourceCollection : TerraformResource
{
    public AwsDevopsguruResourceCollection(string name) : base("aws_devopsguru_resource_collection", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for cloudformation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cloudformation")]
    public TerraformList<TerraformBlock<AwsDevopsguruResourceCollectionCloudformationBlock>>? Cloudformation { get; set; }

    /// <summary>
    /// Block for tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tags")]
    public TerraformList<TerraformBlock<AwsDevopsguruResourceCollectionTagsBlock>>? Tags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
