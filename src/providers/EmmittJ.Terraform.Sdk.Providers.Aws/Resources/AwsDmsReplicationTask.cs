using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_replication_task resource.
/// </summary>
public class AwsDmsReplicationTask : TerraformResource
{
    public AwsDmsReplicationTask(string name) : base("aws_dms_replication_task", name)
    {
    }

    /// <summary>
    /// The cdc_start_position attribute.
    /// </summary>
    [TerraformPropertyName("cdc_start_position")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CdcStartPosition { get; set; } = default!;

    /// <summary>
    /// The cdc_start_time attribute.
    /// </summary>
    [TerraformPropertyName("cdc_start_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CdcStartTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The migration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationType is required")]
    [TerraformPropertyName("migration_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MigrationType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceArn is required")]
    [TerraformPropertyName("replication_instance_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReplicationInstanceArn { get; set; }

    /// <summary>
    /// The replication_task_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationTaskId is required")]
    [TerraformPropertyName("replication_task_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReplicationTaskId { get; set; }

    /// <summary>
    /// The replication_task_settings attribute.
    /// </summary>
    [TerraformPropertyName("replication_task_settings")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReplicationTaskSettings { get; set; } = default!;

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformPropertyName("resource_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceIdentifier { get; set; }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    [TerraformPropertyName("source_endpoint_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceEndpointArn { get; set; }

    /// <summary>
    /// The start_replication_task attribute.
    /// </summary>
    [TerraformPropertyName("start_replication_task")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StartReplicationTask { get; set; }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    [TerraformPropertyName("table_mappings")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableMappings { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    [TerraformPropertyName("target_endpoint_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetEndpointArn { get; set; }

    /// <summary>
    /// The replication_task_arn attribute.
    /// </summary>
    [TerraformPropertyName("replication_task_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationTaskArn => new TerraformReference(this, "replication_task_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
