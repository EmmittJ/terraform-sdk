using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_instance.
/// </summary>
public class AwsDmsReplicationInstanceDataSource : TerraformDataSource
{
    public AwsDmsReplicationInstanceDataSource(string name) : base("aws_dms_replication_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("auto_minor_version_upgrade");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("kms_key_arn");
        this.DeclareOutput("multi_az");
        this.DeclareOutput("network_type");
        this.DeclareOutput("preferred_maintenance_window");
        this.DeclareOutput("publicly_accessible");
        this.DeclareOutput("replication_instance_arn");
        this.DeclareOutput("replication_instance_class");
        this.DeclareOutput("replication_instance_private_ips");
        this.DeclareOutput("replication_instance_public_ips");
        this.DeclareOutput("replication_subnet_group_id");
        this.DeclareOutput("vpc_security_group_ids");
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
    /// The replication_instance_id attribute.
    /// </summary>
    public string? ReplicationInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_instance_id")?.Value;
        set => this.WithProperty("replication_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformExpression AllocatedStorage => this["allocated_storage"];

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformExpression AutoMinorVersionUpgrade => this["auto_minor_version_upgrade"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformExpression MultiAz => this["multi_az"];

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformExpression NetworkType => this["network_type"];

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformExpression PreferredMaintenanceWindow => this["preferred_maintenance_window"];

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformExpression PubliclyAccessible => this["publicly_accessible"];

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationInstanceArn => this["replication_instance_arn"];

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    public TerraformExpression ReplicationInstanceClass => this["replication_instance_class"];

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    public TerraformExpression ReplicationInstancePrivateIps => this["replication_instance_private_ips"];

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    public TerraformExpression ReplicationInstancePublicIps => this["replication_instance_public_ips"];

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformExpression ReplicationSubnetGroupId => this["replication_subnet_group_id"];

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroupIds => this["vpc_security_group_ids"];

}
