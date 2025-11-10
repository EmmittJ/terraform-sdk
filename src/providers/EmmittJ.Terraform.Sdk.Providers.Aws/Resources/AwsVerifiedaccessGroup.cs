using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sse_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessGroupSseConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformPropertyName("policy_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyDocument { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    [TerraformPropertyName("verifiedaccess_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VerifiedaccessInstanceId { get; set; }

    /// <summary>
    /// Block for sse_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseConfiguration block(s) allowed")]
    [TerraformPropertyName("sse_configuration")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessGroupSseConfigurationBlock>>? SseConfiguration { get; set; } = new();

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The deletion_time attribute.
    /// </summary>
    [TerraformPropertyName("deletion_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_time");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The verifiedaccess_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("verifiedaccess_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VerifiedaccessGroupArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "verifiedaccess_group_arn");

    /// <summary>
    /// The verifiedaccess_group_id attribute.
    /// </summary>
    [TerraformPropertyName("verifiedaccess_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VerifiedaccessGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "verifiedaccess_group_id");

}
