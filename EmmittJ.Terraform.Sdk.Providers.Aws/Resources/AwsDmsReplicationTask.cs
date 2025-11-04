using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_replication_task resource.
/// </summary>
public class AwsDmsReplicationTask : TerraformResource
{
    public AwsDmsReplicationTask(string name) : base("aws_dms_replication_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("replication_task_arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    public string? CdcStartPosition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdc_start_position")?.Value;
        set => this.WithProperty("cdc_start_position", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public string? CdcStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdc_start_time")?.Value;
        set => this.WithProperty("cdc_start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The migration_type attribute.
    /// </summary>
    public string? MigrationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("migration_type")?.Value;
        set => this.WithProperty("migration_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public string? ReplicationInstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_instance_arn")?.Value;
        set => this.WithProperty("replication_instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    public string? ReplicationTaskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_task_id")?.Value;
        set => this.WithProperty("replication_task_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    public string? ReplicationTaskSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_task_settings")?.Value;
        set => this.WithProperty("replication_task_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public string? ResourceIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_identifier")?.Value;
        set => this.WithProperty("resource_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public string? SourceEndpointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_endpoint_arn")?.Value;
        set => this.WithProperty("source_endpoint_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    public bool? StartReplicationTask
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_replication_task")?.Value;
        set => this.WithProperty("start_replication_task", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public string? TableMappings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_mappings")?.Value;
        set => this.WithProperty("table_mappings", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public string? TargetEndpointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_endpoint_arn")?.Value;
        set => this.WithProperty("target_endpoint_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationTaskArn => this["replication_task_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
