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
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    public required TerraformValue<string> ReplicationTaskId
    {
        get => new TerraformReference<string>(this, "replication_task_id");
        set => SetArgument("replication_task_id", value);
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
    /// The cdc_start_position attribute.
    /// </summary>
    public TerraformValue<string> CdcStartPosition
    {
        get => new TerraformReference<string>(this, "cdc_start_position");
    }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformValue<string> CdcStartTime
    {
        get => new TerraformReference<string>(this, "cdc_start_time");
    }

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    public TerraformValue<string> MigrationType
    {
        get => new TerraformReference<string>(this, "migration_type");
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceArn
    {
        get => new TerraformReference<string>(this, "replication_instance_arn");
    }

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskArn
    {
        get => new TerraformReference<string>(this, "replication_task_arn");
    }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskSettings
    {
        get => new TerraformReference<string>(this, "replication_task_settings");
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceEndpointArn
    {
        get => new TerraformReference<string>(this, "source_endpoint_arn");
    }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformValue<bool> StartReplicationTask
    {
        get => new TerraformReference<bool>(this, "start_replication_task");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public TerraformValue<string> TableMappings
    {
        get => new TerraformReference<string>(this, "table_mappings");
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> TargetEndpointArn
    {
        get => new TerraformReference<string>(this, "target_endpoint_arn");
    }

}
