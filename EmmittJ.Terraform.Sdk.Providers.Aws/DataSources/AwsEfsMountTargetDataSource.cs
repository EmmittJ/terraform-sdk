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
        this.DeclareOutput("availability_zone_id");
        this.DeclareOutput("availability_zone_name");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("file_system_arn");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("ip_address_type");
        this.DeclareOutput("ipv6_address");
        this.DeclareOutput("mount_target_dns_name");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("security_groups");
        this.DeclareOutput("subnet_id");
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    public string? AccessPointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_point_id")?.Value;
        set => this.WithProperty("access_point_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public string? FileSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_id")?.Value;
        set => this.WithProperty("file_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mount_target_id attribute.
    /// </summary>
    public string? MountTargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mount_target_id")?.Value;
        set => this.WithProperty("mount_target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
