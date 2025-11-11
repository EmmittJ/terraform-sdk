using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sse_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessGroupSseConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Manages a aws_verifiedaccess_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVerifiedaccessGroup : TerraformResource
{
    public AwsVerifiedaccessGroup(string name) : base("aws_verifiedaccess_group", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformProperty("policy_document")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PolicyDocument { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    [TerraformProperty("verifiedaccess_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VerifiedaccessInstanceId { get; set; }

    /// <summary>
    /// Block for sse_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseConfiguration block(s) allowed")]
    [TerraformProperty("sse_configuration")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessGroupSseConfigurationBlock>>? SseConfiguration { get; set; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The deletion_time attribute.
    /// </summary>
    [TerraformProperty("deletion_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeletionTime { get; }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedTime { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Owner { get; }

    /// <summary>
    /// The verifiedaccess_group_arn attribute.
    /// </summary>
    [TerraformProperty("verifiedaccess_group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VerifiedaccessGroupArn { get; }

    /// <summary>
    /// The verifiedaccess_group_id attribute.
    /// </summary>
    [TerraformProperty("verifiedaccess_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VerifiedaccessGroupId { get; }

}
