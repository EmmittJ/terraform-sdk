using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateDataSourceFilterBlock : ITerraformBlock
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
public class AwsLaunchTemplateDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    public TerraformSet<TerraformBlock<AwsLaunchTemplateDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLaunchTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    [TerraformPropertyName("block_device_mappings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BlockDeviceMappings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "block_device_mappings");

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_specification")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CapacityReservationSpecification => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "capacity_reservation_specification");

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    [TerraformPropertyName("cpu_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CpuOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cpu_options");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    [TerraformPropertyName("credit_specification")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CreditSpecification => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "credit_specification");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultVersion => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_stop")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableApiStop => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    [TerraformPropertyName("disable_api_termination")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableApiTermination => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_api_termination");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EbsOptimized => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    [TerraformPropertyName("enclave_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EnclaveOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "enclave_options");

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HibernationOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hibernation_options");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IamInstanceProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_id");

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    [TerraformPropertyName("instance_initiated_shutdown_behavior")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceInitiatedShutdownBehavior => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_initiated_shutdown_behavior");

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    [TerraformPropertyName("instance_market_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceMarketOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_market_options");

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    [TerraformPropertyName("instance_requirements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceRequirements => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_requirements");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    [TerraformPropertyName("kernel_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KernelId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kernel_id");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_name");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LatestVersion => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "latest_version");

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    [TerraformPropertyName("license_specification")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LicenseSpecification => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "license_specification");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    [TerraformPropertyName("metadata_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MetadataOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    [TerraformPropertyName("monitoring")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Monitoring => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "monitoring");

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    [TerraformPropertyName("network_interfaces")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkInterfaces => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_interfaces");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    [TerraformPropertyName("placement")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Placement => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "placement");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateDnsNameOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_dns_name_options");

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("ram_disk_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RamDiskId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ram_disk_id");

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    [TerraformPropertyName("security_group_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_names");

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    [TerraformPropertyName("tag_specifications")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TagSpecifications => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tag_specifications");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_data");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

}
