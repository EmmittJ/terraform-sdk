using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_detail in .
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderLifecyclePolicyPolicyDetailBlock
{
}

/// <summary>
/// Block type for resource_selection in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderLifecyclePolicyResourceSelectionBlock
{
    /// <summary>
    /// The tag_map attribute.
    /// </summary>
    [TerraformPropertyName("tag_map")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? TagMap { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_lifecycle_policy resource.
/// </summary>
public class AwsImagebuilderLifecyclePolicy : TerraformResource
{
    public AwsImagebuilderLifecyclePolicy(string name) : base("aws_imagebuilder_lifecycle_policy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    [TerraformPropertyName("execution_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExecutionRole { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformPropertyName("resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for policy_detail.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("policy_detail")]
    public TerraformSet<TerraformBlock<AwsImagebuilderLifecyclePolicyPolicyDetailBlock>>? PolicyDetail { get; set; }

    /// <summary>
    /// Block for resource_selection.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("resource_selection")]
    public TerraformList<TerraformBlock<AwsImagebuilderLifecyclePolicyResourceSelectionBlock>>? ResourceSelection { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
