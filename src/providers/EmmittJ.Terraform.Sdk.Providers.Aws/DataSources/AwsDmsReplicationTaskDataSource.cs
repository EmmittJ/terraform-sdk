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
        SetOutput("cdc_start_position");
        SetOutput("cdc_start_time");
        SetOutput("migration_type");
        SetOutput("replication_instance_arn");
        SetOutput("replication_task_arn");
        SetOutput("replication_task_settings");
        SetOutput("source_endpoint_arn");
        SetOutput("start_replication_task");
        SetOutput("status");
        SetOutput("table_mappings");
        SetOutput("target_endpoint_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replication_task_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    public required TerraformProperty<string> ReplicationTaskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_task_id");
        set => SetProperty("replication_task_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
