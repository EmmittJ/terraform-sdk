using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_flow_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppflowFlowDestinationFlowConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    [TerraformProperty("api_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiVersion { get; set; }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    [TerraformProperty("connector_profile_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectorProfileName { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformProperty("connector_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectorType { get; set; }

}

/// <summary>
/// Block type for metadata_catalog_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppflowFlowMetadataCatalogConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for source_flow_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppflowFlowSourceFlowConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    [TerraformProperty("api_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiVersion { get; set; }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    [TerraformProperty("connector_profile_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectorProfileName { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformProperty("connector_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectorType { get; set; }

}

/// <summary>
/// Block type for task in .
/// Nesting mode: set
/// </summary>
public partial class AwsAppflowFlowTaskBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination_field attribute.
    /// </summary>
    [TerraformProperty("destination_field")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DestinationField { get; set; }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    [TerraformProperty("source_fields")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> SourceFields { get; set; }

    /// <summary>
    /// The task_properties attribute.
    /// </summary>
    [TerraformProperty("task_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? TaskProperties { get; set; }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformProperty("task_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TaskType { get; set; }

}

/// <summary>
/// Block type for trigger_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppflowFlowTriggerConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    [TerraformProperty("trigger_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TriggerType { get; set; }

}

/// <summary>
/// Manages a aws_appflow_flow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppflowFlow : TerraformResource
{
    public AwsAppflowFlow(string name) : base("aws_appflow_flow", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    [TerraformProperty("kms_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

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
    /// Block for destination_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationFlowConfig block(s) required")]
    [TerraformProperty("destination_flow_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowDestinationFlowConfigBlock>>? DestinationFlowConfig { get; set; }

    /// <summary>
    /// Block for metadata_catalog_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataCatalogConfig block(s) allowed")]
    [TerraformProperty("metadata_catalog_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowMetadataCatalogConfigBlock>>? MetadataCatalogConfig { get; set; }

    /// <summary>
    /// Block for source_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceFlowConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFlowConfig block(s) allowed")]
    [TerraformProperty("source_flow_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowSourceFlowConfigBlock>>? SourceFlowConfig { get; set; }

    /// <summary>
    /// Block for task.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Task is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Task block(s) required")]
    [TerraformProperty("task")]
    public TerraformSet<TerraformBlock<AwsAppflowFlowTaskBlock>>? Task { get; set; }

    /// <summary>
    /// Block for trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerConfig block(s) allowed")]
    [TerraformProperty("trigger_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowTriggerConfigBlock>>? TriggerConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The flow_status attribute.
    /// </summary>
    [TerraformProperty("flow_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FlowStatus { get; }

}
