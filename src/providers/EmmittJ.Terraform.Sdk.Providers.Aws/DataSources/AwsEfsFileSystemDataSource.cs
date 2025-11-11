using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_file_system.
/// </summary>
public class AwsEfsFileSystemDataSource : TerraformDataSource
{
    public AwsEfsFileSystemDataSource(string name) : base("aws_efs_file_system", name)
    {
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    [TerraformPropertyName("creation_token")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CreationToken { get; set; } = default!;

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FileSystemId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneId => new TerraformReference(this, "availability_zone_id");

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneName => new TerraformReference(this, "availability_zone_name");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Encrypted => new TerraformReference(this, "encrypted");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LifecyclePolicy => new TerraformReference(this, "lifecycle_policy");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("performance_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PerformanceMode => new TerraformReference(this, "performance_mode");

    /// <summary>
    /// The protection attribute.
    /// </summary>
    [TerraformPropertyName("protection")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Protection => new TerraformReference(this, "protection");

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_throughput_in_mibps")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionedThroughputInMibps => new TerraformReference(this, "provisioned_throughput_in_mibps");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SizeInBytes => new TerraformReference(this, "size_in_bytes");

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ThroughputMode => new TerraformReference(this, "throughput_mode");

}
