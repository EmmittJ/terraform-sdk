using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_replication_instance resource.
/// </summary>
public class AwsDmsReplicationInstance : TerraformResource
{
    public AwsDmsReplicationInstance(string name) : base("aws_dms_replication_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("replication_instance_arn");
        this.DeclareOutput("replication_instance_private_ips");
        this.DeclareOutput("replication_instance_public_ips");
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformProperty<double>? AllocatedStorage
    {
        get => GetProperty<TerraformProperty<double>>("allocated_storage");
        set => this.WithProperty("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => this.WithProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformProperty<string>? DnsNameServers
    {
        get => GetProperty<TerraformProperty<string>>("dns_name_servers");
        set => this.WithProperty("dns_name_servers", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkType
    {
        get => GetProperty<TerraformProperty<string>>("network_type");
        set => this.WithProperty("network_type", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
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
    /// The replication_instance_class attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationInstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("replication_instance_class");
        set => this.WithProperty("replication_instance_class", value);
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("replication_instance_id");
        set => this.WithProperty("replication_instance_id", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSubnetGroupId
    {
        get => GetProperty<TerraformProperty<string>>("replication_subnet_group_id");
        set => this.WithProperty("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationInstanceArn => this["replication_instance_arn"];

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    public TerraformExpression ReplicationInstancePrivateIps => this["replication_instance_private_ips"];

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    public TerraformExpression ReplicationInstancePublicIps => this["replication_instance_public_ips"];

}
