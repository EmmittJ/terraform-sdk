using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_detail in .
/// Nesting mode: set
/// </summary>
public partial class AwsImagebuilderLifecyclePolicyPolicyDetailBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for resource_selection in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderLifecyclePolicyResourceSelectionBlock : TerraformBlockBase
{
    /// <summary>
    /// The tag_map attribute.
    /// </summary>
    [TerraformProperty("tag_map")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? TagMap { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_lifecycle_policy resource.
/// </summary>
public partial class AwsImagebuilderLifecyclePolicy : TerraformResource
{
    public AwsImagebuilderLifecyclePolicy(string name) : base("aws_imagebuilder_lifecycle_policy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    [TerraformProperty("execution_role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExecutionRole { get; set; }

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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for policy_detail.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("policy_detail")]
    public TerraformSet<TerraformBlock<AwsImagebuilderLifecyclePolicyPolicyDetailBlock>>? PolicyDetail { get; set; }

    /// <summary>
    /// Block for resource_selection.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("resource_selection")]
    public TerraformList<TerraformBlock<AwsImagebuilderLifecyclePolicyResourceSelectionBlock>>? ResourceSelection { get; set; }

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
