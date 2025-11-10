using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_flow_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    [TerraformPropertyName("api_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiVersion { get; set; }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("connector_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectorProfileName { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectorType { get; set; }

}

/// <summary>
/// Block type for metadata_catalog_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowMetadataCatalogConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for source_flow_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    [TerraformPropertyName("api_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiVersion { get; set; }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("connector_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectorProfileName { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectorType { get; set; }

}

/// <summary>
/// Block type for task in .
/// Nesting mode: set
/// </summary>
public class AwsAppflowFlowTaskBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_field attribute.
    /// </summary>
    [TerraformPropertyName("destination_field")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationField { get; set; }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    [TerraformPropertyName("source_fields")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> SourceFields { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "source_fields");

    /// <summary>
    /// The task_properties attribute.
    /// </summary>
    [TerraformPropertyName("task_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? TaskProperties { get; set; }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformPropertyName("task_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TaskType { get; set; }

}

/// <summary>
/// Block type for trigger_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTriggerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    [TerraformPropertyName("trigger_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TriggerType { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for destination_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationFlowConfig block(s) required")]
    [TerraformPropertyName("destination_flow_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowDestinationFlowConfigBlock>>? DestinationFlowConfig { get; set; } = new();

    /// <summary>
    /// Block for metadata_catalog_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataCatalogConfig block(s) allowed")]
    [TerraformPropertyName("metadata_catalog_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowMetadataCatalogConfigBlock>>? MetadataCatalogConfig { get; set; } = new();

    /// <summary>
    /// Block for source_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceFlowConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFlowConfig block(s) allowed")]
    [TerraformPropertyName("source_flow_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowSourceFlowConfigBlock>>? SourceFlowConfig { get; set; } = new();

    /// <summary>
    /// Block for task.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Task is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Task block(s) required")]
    [TerraformPropertyName("task")]
    public TerraformSet<TerraformBlock<AwsAppflowFlowTaskBlock>>? Task { get; set; } = new();

    /// <summary>
    /// Block for trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerConfig block(s) allowed")]
    [TerraformPropertyName("trigger_config")]
    public TerraformList<TerraformBlock<AwsAppflowFlowTriggerConfigBlock>>? TriggerConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The flow_status attribute.
    /// </summary>
    [TerraformPropertyName("flow_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FlowStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "flow_status");

}
