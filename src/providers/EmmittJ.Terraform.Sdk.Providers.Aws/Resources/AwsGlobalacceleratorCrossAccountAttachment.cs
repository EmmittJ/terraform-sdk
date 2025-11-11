using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource in .
/// Nesting mode: set
/// </summary>
public partial class AwsGlobalacceleratorCrossAccountAttachmentResourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CidrBlock { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformProperty("endpoint_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndpointId { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_cross_account_attachment resource.
/// </summary>
public partial class AwsGlobalacceleratorCrossAccountAttachment : TerraformResource
{
    public AwsGlobalacceleratorCrossAccountAttachment(string name) : base("aws_globalaccelerator_cross_account_attachment", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The principals attribute.
    /// </summary>
    [TerraformProperty("principals")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Principals { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for resource.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("resource")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorCrossAccountAttachmentResourceBlock>>? Resource { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedTime { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
