using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLaunchTemplateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_launch_template.
/// </summary>
public class AwsLaunchTemplateDataSource : TerraformDataSource
{
    public AwsLaunchTemplateDataSource(string name) : base("aws_launch_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsLaunchTemplateDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLaunchTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    [TerraformPropertyName("block_device_mappings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BlockDeviceMappings => new TerraformReference(this, "block_device_mappings");

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_specification")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CapacityReservationSpecification => new TerraformReference(this, "capacity_reservation_specification");

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    [TerraformPropertyName("cpu_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CpuOptions => new TerraformReference(this, "cpu_options");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    [TerraformPropertyName("credit_specification")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CreditSpecification => new TerraformReference(this, "credit_specification");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultVersion => new TerraformReference(this, "default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableApiStop => new TerraformReference(this, "disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableApiTermination => new TerraformReference(this, "disable_api_termination");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EbsOptimized => new TerraformReference(this, "ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    [TerraformPropertyName("enclave_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EnclaveOptions => new TerraformReference(this, "enclave_options");

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HibernationOptions => new TerraformReference(this, "hibernation_options");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IamInstanceProfile => new TerraformReference(this, "iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageId => new TerraformReference(this, "image_id");

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_initiated_shutdown_behavior")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceInitiatedShutdownBehavior => new TerraformReference(this, "instance_initiated_shutdown_behavior");

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    [TerraformPropertyName("instance_market_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceMarketOptions => new TerraformReference(this, "instance_market_options");

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    [TerraformPropertyName("instance_requirements")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceRequirements => new TerraformReference(this, "instance_requirements");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceType => new TerraformReference(this, "instance_type");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformPropertyName("kernel_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KernelId => new TerraformReference(this, "kernel_id");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyName => new TerraformReference(this, "key_name");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LatestVersion => new TerraformReference(this, "latest_version");

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    [TerraformPropertyName("license_specification")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LicenseSpecification => new TerraformReference(this, "license_specification");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceOptions => new TerraformReference(this, "maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MetadataOptions => new TerraformReference(this, "metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Monitoring => new TerraformReference(this, "monitoring");

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    [TerraformPropertyName("network_interfaces")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkInterfaces => new TerraformReference(this, "network_interfaces");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    [TerraformPropertyName("placement")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Placement => new TerraformReference(this, "placement");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateDnsNameOptions => new TerraformReference(this, "private_dns_name_options");

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("ram_disk_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RamDiskId => new TerraformReference(this, "ram_disk_id");

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformPropertyName("security_group_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroupNames => new TerraformReference(this, "security_group_names");

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    [TerraformPropertyName("tag_specifications")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TagSpecifications => new TerraformReference(this, "tag_specifications");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserData => new TerraformReference(this, "user_data");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpcSecurityGroupIds => new TerraformReference(this, "vpc_security_group_ids");

}
