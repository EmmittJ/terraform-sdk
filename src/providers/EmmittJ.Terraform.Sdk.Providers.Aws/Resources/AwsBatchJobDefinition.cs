using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for eks_properties in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for retry_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionRetryStrategyBlock : TerraformBlock
{
    /// <summary>
    /// The attempts attribute.
    /// </summary>
    public TerraformProperty<double>? Attempts
    {
        set => SetProperty("attempts", value);
    }

}

/// <summary>
/// Block type for timeout in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// The attempt_duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? AttemptDurationSeconds
    {
        set => SetProperty("attempt_duration_seconds", value);
    }

}

/// <summary>
/// Manages a aws_batch_job_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBatchJobDefinition : TerraformResource
{
    public AwsBatchJobDefinition(string name) : base("aws_batch_job_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("arn_prefix");
        SetOutput("revision");
        SetOutput("container_properties");
        SetOutput("deregister_on_new_revision");
        SetOutput("ecs_properties");
        SetOutput("id");
        SetOutput("name");
        SetOutput("node_properties");
        SetOutput("parameters");
        SetOutput("platform_capabilities");
        SetOutput("propagate_tags");
        SetOutput("region");
        SetOutput("scheduling_priority");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The container_properties attribute.
    /// </summary>
    public TerraformProperty<string> ContainerProperties
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_properties");
        set => SetProperty("container_properties", value);
    }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    public TerraformProperty<bool> DeregisterOnNewRevision
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deregister_on_new_revision");
        set => SetProperty("deregister_on_new_revision", value);
    }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    public TerraformProperty<string> EcsProperties
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ecs_properties");
        set => SetProperty("ecs_properties", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public TerraformProperty<string> NodeProperties
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_properties");
        set => SetProperty("node_properties", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> PlatformCapabilities
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("platform_capabilities");
        set => SetProperty("platform_capabilities", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<bool> PropagateTags
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("propagate_tags");
        set => SetProperty("propagate_tags", value);
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
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformProperty<double> SchedulingPriority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scheduling_priority");
        set => SetProperty("scheduling_priority", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for eks_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksProperties block(s) allowed")]
    public List<AwsBatchJobDefinitionEksPropertiesBlock>? EksProperties
    {
        set => SetProperty("eks_properties", value);
    }

    /// <summary>
    /// Block for retry_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryStrategy block(s) allowed")]
    public List<AwsBatchJobDefinitionRetryStrategyBlock>? RetryStrategy
    {
        set => SetProperty("retry_strategy", value);
    }

    /// <summary>
    /// Block for timeout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public List<AwsBatchJobDefinitionTimeoutBlock>? Timeout
    {
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    public TerraformExpression ArnPrefix => this["arn_prefix"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
