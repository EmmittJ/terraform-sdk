using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_flow_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlock : TerraformBlock
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    public TerraformProperty<string>? ApiVersion
    {
        set => SetProperty("api_version", value);
    }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorProfileName
    {
        set => SetProperty("connector_profile_name", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        set => SetProperty("connector_type", value);
    }

}

/// <summary>
/// Block type for metadata_catalog_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowMetadataCatalogConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for source_flow_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlock : TerraformBlock
{
    /// <summary>
    /// The api_version attribute.
    /// </summary>
    public TerraformProperty<string>? ApiVersion
    {
        set => SetProperty("api_version", value);
    }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorProfileName
    {
        set => SetProperty("connector_profile_name", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        set => SetProperty("connector_type", value);
    }

}

/// <summary>
/// Block type for task in .
/// Nesting mode: set
/// </summary>
public class AwsAppflowFlowTaskBlock : TerraformBlock
{
    /// <summary>
    /// The destination_field attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationField
    {
        set => SetProperty("destination_field", value);
    }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SourceFields
    {
        set => SetProperty("source_fields", value);
    }

    /// <summary>
    /// The task_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TaskProperties
    {
        set => SetProperty("task_properties", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformProperty<string> TaskType
    {
        set => SetProperty("task_type", value);
    }

}

/// <summary>
/// Block type for trigger_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    public required TerraformProperty<string> TriggerType
    {
        set => SetProperty("trigger_type", value);
    }

}

/// <summary>
/// Manages a aws_appflow_flow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppflowFlow : TerraformResource
{
    public AwsAppflowFlow(string name) : base("aws_appflow_flow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("flow_status");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kms_arn");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The kms_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_arn");
        set => SetProperty("kms_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for destination_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationFlowConfig block(s) required")]
    public List<AwsAppflowFlowDestinationFlowConfigBlock>? DestinationFlowConfig
    {
        set => SetProperty("destination_flow_config", value);
    }

    /// <summary>
    /// Block for metadata_catalog_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataCatalogConfig block(s) allowed")]
    public List<AwsAppflowFlowMetadataCatalogConfigBlock>? MetadataCatalogConfig
    {
        set => SetProperty("metadata_catalog_config", value);
    }

    /// <summary>
    /// Block for source_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceFlowConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFlowConfig block(s) allowed")]
    public List<AwsAppflowFlowSourceFlowConfigBlock>? SourceFlowConfig
    {
        set => SetProperty("source_flow_config", value);
    }

    /// <summary>
    /// Block for task.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Task is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Task block(s) required")]
    public HashSet<AwsAppflowFlowTaskBlock>? Task
    {
        set => SetProperty("task", value);
    }

    /// <summary>
    /// Block for trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerConfig block(s) allowed")]
    public List<AwsAppflowFlowTriggerConfigBlock>? TriggerConfig
    {
        set => SetProperty("trigger_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The flow_status attribute.
    /// </summary>
    public TerraformExpression FlowStatus => this["flow_status"];

}
