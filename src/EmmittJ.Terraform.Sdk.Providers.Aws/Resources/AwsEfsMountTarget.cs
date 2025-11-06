using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_efs_mount_target resource.
/// </summary>
public class AwsEfsMountTarget : TerraformResource
{
    public AwsEfsMountTarget(string name) : base("aws_efs_mount_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("availability_zone_id");
        this.DeclareOutput("availability_zone_name");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("file_system_arn");
        this.DeclareOutput("mount_target_dns_name");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("owner_id");
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
    /// The ip_address attribute.
    /// </summary>
    public string? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address")?.Value;
        set => this.WithProperty("ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public string? Ipv6Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_address")?.Value;
        set => this.WithProperty("ipv6_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
