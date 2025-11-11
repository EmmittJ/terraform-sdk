using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_trust resource.
/// </summary>
public class AwsDirectoryServiceTrust : TerraformResource
{
    public AwsDirectoryServiceTrust(string name) : base("aws_directory_service_trust", name)
    {
    }

    /// <summary>
    /// The conditional_forwarder_ip_addrs attribute.
    /// </summary>
    [TerraformPropertyName("conditional_forwarder_ip_addrs")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ConditionalForwarderIpAddrs { get; set; }

    /// <summary>
    /// The delete_associated_conditional_forwarder attribute.
    /// </summary>
    [TerraformPropertyName("delete_associated_conditional_forwarder")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DeleteAssociatedConditionalForwarder { get; set; } = default!;

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformPropertyName("directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainName is required")]
    [TerraformPropertyName("remote_domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RemoteDomainName { get; set; }

    /// <summary>
    /// The selective_auth attribute.
    /// </summary>
    [TerraformPropertyName("selective_auth")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SelectiveAuth { get; set; } = default!;

    /// <summary>
    /// The trust_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    [TerraformPropertyName("trust_direction")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TrustDirection { get; set; }

    /// <summary>
    /// The trust_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustPassword is required")]
    [TerraformPropertyName("trust_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TrustPassword { get; set; }

    /// <summary>
    /// The trust_type attribute.
    /// </summary>
    [TerraformPropertyName("trust_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TrustType { get; set; } = default!;

    /// <summary>
    /// The created_date_time attribute.
    /// </summary>
    [TerraformPropertyName("created_date_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDateTime => new TerraformReference(this, "created_date_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedDateTime => new TerraformReference(this, "last_updated_date_time");

    /// <summary>
    /// The state_last_updated_date_time attribute.
    /// </summary>
    [TerraformPropertyName("state_last_updated_date_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateLastUpdatedDateTime => new TerraformReference(this, "state_last_updated_date_time");

    /// <summary>
    /// The trust_state attribute.
    /// </summary>
    [TerraformPropertyName("trust_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrustState => new TerraformReference(this, "trust_state");

    /// <summary>
    /// The trust_state_reason attribute.
    /// </summary>
    [TerraformPropertyName("trust_state_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrustStateReason => new TerraformReference(this, "trust_state_reason");

}
