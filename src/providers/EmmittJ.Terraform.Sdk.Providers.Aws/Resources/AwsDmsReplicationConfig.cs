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
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameServers
    {
        get => GetArgument<TerraformValue<string>>("dns_name_servers");
        set => SetArgument("dns_name_servers", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The max_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("max_capacity_units");
        set => SetArgument("max_capacity_units", value);
    }

    /// <summary>
    /// The min_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? MinCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("min_capacity_units");
        set => SetArgument("min_capacity_units", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool>? MultiAz
    {
        get => GetArgument<TerraformValue<bool>>("multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformValue<string> ReplicationSubnetGroupId
    {
        get => GetArgument<TerraformValue<string>>("replication_subnet_group_id");
        set => SetArgument("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    /// The replication_config_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationConfigIdentifier is required")]
    public required TerraformValue<string> ReplicationConfigIdentifier
    {
        get => GetArgument<TerraformValue<string>>("replication_config_identifier");
        set => SetArgument("replication_config_identifier", value);
    }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationSettings
    {
        get => GetArgument<TerraformValue<string>>("replication_settings");
        set => SetArgument("replication_settings", value);
    }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationType is required")]
    public required TerraformValue<string> ReplicationType
    {
        get => GetArgument<TerraformValue<string>>("replication_type");
        set => SetArgument("replication_type", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ResourceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("resource_identifier");
        set => SetArgument("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    public required TerraformValue<string> SourceEndpointArn
    {
        get => GetArgument<TerraformValue<string>>("source_endpoint_arn");
        set => SetArgument("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    public TerraformValue<bool>? StartReplication
    {
        get => GetArgument<TerraformValue<bool>>("start_replication");
        set => SetArgument("start_replication", value);
    }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    public TerraformValue<string>? SupplementalSettings
    {
        get => GetArgument<TerraformValue<string>>("supplemental_settings");
        set => SetArgument("supplemental_settings", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    public required TerraformValue<string> TableMappings
    {
        get => GetArgument<TerraformValue<string>>("table_mappings");
        set => SetArgument("table_mappings", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    public required TerraformValue<string> TargetEndpointArn
    {
        get => GetArgument<TerraformValue<string>>("target_endpoint_arn");
        set => SetArgument("target_endpoint_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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
