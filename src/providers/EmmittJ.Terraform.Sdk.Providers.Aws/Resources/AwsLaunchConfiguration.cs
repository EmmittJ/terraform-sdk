using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsLaunchConfigurationEbsBlockDeviceBlock() : TerraformBlock("ebs_block_device")
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformProperty("no_device")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NoDevice { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SnapshotId { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public partial class AwsLaunchConfigurationEphemeralBlockDeviceBlock() : TerraformBlock("ephemeral_block_device")
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformProperty("no_device")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformProperty("virtual_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchConfigurationMetadataOptionsBlock() : TerraformBlock("metadata_options")
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformProperty("http_endpoint")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpEndpoint { get; set; }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformProperty("http_put_response_hop_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> HttpPutResponseHopLimit { get; set; }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformProperty("http_tokens")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpTokens { get; set; }

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public partial class AwsLaunchConfigurationRootBlockDeviceBlock() : TerraformBlock("root_block_device")
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_on_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Manages a aws_launch_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLaunchConfiguration : TerraformResource
{
    public AwsLaunchConfiguration(string name) : base("aws_launch_configuration", name)
    {
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("associate_public_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AssociatePublicIpAddress { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EbsOptimized { get; set; }

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    [TerraformProperty("enable_monitoring")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMonitoring { get; set; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("iam_instance_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamInstanceProfile { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    [TerraformProperty("image_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageId { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformProperty("placement_tenancy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlacementTenancy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformProperty("spot_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpotPrice { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformProperty("user_data_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserDataBase64 { get; set; }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ebs_block_device")]
    public TerraformSet<AwsLaunchConfigurationEbsBlockDeviceBlock> EbsBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ephemeral_block_device")]
    public TerraformSet<AwsLaunchConfigurationEphemeralBlockDeviceBlock> EphemeralBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformProperty("metadata_options")]
    public TerraformList<AwsLaunchConfigurationMetadataOptionsBlock> MetadataOptions { get; set; } = new();

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    [TerraformProperty("root_block_device")]
    public TerraformList<AwsLaunchConfigurationRootBlockDeviceBlock> RootBlockDevice { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
