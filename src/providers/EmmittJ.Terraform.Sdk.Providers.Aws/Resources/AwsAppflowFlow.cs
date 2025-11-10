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
        get => GetProperty<TerraformProperty<string>>("api_version");
        set => WithProperty("api_version", value);
    }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorProfileName
    {
        get => GetProperty<TerraformProperty<string>>("connector_profile_name");
        set => WithProperty("connector_profile_name", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connector_type");
        set => WithProperty("connector_type", value);
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
        get => GetProperty<TerraformProperty<string>>("api_version");
        set => WithProperty("api_version", value);
    }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorProfileName
    {
        get => GetProperty<TerraformProperty<string>>("connector_profile_name");
        set => WithProperty("connector_profile_name", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connector_type");
        set => WithProperty("connector_type", value);
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
        get => GetProperty<TerraformProperty<string>>("destination_field");
        set => WithProperty("destination_field", value);
    }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SourceFields
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_fields");
        set => WithProperty("source_fields", value);
    }

    /// <summary>
    /// The task_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TaskProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("task_properties");
        set => WithProperty("task_properties", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformProperty<string> TaskType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_type");
        set => WithProperty("task_type", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("trigger_type");
        set => WithProperty("trigger_type", value);
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
        this.WithOutput("arn");
        this.WithOutput("flow_status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_arn");
        set => this.WithProperty("kms_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for destination_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationFlowConfig block(s) required")]
    public List<AwsAppflowFlowDestinationFlowConfigBlock>? DestinationFlowConfig
    {
        get => GetProperty<List<AwsAppflowFlowDestinationFlowConfigBlock>>("destination_flow_config");
        set => this.WithProperty("destination_flow_config", value);
    }

    /// <summary>
    /// Block for metadata_catalog_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataCatalogConfig block(s) allowed")]
    public List<AwsAppflowFlowMetadataCatalogConfigBlock>? MetadataCatalogConfig
    {
        get => GetProperty<List<AwsAppflowFlowMetadataCatalogConfigBlock>>("metadata_catalog_config");
        set => this.WithProperty("metadata_catalog_config", value);
    }

    /// <summary>
    /// Block for source_flow_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceFlowConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFlowConfig block(s) allowed")]
    public List<AwsAppflowFlowSourceFlowConfigBlock>? SourceFlowConfig
    {
        get => GetProperty<List<AwsAppflowFlowSourceFlowConfigBlock>>("source_flow_config");
        set => this.WithProperty("source_flow_config", value);
    }

    /// <summary>
    /// Block for task.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Task block(s) required")]
    public HashSet<AwsAppflowFlowTaskBlock>? Task
    {
        get => GetProperty<HashSet<AwsAppflowFlowTaskBlock>>("task");
        set => this.WithProperty("task", value);
    }

    /// <summary>
    /// Block for trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerConfig block(s) allowed")]
    public List<AwsAppflowFlowTriggerConfigBlock>? TriggerConfig
    {
        get => GetProperty<List<AwsAppflowFlowTriggerConfigBlock>>("trigger_config");
        set => this.WithProperty("trigger_config", value);
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
