using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sse_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessGroupSseConfigurationBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Manages a aws_verifiedaccess_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessGroup : TerraformResource
{
    public AwsVerifiedaccessGroup(string name) : base("aws_verifiedaccess_group", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformPropertyName("policy_document")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyDocument { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    [TerraformPropertyName("verifiedaccess_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VerifiedaccessInstanceId { get; set; }

    /// <summary>
    /// Block for sse_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseConfiguration block(s) allowed")]
    [TerraformPropertyName("sse_configuration")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessGroupSseConfigurationBlock>>? SseConfiguration { get; set; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The deletion_time attribute.
    /// </summary>
    [TerraformPropertyName("deletion_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeletionTime => new TerraformReference(this, "deletion_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedTime => new TerraformReference(this, "last_updated_time");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The verifiedaccess_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("verifiedaccess_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VerifiedaccessGroupArn => new TerraformReference(this, "verifiedaccess_group_arn");

    /// <summary>
    /// The verifiedaccess_group_id attribute.
    /// </summary>
    [TerraformPropertyName("verifiedaccess_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VerifiedaccessGroupId => new TerraformReference(this, "verifiedaccess_group_id");

}
