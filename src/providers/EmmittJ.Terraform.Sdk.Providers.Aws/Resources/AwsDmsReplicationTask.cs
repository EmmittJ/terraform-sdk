using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_replication_task resource.
/// </summary>
public partial class AwsDmsReplicationTask : TerraformResource
{
    public AwsDmsReplicationTask(string name) : base("aws_dms_replication_task", name)
    {
    }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    [TerraformProperty("cdc_start_position")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CdcStartPosition { get; set; }

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    [TerraformProperty("cdc_start_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CdcStartTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationType is required")]
    [TerraformProperty("migration_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MigrationType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceArn is required")]
    [TerraformProperty("replication_instance_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationInstanceArn { get; set; }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    [TerraformProperty("replication_task_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationTaskId { get; set; }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    [TerraformProperty("replication_task_settings")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ReplicationTaskSettings { get; set; }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformProperty("resource_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceIdentifier { get; set; }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    [TerraformProperty("source_endpoint_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceEndpointArn { get; set; }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    [TerraformProperty("start_replication_task")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? StartReplicationTask { get; set; }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    [TerraformProperty("table_mappings")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableMappings { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    [TerraformProperty("target_endpoint_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetEndpointArn { get; set; }

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    [TerraformProperty("replication_task_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationTaskArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
