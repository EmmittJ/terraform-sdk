using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_replication_task Terraform resource.
/// Manages a aws_dms_replication_task resource.
/// </summary>
public partial class AwsDmsReplicationTask(string name) : TerraformResource("aws_dms_replication_task", name)
{
    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    public TerraformValue<string>? CdcStartPosition
    {
        get => GetArgument<TerraformValue<string>>("cdc_start_position");
        set => SetArgument("cdc_start_position", value);
    }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformValue<string>? CdcStartTime
    {
        get => GetArgument<TerraformValue<string>>("cdc_start_time");
        set => SetArgument("cdc_start_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationType is required")]
    public required TerraformValue<string> MigrationType
    {
        get => GetArgument<TerraformValue<string>>("migration_type");
        set => SetArgument("migration_type", value);
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
    /// The replication_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceArn is required")]
    public required TerraformValue<string> ReplicationInstanceArn
    {
        get => GetArgument<TerraformValue<string>>("replication_instance_arn");
        set => SetArgument("replication_instance_arn", value);
    }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    public required TerraformValue<string> ReplicationTaskId
    {
        get => GetArgument<TerraformValue<string>>("replication_task_id");
        set => SetArgument("replication_task_id", value);
    }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationTaskSettings
    {
        get => GetArgument<TerraformValue<string>>("replication_task_settings");
        set => SetArgument("replication_task_settings", value);
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
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformValue<bool>? StartReplicationTask
    {
        get => GetArgument<TerraformValue<bool>>("start_replication_task");
        set => SetArgument("start_replication_task", value);
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
    /// The replication_task_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskArn
        => AsReference("replication_task_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
