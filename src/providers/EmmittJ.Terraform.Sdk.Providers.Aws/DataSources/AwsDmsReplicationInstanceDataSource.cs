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
        SetOutput("allocated_storage");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("availability_zone");
        SetOutput("engine_version");
        SetOutput("kms_key_arn");
        SetOutput("multi_az");
        SetOutput("network_type");
        SetOutput("preferred_maintenance_window");
        SetOutput("publicly_accessible");
        SetOutput("replication_instance_arn");
        SetOutput("replication_instance_class");
        SetOutput("replication_instance_private_ips");
        SetOutput("replication_instance_public_ips");
        SetOutput("replication_subnet_group_id");
        SetOutput("vpc_security_group_ids");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replication_instance_id");
        SetOutput("tags");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    public required TerraformProperty<string> ReplicationInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_instance_id");
        set => SetProperty("replication_instance_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
