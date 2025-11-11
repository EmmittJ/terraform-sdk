using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_file_system.
/// </summary>
public partial class AwsEfsFileSystemDataSource : TerraformDataSource
{
    public AwsEfsFileSystemDataSource(string name) : base("aws_efs_file_system", name)
    {
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    [TerraformProperty("creation_token")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CreationToken { get; set; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformProperty("file_system_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FileSystemId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformProperty("availability_zone_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneName { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Encrypted { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformProperty("lifecycle_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LifecyclePolicy { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    [TerraformProperty("performance_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PerformanceMode { get; }

    /// <summary>
    /// The protection attribute.
    /// </summary>
    [TerraformProperty("protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Protection { get; }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    [TerraformProperty("provisioned_throughput_in_mibps")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProvisionedThroughputInMibps { get; }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SizeInBytes { get; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformProperty("throughput_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ThroughputMode { get; }

}
