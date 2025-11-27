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
    public TerraformValue<string> CdcStartPosition
    {
        get => new TerraformReference<string>(this, "cdc_start_position");
        set => SetArgument("cdc_start_position", value);
    }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformValue<string>? CdcStartTime
    {
        get => new TerraformReference<string>(this, "cdc_start_time");
        set => SetArgument("cdc_start_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationType is required")]
    public required TerraformValue<string> MigrationType
    {
        get => new TerraformReference<string>(this, "migration_type");
        set => SetArgument("migration_type", value);
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
    /// The replication_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceArn is required")]
    public required TerraformValue<string> ReplicationInstanceArn
    {
        get => new TerraformReference<string>(this, "replication_instance_arn");
        set => SetArgument("replication_instance_arn", value);
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
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskSettings
    {
        get => new TerraformReference<string>(this, "replication_task_settings");
        set => SetArgument("replication_task_settings", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ResourceIdentifier
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
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformValue<bool>? StartReplicationTask
    {
        get => new TerraformReference<bool>(this, "start_replication_task");
        set => SetArgument("start_replication_task", value);
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
    /// The replication_task_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationTaskArn
    {
        get => new TerraformReference<string>(this, "replication_task_arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
