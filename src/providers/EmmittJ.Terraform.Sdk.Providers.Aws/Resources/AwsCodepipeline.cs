using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_store in .
/// Nesting mode: set
/// </summary>
public class AwsCodepipelineArtifactStoreBlock : TerraformBlock
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineStageBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for trigger in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineTriggerBlock : TerraformBlock
{
    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    public required TerraformProperty<string> ProviderType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("provider_type");
        set => WithProperty("provider_type", value);
    }

}

/// <summary>
/// Block type for variable in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineVariableBlock : TerraformBlock
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        get => GetProperty<TerraformProperty<string>>("default_value");
        set => WithProperty("default_value", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a aws_codepipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodepipeline : TerraformResource
{
    public AwsCodepipeline(string name) : base("aws_codepipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("trigger_all");
    }

    /// <summary>
    /// The execution_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionMode
    {
        get => GetProperty<TerraformProperty<string>>("execution_mode");
        set => this.WithProperty("execution_mode", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The pipeline_type attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineType
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_type");
        set => this.WithProperty("pipeline_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// Block for artifact_store.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ArtifactStore block(s) required")]
    public HashSet<AwsCodepipelineArtifactStoreBlock>? ArtifactStore
    {
        get => GetProperty<HashSet<AwsCodepipelineArtifactStoreBlock>>("artifact_store");
        set => this.WithProperty("artifact_store", value);
    }

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Stage block(s) required")]
    public List<AwsCodepipelineStageBlock>? Stage
    {
        get => GetProperty<List<AwsCodepipelineStageBlock>>("stage");
        set => this.WithProperty("stage", value);
    }

    /// <summary>
    /// Block for trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Trigger block(s) allowed")]
    public List<AwsCodepipelineTriggerBlock>? Trigger
    {
        get => GetProperty<List<AwsCodepipelineTriggerBlock>>("trigger");
        set => this.WithProperty("trigger", value);
    }

    /// <summary>
    /// Block for variable.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodepipelineVariableBlock>? Variable
    {
        get => GetProperty<List<AwsCodepipelineVariableBlock>>("variable");
        set => this.WithProperty("variable", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The trigger_all attribute.
    /// </summary>
    public TerraformExpression TriggerAll => this["trigger_all"];

}
