using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchConfigurationEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => WithProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<bool>? NoDevice
    {
        get => GetProperty<TerraformProperty<bool>>("no_device");
        set => WithProperty("no_device", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => WithProperty("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => WithProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => WithProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchConfigurationEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<bool>? NoDevice
    {
        get => GetProperty<TerraformProperty<bool>>("no_device");
        set => WithProperty("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_name");
        set => WithProperty("virtual_name", value);
    }

}

/// <summary>
/// Block type for metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchConfigurationMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? HttpEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("http_endpoint");
        set => WithProperty("http_endpoint", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPutResponseHopLimit
    {
        get => GetProperty<TerraformProperty<double>>("http_put_response_hop_limit");
        set => WithProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformProperty<string>? HttpTokens
    {
        get => GetProperty<TerraformProperty<string>>("http_tokens");
        set => WithProperty("http_tokens", value);
    }

}

/// <summary>
/// Block type for root_block_device in .
/// Nesting mode: list
/// </summary>
public class AwsLaunchConfigurationRootBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => WithProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => WithProperty("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => WithProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => WithProperty("volume_type", value);
    }

}

/// <summary>
/// Manages a aws_launch_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLaunchConfiguration : TerraformResource
{
    public AwsLaunchConfiguration(string name) : base("aws_launch_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformProperty<bool>>("associate_public_ip_address");
        set => this.WithProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("enable_monitoring");
        set => this.WithProperty("enable_monitoring", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile");
        set => this.WithProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    public required TerraformProperty<string> ImageId
    {
        get => GetProperty<TerraformProperty<string>>("image_id");
        set => this.WithProperty("image_id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementTenancy
    {
        get => GetProperty<TerraformProperty<string>>("placement_tenancy");
        set => this.WithProperty("placement_tenancy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformProperty<string>? SpotPrice
    {
        get => GetProperty<TerraformProperty<string>>("spot_price");
        set => this.WithProperty("spot_price", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? UserDataBase64
    {
        get => GetProperty<TerraformProperty<string>>("user_data_base64");
        set => this.WithProperty("user_data_base64", value);
    }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLaunchConfigurationEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetProperty<HashSet<AwsLaunchConfigurationEbsBlockDeviceBlock>>("ebs_block_device");
        set => this.WithProperty("ebs_block_device", value);
    }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLaunchConfigurationEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetProperty<HashSet<AwsLaunchConfigurationEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => this.WithProperty("ephemeral_block_device", value);
    }

    /// <summary>
    /// Block for metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public List<AwsLaunchConfigurationMetadataOptionsBlock>? MetadataOptions
    {
        get => GetProperty<List<AwsLaunchConfigurationMetadataOptionsBlock>>("metadata_options");
        set => this.WithProperty("metadata_options", value);
    }

    /// <summary>
    /// Block for root_block_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootBlockDevice block(s) allowed")]
    public List<AwsLaunchConfigurationRootBlockDeviceBlock>? RootBlockDevice
    {
        get => GetProperty<List<AwsLaunchConfigurationRootBlockDeviceBlock>>("root_block_device");
        set => this.WithProperty("root_block_device", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
