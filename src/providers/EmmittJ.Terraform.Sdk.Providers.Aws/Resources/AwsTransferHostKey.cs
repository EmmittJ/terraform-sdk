using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_host_key resource.
/// </summary>
public class AwsTransferHostKey : TerraformResource
{
    public AwsTransferHostKey(string name) : base("aws_transfer_host_key", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The host_key_body attribute.
    /// </summary>
    [TerraformPropertyName("host_key_body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostKeyBody { get; set; }

    /// <summary>
    /// The host_key_body_wo attribute.
    /// </summary>
    [TerraformPropertyName("host_key_body_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostKeyBodyWo { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("host_key_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostKeyFingerprint => new TerraformReference(this, "host_key_fingerprint");

    /// <summary>
    /// The host_key_id attribute.
    /// </summary>
    [TerraformPropertyName("host_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostKeyId => new TerraformReference(this, "host_key_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
