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
    public TerraformProperty<string>? CdcStartPosition
    {
        get => GetProperty<TerraformProperty<string>>("cdc_start_position");
        set => this.WithProperty("cdc_start_position", value);
    }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? CdcStartTime
    {
        get => GetProperty<TerraformProperty<string>>("cdc_start_time");
        set => this.WithProperty("cdc_start_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    public TerraformProperty<string>? MigrationType
    {
        get => GetProperty<TerraformProperty<string>>("migration_type");
        set => this.WithProperty("migration_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationInstanceArn
    {
        get => GetProperty<TerraformProperty<string>>("replication_instance_arn");
        set => this.WithProperty("replication_instance_arn", value);
    }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationTaskId
    {
        get => GetProperty<TerraformProperty<string>>("replication_task_id");
        set => this.WithProperty("replication_task_id", value);
    }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationTaskSettings
    {
        get => GetProperty<TerraformProperty<string>>("replication_task_settings");
        set => this.WithProperty("replication_task_settings", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("resource_identifier");
        set => this.WithProperty("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceEndpointArn
    {
        get => GetProperty<TerraformProperty<string>>("source_endpoint_arn");
        set => this.WithProperty("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformProperty<bool>? StartReplicationTask
    {
        get => GetProperty<TerraformProperty<bool>>("start_replication_task");
        set => this.WithProperty("start_replication_task", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public TerraformProperty<string>? TableMappings
    {
        get => GetProperty<TerraformProperty<string>>("table_mappings");
        set => this.WithProperty("table_mappings", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetEndpointArn
    {
        get => GetProperty<TerraformProperty<string>>("target_endpoint_arn");
        set => this.WithProperty("target_endpoint_arn", value);
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
