using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEbsVolumeDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsVolumeDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ebs_volume.
/// </summary>
public class AwsEbsVolumeDataSource : TerraformDataSource
{
    public AwsEbsVolumeDataSource(string name) : base("aws_ebs_volume", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEbsVolumeDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEbsVolumeDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Iops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The multi_attach_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_attach_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiAttachEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_attach_enabled");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Size => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size");

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_id");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Throughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_id");

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    [TerraformPropertyName("volume_initialization_rate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VolumeInitializationRate => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "volume_initialization_rate");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_type");

}
