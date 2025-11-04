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
    public double? AllocatedStorage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocated_storage")?.Value;
        set => this.WithProperty("allocated_storage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public bool? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_major_version_upgrade")?.Value;
        set => this.WithProperty("allow_major_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public bool? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public bool? MultiAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_az")?.Value;
        set => this.WithProperty("multi_az", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public string? NetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_type")?.Value;
        set => this.WithProperty("network_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public string? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_maintenance_window")?.Value;
        set => this.WithProperty("preferred_maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    public string? ReplicationInstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_instance_class")?.Value;
        set => this.WithProperty("replication_instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    public string? ReplicationInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_instance_id")?.Value;
        set => this.WithProperty("replication_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public string? ReplicationSubnetGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_subnet_group_id")?.Value;
        set => this.WithProperty("replication_subnet_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
