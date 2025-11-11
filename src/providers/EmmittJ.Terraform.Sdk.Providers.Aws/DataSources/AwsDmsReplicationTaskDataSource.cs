using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_task.
/// </summary>
public class AwsDmsReplicationTaskDataSource : TerraformDataSource
{
    public AwsDmsReplicationTaskDataSource(string name) : base("aws_dms_replication_task", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    [TerraformPropertyName("replication_task_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReplicationTaskId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    [TerraformPropertyName("cdc_start_position")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CdcStartPosition => new TerraformReference(this, "cdc_start_position");

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    [TerraformPropertyName("cdc_start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CdcStartTime => new TerraformReference(this, "cdc_start_time");

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    [TerraformPropertyName("migration_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MigrationType => new TerraformReference(this, "migration_type");

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationInstanceArn => new TerraformReference(this, "replication_instance_arn");

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    [TerraformPropertyName("replication_task_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationTaskArn => new TerraformReference(this, "replication_task_arn");

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    [TerraformPropertyName("replication_task_settings")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationTaskSettings => new TerraformReference(this, "replication_task_settings");

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceEndpointArn => new TerraformReference(this, "source_endpoint_arn");

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    [TerraformPropertyName("start_replication_task")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StartReplicationTask => new TerraformReference(this, "start_replication_task");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [TerraformPropertyName("table_mappings")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TableMappings => new TerraformReference(this, "table_mappings");

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TargetEndpointArn => new TerraformReference(this, "target_endpoint_arn");

}
