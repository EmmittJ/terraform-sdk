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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    public required TerraformValue<string> ReplicationInstanceId
    {
        get => new TerraformReference<string>(this, "replication_instance_id");
        set => SetArgument("replication_instance_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
    {
        get => new TerraformReference<double>(this, "allocated_storage");
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceArn
    {
        get => new TerraformReference<string>(this, "replication_instance_arn");
    }

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceClass
    {
        get => new TerraformReference<string>(this, "replication_instance_class");
    }

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    public TerraformList<string> ReplicationInstancePrivateIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replication_instance_private_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    public TerraformList<string> ReplicationInstancePublicIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replication_instance_public_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupId
    {
        get => new TerraformReference<string>(this, "replication_subnet_group_id");
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
    }

}
