using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_flow_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlock
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    [TerraformPropertyName("api_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiVersion { get; set; }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("connector_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectorProfileName { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectorType { get; set; }

}

/// <summary>
/// Block type for metadata_catalog_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowMetadataCatalogConfigBlock
{
}

/// <summary>
/// Block type for source_flow_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlock
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    [TerraformPropertyName("api_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiVersion { get; set; }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("connector_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectorProfileName { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectorType { get; set; }

}

/// <summary>
/// Block type for task in .
/// Nesting mode: set
/// </summary>
public class AwsAppflowFlowTaskBlock
{
    /// <summary>
    /// The destination_field attribute.
    /// </summary>
    [TerraformPropertyName("destination_field")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationField { get; set; }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    [TerraformPropertyName("source_fields")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> SourceFields { get; set; } = default!;

    /// <summary>
    /// The task_properties attribute.
    /// </summary>
    [TerraformPropertyName("task_properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? TaskProperties { get; set; }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformPropertyName("task_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskType { get; set; }

}

/// <summary>
/// Block type for trigger_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTriggerConfigBlock
{
    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    [TerraformPropertyName("trigger_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TriggerType { get; set; }

}

/// <summary>
/// Manages a aws_appflow_flow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppflowFlow : TerraformResource
{
    public AwsAppflowFlow(string name) : base("aws_appflow_flow", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsArn { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

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
    /// Block for destination_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationFlowConfig block(s) required")]
    [TerraformPropertyName("destination_flow_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowDestinationFlowConfigBlock>>? DestinationFlowConfig { get; set; }

    /// <summary>
    /// Block for metadata_catalog_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataCatalogConfig block(s) allowed")]
    [TerraformPropertyName("metadata_catalog_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowMetadataCatalogConfigBlock>>? MetadataCatalogConfig { get; set; }

    /// <summary>
    /// Block for source_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceFlowConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFlowConfig block(s) allowed")]
    [TerraformPropertyName("source_flow_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowSourceFlowConfigBlock>>? SourceFlowConfig { get; set; }

    /// <summary>
    /// Block for task.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Task is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Task block(s) required")]
    [TerraformPropertyName("task")]
    public TerraformSet<TerraformBlock<AwsAppflowFlowTaskBlock>>? Task { get; set; }

    /// <summary>
    /// Block for trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerConfig block(s) allowed")]
    [TerraformPropertyName("trigger_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowTriggerConfigBlock>>? TriggerConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The flow_status attribute.
    /// </summary>
    [TerraformPropertyName("flow_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FlowStatus => new TerraformReference(this, "flow_status");

}
