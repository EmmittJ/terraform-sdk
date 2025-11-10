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
    public required TerraformProperty<TerraformProperty<string>> Bandwidth { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformPropertyName("encryption_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EncryptionMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_mode");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProviderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provider_name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_macsec attribute.
    /// </summary>
    [TerraformPropertyName("request_macsec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequestMacsec { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AwsDevice => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_device");

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("has_logical_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HasLogicalRedundancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformPropertyName("jumbo_frame_capable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> JumboFrameCapable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "jumbo_frame_capable");

    /// <summary>
    /// The macsec_capable attribute.
    /// </summary>
    [TerraformPropertyName("macsec_capable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MacsecCapable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "macsec_capable");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_account_id");

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformPropertyName("partner_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PartnerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partner_name");

    /// <summary>
    /// The port_encryption_status attribute.
    /// </summary>
    [TerraformPropertyName("port_encryption_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PortEncryptionStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "port_encryption_status");

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformPropertyName("vlan_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VlanId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "vlan_id");

}
