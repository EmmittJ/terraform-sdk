using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_cached_iscsi_volume resource.
/// </summary>
public class AwsStoragegatewayCachedIscsiVolume : TerraformResource
{
    public AwsStoragegatewayCachedIscsiVolume(string name) : base("aws_storagegateway_cached_iscsi_volume", name)
    {
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformPropertyName("gateway_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GatewayArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("kms_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformPropertyName("network_interface_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkInterfaceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotId { get; set; }

    /// <summary>
    /// The source_volume_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_volume_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceVolumeArn { get; set; }

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
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    [TerraformPropertyName("target_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetName { get; set; }

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSizeInBytes is required")]
    [TerraformPropertyName("volume_size_in_bytes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> VolumeSizeInBytes { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The chap_enabled attribute.
    /// </summary>
    [TerraformPropertyName("chap_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ChapEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "chap_enabled");

    /// <summary>
    /// The lun_number attribute.
    /// </summary>
    [TerraformPropertyName("lun_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LunNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "lun_number");

    /// <summary>
    /// The network_interface_port attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NetworkInterfacePort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "network_interface_port");

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_arn");

    /// <summary>
    /// The volume_arn attribute.
    /// </summary>
    [TerraformPropertyName("volume_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_arn");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_id");

}
