using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchConfigurationEbsBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeviceName { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Encrypted { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformPropertyName("no_device")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoDevice { get; set; }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SnapshotId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "snapshot_id");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Throughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "throughput");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> VolumeSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "volume_size");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VolumeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_type");

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchConfigurationEphemeralBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformPropertyName("no_device")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualName { get; set; }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchConfigurationMetadataOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("http_endpoint")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpEndpoint { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "http_endpoint");

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformPropertyName("http_put_response_hop_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> HttpPutResponseHopLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "http_put_response_hop_limit");

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformPropertyName("http_tokens")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpTokens { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "http_tokens");

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchConfigurationRootBlockDeviceBlock : ITerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteOnTermination { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Encrypted { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Throughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "throughput");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> VolumeSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "volume_size");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VolumeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_type");

}

/// <summary>
/// Manages a aws_launch_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLaunchConfiguration : TerraformResource
{
    public AwsLaunchConfiguration(string name) : base("aws_launch_configuration", name)
    {
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("associate_public_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AssociatePublicIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "associate_public_ip_address");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EbsOptimized { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ebs_optimized");

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("enable_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableMonitoring { get; set; }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("iam_instance_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamInstanceProfile { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    [TerraformPropertyName("image_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImageId { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_name");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("placement_tenancy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlacementTenancy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroups { get; set; }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    [TerraformPropertyName("spot_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpotPrice { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserData { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserDataBase64 { get; set; }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_block_device")]
    public TerraformSet<TerraformBlock<AwsLaunchConfigurationEbsBlockDeviceBlock>>? EbsBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ephemeral_block_device")]
    public TerraformSet<TerraformBlock<AwsLaunchConfigurationEphemeralBlockDeviceBlock>>? EphemeralBlockDevice { get; set; } = new();

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    [TerraformPropertyName("metadata_options")]
    public TerraformList<TerraformBlock<AwsLaunchConfigurationMetadataOptionsBlock>>? MetadataOptions { get; set; } = new();

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    [TerraformPropertyName("root_block_device")]
    public TerraformList<TerraformBlock<AwsLaunchConfigurationRootBlockDeviceBlock>>? RootBlockDevice { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
