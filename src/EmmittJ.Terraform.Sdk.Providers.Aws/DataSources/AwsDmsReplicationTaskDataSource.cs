using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_task.
/// </summary>
public class AwsDmsReplicationTaskDataSource : TerraformDataSource
{
    public AwsDmsReplicationTaskDataSource(string name) : base("aws_dms_replication_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cdc_start_position");
        this.DeclareOutput("cdc_start_time");
        this.DeclareOutput("migration_type");
        this.DeclareOutput("replication_instance_arn");
        this.DeclareOutput("replication_task_arn");
        this.DeclareOutput("replication_task_settings");
        this.DeclareOutput("source_endpoint_arn");
        this.DeclareOutput("start_replication_task");
        this.DeclareOutput("status");
        this.DeclareOutput("table_mappings");
        this.DeclareOutput("target_endpoint_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicationTaskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_task_id");
        set => this.WithProperty("replication_task_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    public TerraformExpression CdcStartPosition => this["cdc_start_position"];

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformExpression CdcStartTime => this["cdc_start_time"];

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    public TerraformExpression MigrationType => this["migration_type"];

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationInstanceArn => this["replication_instance_arn"];

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationTaskArn => this["replication_task_arn"];

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformExpression ReplicationTaskSettings => this["replication_task_settings"];

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public TerraformExpression SourceEndpointArn => this["source_endpoint_arn"];

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformExpression StartReplicationTask => this["start_replication_task"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public TerraformExpression TableMappings => this["table_mappings"];

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public TerraformExpression TargetEndpointArn => this["target_endpoint_arn"];

}
