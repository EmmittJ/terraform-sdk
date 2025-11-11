using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_task.
/// </summary>
public partial class AwsDmsReplicationTaskDataSource : TerraformDataSource
{
    public AwsDmsReplicationTaskDataSource(string name) : base("aws_dms_replication_task", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    [TerraformProperty("replication_task_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationTaskId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    [TerraformProperty("cdc_start_position")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CdcStartPosition { get; }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    [TerraformProperty("cdc_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CdcStartTime { get; }

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    [TerraformProperty("migration_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MigrationType { get; }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [TerraformProperty("replication_instance_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReplicationInstanceArn { get; }

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    [TerraformProperty("replication_task_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReplicationTaskArn { get; }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    [TerraformProperty("replication_task_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReplicationTaskSettings { get; }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [TerraformProperty("source_endpoint_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceEndpointArn { get; }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    [TerraformProperty("start_replication_task")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StartReplicationTask { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [TerraformProperty("table_mappings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TableMappings { get; }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [TerraformProperty("target_endpoint_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetEndpointArn { get; }

}
