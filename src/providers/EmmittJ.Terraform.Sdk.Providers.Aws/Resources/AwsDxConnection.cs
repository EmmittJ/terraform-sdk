using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_connection resource.
/// </summary>
public partial class AwsDxConnection : TerraformResource
{
    public AwsDxConnection(string name) : base("aws_dx_connection", name)
    {
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    [TerraformProperty("bandwidth")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bandwidth { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformProperty("encryption_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EncryptionMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ProviderName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_macsec attribute.
    /// </summary>
    [TerraformProperty("request_macsec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequestMacsec { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipDestroy { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformProperty("aws_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsDevice { get; }

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformProperty("has_logical_redundancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HasLogicalRedundancy { get; }

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformProperty("jumbo_frame_capable")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> JumboFrameCapable { get; }

    /// <summary>
    /// The macsec_capable attribute.
    /// </summary>
    [TerraformProperty("macsec_capable")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MacsecCapable { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerAccountId { get; }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformProperty("partner_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PartnerName { get; }

    /// <summary>
    /// The port_encryption_status attribute.
    /// </summary>
    [TerraformProperty("port_encryption_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PortEncryptionStatus { get; }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformProperty("vlan_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> VlanId { get; }

}
