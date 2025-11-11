using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_connection resource.
/// </summary>
public class AwsDxConnection : TerraformResource
{
    public AwsDxConnection(string name) : base("aws_dx_connection", name)
    {
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    [TerraformPropertyName("bandwidth")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bandwidth { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformPropertyName("encryption_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EncryptionMode { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProviderName { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The request_macsec attribute.
    /// </summary>
    [TerraformPropertyName("request_macsec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestMacsec { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipDestroy { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsDevice => new TerraformReference(this, "aws_device");

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("has_logical_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HasLogicalRedundancy => new TerraformReference(this, "has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformPropertyName("jumbo_frame_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> JumboFrameCapable => new TerraformReference(this, "jumbo_frame_capable");

    /// <summary>
    /// The macsec_capable attribute.
    /// </summary>
    [TerraformPropertyName("macsec_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MacsecCapable => new TerraformReference(this, "macsec_capable");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerAccountId => new TerraformReference(this, "owner_account_id");

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformPropertyName("partner_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PartnerName => new TerraformReference(this, "partner_name");

    /// <summary>
    /// The port_encryption_status attribute.
    /// </summary>
    [TerraformPropertyName("port_encryption_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortEncryptionStatus => new TerraformReference(this, "port_encryption_status");

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformPropertyName("vlan_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VlanId => new TerraformReference(this, "vlan_id");

}
