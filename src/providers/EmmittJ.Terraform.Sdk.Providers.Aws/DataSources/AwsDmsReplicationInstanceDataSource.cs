using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_replication_instance Terraform data source.
/// Retrieves information about a aws_dms_replication_instance.
/// </summary>
public partial class AwsDmsReplicationInstanceDataSource(string name) : TerraformDataSource("aws_dms_replication_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    public required TerraformValue<string> ReplicationInstanceId
    {
        get => GetArgument<TerraformValue<string>>("replication_instance_id");
        set => SetArgument("replication_instance_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
        => AsReference("allocated_storage");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
        => AsReference("auto_minor_version_upgrade");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
        => AsReference("multi_az");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
        => AsReference("network_type");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
        => AsReference("preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
        => AsReference("publicly_accessible");

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceArn
        => AsReference("replication_instance_arn");

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceClass
        => AsReference("replication_instance_class");

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    public TerraformList<string> ReplicationInstancePrivateIps
        => AsReference("replication_instance_private_ips");

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    public TerraformList<string> ReplicationInstancePublicIps
        => AsReference("replication_instance_public_ips");

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupId
        => AsReference("replication_subnet_group_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => AsReference("vpc_security_group_ids");

}
