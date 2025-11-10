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
        SetOutput("replication_task_arn");
        SetOutput("status");
        SetOutput("cdc_start_position");
        SetOutput("cdc_start_time");
        SetOutput("id");
        SetOutput("migration_type");
        SetOutput("region");
        SetOutput("replication_instance_arn");
        SetOutput("replication_task_id");
        SetOutput("replication_task_settings");
        SetOutput("resource_identifier");
        SetOutput("source_endpoint_arn");
        SetOutput("start_replication_task");
        SetOutput("table_mappings");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_endpoint_arn");
    }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    public TerraformProperty<string> CdcStartPosition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdc_start_position");
        set => SetProperty("cdc_start_position", value);
    }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    public TerraformProperty<string> CdcStartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdc_start_time");
        set => SetProperty("cdc_start_time", value);
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
    /// The migration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationType is required")]
    public required TerraformProperty<string> MigrationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("migration_type");
        set => SetProperty("migration_type", value);
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
    /// The replication_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceArn is required")]
    public required TerraformProperty<string> ReplicationInstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_instance_arn");
        set => SetProperty("replication_instance_arn", value);
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
    /// The replication_task_settings attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationTaskSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_task_settings");
        set => SetProperty("replication_task_settings", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ResourceIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_identifier");
        set => SetProperty("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    public required TerraformProperty<string> SourceEndpointArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_endpoint_arn");
        set => SetProperty("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    public TerraformProperty<bool> StartReplicationTask
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_replication_task");
        set => SetProperty("start_replication_task", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    public required TerraformProperty<string> TableMappings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_mappings");
        set => SetProperty("table_mappings", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    public required TerraformProperty<string> TargetEndpointArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_endpoint_arn");
        set => SetProperty("target_endpoint_arn", value);
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
