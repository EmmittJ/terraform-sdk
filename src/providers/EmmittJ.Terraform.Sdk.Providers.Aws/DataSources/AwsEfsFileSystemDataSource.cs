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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CreationToken { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_token");

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FileSystemId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_name");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

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
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LifecyclePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "lifecycle_policy");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("performance_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PerformanceMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "performance_mode");

    /// <summary>
    /// The protection attribute.
    /// </summary>
    [TerraformPropertyName("protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Protection => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "protection");

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_throughput_in_mibps")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProvisionedThroughputInMibps => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "provisioned_throughput_in_mibps");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SizeInBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size_in_bytes");

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ThroughputMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "throughput_mode");

}
