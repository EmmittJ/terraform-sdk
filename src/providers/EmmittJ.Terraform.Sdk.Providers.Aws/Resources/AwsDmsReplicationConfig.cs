using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_config in AwsDmsReplicationConfig.
/// Nesting mode: list
/// </summary>
public class AwsDmsReplicationConfigComputeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_config";

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameServers
    {
        get => new TerraformReference<string>(this, "dns_name_servers");
        set => SetArgument("dns_name_servers", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The max_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacityUnits
    {
        get => new TerraformReference<double>(this, "max_capacity_units");
        set => SetArgument("max_capacity_units", value);
    }

    /// <summary>
    /// The min_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? MinCapacityUnits
    {
        get => new TerraformReference<double>(this, "min_capacity_units");
        set => SetArgument("min_capacity_units", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformValue<string> ReplicationSubnetGroupId
    {
        get => new TerraformReference<string>(this, "replication_subnet_group_id");
        set => SetArgument("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDmsReplicationConfig.
/// Nesting mode: single
/// </summary>
public class AwsDmsReplicationConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_dms_replication_config Terraform resource.
/// Manages a aws_dms_replication_config resource.
/// </summary>
public partial class AwsDmsReplicationConfig(string name) : TerraformResource("aws_dms_replication_config", name)
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
    /// The replication_config_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationConfigIdentifier is required")]
    public required TerraformValue<string> ReplicationConfigIdentifier
    {
        get => new TerraformReference<string>(this, "replication_config_identifier");
        set => SetArgument("replication_config_identifier", value);
    }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSettings
    {
        get => new TerraformReference<string>(this, "replication_settings");
        set => SetArgument("replication_settings", value);
    }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationType is required")]
    public required TerraformValue<string> ReplicationType
    {
        get => new TerraformReference<string>(this, "replication_type");
        set => SetArgument("replication_type", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformValue<string> ResourceIdentifier
    {
        get => new TerraformReference<string>(this, "resource_identifier");
        set => SetArgument("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    public required TerraformValue<string> SourceEndpointArn
    {
        get => new TerraformReference<string>(this, "source_endpoint_arn");
        set => SetArgument("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    public TerraformValue<bool>? StartReplication
    {
        get => new TerraformReference<bool>(this, "start_replication");
        set => SetArgument("start_replication", value);
    }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    public TerraformValue<string>? SupplementalSettings
    {
        get => new TerraformReference<string>(this, "supplemental_settings");
        set => SetArgument("supplemental_settings", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    public required TerraformValue<string> TableMappings
    {
        get => new TerraformReference<string>(this, "table_mappings");
        set => SetArgument("table_mappings", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    public required TerraformValue<string> TargetEndpointArn
    {
        get => new TerraformReference<string>(this, "target_endpoint_arn");
        set => SetArgument("target_endpoint_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// ComputeConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    public required TerraformList<AwsDmsReplicationConfigComputeConfigBlock> ComputeConfig
    {
        get => GetRequiredArgument<TerraformList<AwsDmsReplicationConfigComputeConfigBlock>>("compute_config");
        set => SetArgument("compute_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDmsReplicationConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDmsReplicationConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
