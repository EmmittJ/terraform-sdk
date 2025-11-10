using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_mount_target.
/// </summary>
public class AwsEfsMountTargetDataSource : TerraformDataSource
{
    public AwsEfsMountTargetDataSource(string name) : base("aws_efs_mount_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("availability_zone_id");
        SetOutput("availability_zone_name");
        SetOutput("dns_name");
        SetOutput("file_system_arn");
        SetOutput("ip_address");
        SetOutput("ip_address_type");
        SetOutput("ipv6_address");
        SetOutput("mount_target_dns_name");
        SetOutput("network_interface_id");
        SetOutput("owner_id");
        SetOutput("security_groups");
        SetOutput("subnet_id");
        SetOutput("access_point_id");
        SetOutput("file_system_id");
        SetOutput("id");
        SetOutput("mount_target_id");
        SetOutput("region");
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    public TerraformProperty<string> AccessPointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_point_id");
        set => SetProperty("access_point_id", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string> FileSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_id");
        set => SetProperty("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The mount_target_id attribute.
    /// </summary>
    public TerraformProperty<string> MountTargetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mount_target_id");
        set => SetProperty("mount_target_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneName => this["availability_zone_name"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformExpression FileSystemArn => this["file_system_arn"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformExpression IpAddressType => this["ip_address_type"];

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformExpression Ipv6Address => this["ipv6_address"];

    /// <summary>
    /// The mount_target_dns_name attribute.
    /// </summary>
    public TerraformExpression MountTargetDnsName => this["mount_target_dns_name"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

}
