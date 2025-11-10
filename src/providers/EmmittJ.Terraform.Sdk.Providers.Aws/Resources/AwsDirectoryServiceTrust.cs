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
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ConditionalForwarderIpAddrs { get; set; }

    /// <summary>
    /// The delete_associated_conditional_forwarder attribute.
    /// </summary>
    [TerraformPropertyName("delete_associated_conditional_forwarder")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeleteAssociatedConditionalForwarder { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "delete_associated_conditional_forwarder");

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformPropertyName("directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DirectoryId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainName is required")]
    [TerraformPropertyName("remote_domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RemoteDomainName { get; set; }

    /// <summary>
    /// The selective_auth attribute.
    /// </summary>
    [TerraformPropertyName("selective_auth")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SelectiveAuth { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "selective_auth");

    /// <summary>
    /// The trust_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    [TerraformPropertyName("trust_direction")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TrustDirection { get; set; }

    /// <summary>
    /// The trust_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustPassword is required")]
    [TerraformPropertyName("trust_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TrustPassword { get; set; }

    /// <summary>
    /// The trust_type attribute.
    /// </summary>
    [TerraformPropertyName("trust_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TrustType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_type");

    /// <summary>
    /// The created_date_time attribute.
    /// </summary>
    [TerraformPropertyName("created_date_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedDateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_date_time");

    /// <summary>
    /// The state_last_updated_date_time attribute.
    /// </summary>
    [TerraformPropertyName("state_last_updated_date_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateLastUpdatedDateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_last_updated_date_time");

    /// <summary>
    /// The trust_state attribute.
    /// </summary>
    [TerraformPropertyName("trust_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_state");

    /// <summary>
    /// The trust_state_reason attribute.
    /// </summary>
    [TerraformPropertyName("trust_state_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustStateReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_state_reason");

}
