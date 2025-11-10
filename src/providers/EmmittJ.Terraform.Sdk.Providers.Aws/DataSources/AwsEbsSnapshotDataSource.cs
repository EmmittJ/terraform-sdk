using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEbsSnapshotDataSourceFilterBlock : ITerraformBlock
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
public class AwsEbsSnapshotDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ebs_snapshot.
/// </summary>
public class AwsEbsSnapshotDataSource : TerraformDataSource
{
    public AwsEbsSnapshotDataSource(string name) : base("aws_ebs_snapshot", name)
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
    /// The owners attribute.
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Owners { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The restorable_by_user_ids attribute.
    /// </summary>
    [TerraformPropertyName("restorable_by_user_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? RestorableByUserIds { get; set; }

    /// <summary>
    /// The snapshot_ids attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SnapshotIds { get; set; }

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
    public TerraformSet<TerraformBlock<AwsEbsSnapshotDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEbsSnapshotDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    [TerraformPropertyName("data_encryption_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataEncryptionKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_encryption_key_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    [TerraformPropertyName("owner_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_alias");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_id");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    [TerraformPropertyName("storage_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_tier");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VolumeSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "volume_size");

}
