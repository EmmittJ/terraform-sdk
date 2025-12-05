using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_replication_task Terraform data source.
/// Retrieves information about a aws_dms_replication_task.
/// </summary>
public partial class AwsDmsReplicationTaskDataSource(string name) : TerraformDataSource("aws_dms_replication_task", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    public required TerraformValue<string> ReplicationTaskId
    {
        get => GetRequiredArgument<TerraformValue<string>>("replication_task_id");
        set => SetArgument("replication_task_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    public TerraformValue<string> CdcStartPosition
        => CreateReference("cdc_start_position");

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformValue<string> CdcStartTime
        => CreateReference("cdc_start_time");

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    public TerraformValue<string> MigrationType
        => CreateReference("migration_type");

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceArn
        => CreateReference("replication_instance_arn");

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskArn
        => CreateReference("replication_task_arn");

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskSettings
        => CreateReference("replication_task_settings");

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceEndpointArn
        => CreateReference("source_endpoint_arn");

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformValue<bool> StartReplicationTask
        => CreateReference("start_replication_task");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public TerraformValue<string> TableMappings
        => CreateReference("table_mappings");

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> TargetEndpointArn
        => CreateReference("target_endpoint_arn");

}
