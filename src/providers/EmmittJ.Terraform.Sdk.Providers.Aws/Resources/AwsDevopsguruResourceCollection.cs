using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudformation in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruResourceCollectionCloudformationBlock
{
    /// <summary>
    /// The stack_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackNames is required")]
    [TerraformPropertyName("stack_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? StackNames { get; set; }

}

/// <summary>
/// Block type for tags in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruResourceCollectionTagsBlock
{
    /// <summary>
    /// The app_boundary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBoundaryKey is required")]
    [TerraformPropertyName("app_boundary_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppBoundaryKey { get; set; }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    [TerraformPropertyName("tag_values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? TagValues { get; set; }

}

/// <summary>
/// Manages a aws_devopsguru_resource_collection resource.
/// </summary>
public class AwsDevopsguruResourceCollection : TerraformResource
{
    public AwsDevopsguruResourceCollection(string name) : base("aws_devopsguru_resource_collection", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for cloudformation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cloudformation")]
    public TerraformList<TerraformBlock<AwsDevopsguruResourceCollectionCloudformationBlock>>? Cloudformation { get; set; }

    /// <summary>
    /// Block for tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("tags")]
    public TerraformList<TerraformBlock<AwsDevopsguruResourceCollectionTagsBlock>>? Tags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
