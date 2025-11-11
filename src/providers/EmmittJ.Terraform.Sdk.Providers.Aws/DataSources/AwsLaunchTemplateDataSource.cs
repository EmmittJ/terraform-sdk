using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsLaunchTemplateDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLaunchTemplateDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_launch_template.
/// </summary>
public partial class AwsLaunchTemplateDataSource : TerraformDataSource
{
    public AwsLaunchTemplateDataSource(string name) : base("aws_launch_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsLaunchTemplateDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsLaunchTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    [TerraformProperty("block_device_mappings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BlockDeviceMappings { get; }

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_specification")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CapacityReservationSpecification { get; }

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    [TerraformProperty("cpu_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CpuOptions { get; }

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    [TerraformProperty("credit_specification")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CreditSpecification { get; }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformProperty("default_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DefaultVersion { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformProperty("disable_api_stop")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DisableApiStop { get; }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformProperty("disable_api_termination")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DisableApiTermination { get; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EbsOptimized { get; }

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    [TerraformProperty("enclave_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EnclaveOptions { get; }

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    [TerraformProperty("hibernation_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HibernationOptions { get; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IamInstanceProfile { get; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageId { get; }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformProperty("instance_initiated_shutdown_behavior")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceInitiatedShutdownBehavior { get; }

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    [TerraformProperty("instance_market_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InstanceMarketOptions { get; }

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    [TerraformProperty("instance_requirements")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InstanceRequirements { get; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformProperty("kernel_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KernelId { get; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyName { get; }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformProperty("latest_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LatestVersion { get; }

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    [TerraformProperty("license_specification")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LicenseSpecification { get; }

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    [TerraformProperty("maintenance_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceOptions { get; }

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformProperty("metadata_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MetadataOptions { get; }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformProperty("monitoring")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Monitoring { get; }

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    [TerraformProperty("network_interfaces")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkInterfaces { get; }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    [TerraformProperty("placement")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Placement { get; }

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    [TerraformProperty("private_dns_name_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrivateDnsNameOptions { get; }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    [TerraformProperty("ram_disk_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RamDiskId { get; }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformProperty("security_group_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroupNames { get; }

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    [TerraformProperty("tag_specifications")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TagSpecifications { get; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserData { get; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> VpcSecurityGroupIds { get; }

}
