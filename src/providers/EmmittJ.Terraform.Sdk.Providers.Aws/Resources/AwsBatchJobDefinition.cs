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
        get => GetProperty<TerraformProperty<double>>("attempts");
        set => WithProperty("attempts", value);
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
        get => GetProperty<TerraformProperty<double>>("attempt_duration_seconds");
        set => WithProperty("attempt_duration_seconds", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_prefix");
        this.DeclareOutput("revision");
    }

    /// <summary>
    /// The container_properties attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerProperties
    {
        get => GetProperty<TerraformProperty<string>>("container_properties");
        set => this.WithProperty("container_properties", value);
    }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    public TerraformProperty<bool>? DeregisterOnNewRevision
    {
        get => GetProperty<TerraformProperty<bool>>("deregister_on_new_revision");
        set => this.WithProperty("deregister_on_new_revision", value);
    }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    public TerraformProperty<string>? EcsProperties
    {
        get => GetProperty<TerraformProperty<string>>("ecs_properties");
        set => this.WithProperty("ecs_properties", value);
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
    /// The node_properties attribute.
    /// </summary>
    public TerraformProperty<string>? NodeProperties
    {
        get => GetProperty<TerraformProperty<string>>("node_properties");
        set => this.WithProperty("node_properties", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PlatformCapabilities
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("platform_capabilities");
        set => this.WithProperty("platform_capabilities", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? PropagateTags
    {
        get => GetProperty<TerraformProperty<bool>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
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
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformProperty<double>? SchedulingPriority
    {
        get => GetProperty<TerraformProperty<double>>("scheduling_priority");
        set => this.WithProperty("scheduling_priority", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for eks_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksProperties block(s) allowed")]
    public List<AwsBatchJobDefinitionEksPropertiesBlock>? EksProperties
    {
        get => GetProperty<List<AwsBatchJobDefinitionEksPropertiesBlock>>("eks_properties");
        set => this.WithProperty("eks_properties", value);
    }

    /// <summary>
    /// Block for retry_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryStrategy block(s) allowed")]
    public List<AwsBatchJobDefinitionRetryStrategyBlock>? RetryStrategy
    {
        get => GetProperty<List<AwsBatchJobDefinitionRetryStrategyBlock>>("retry_strategy");
        set => this.WithProperty("retry_strategy", value);
    }

    /// <summary>
    /// Block for timeout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public List<AwsBatchJobDefinitionTimeoutBlock>? Timeout
    {
        get => GetProperty<List<AwsBatchJobDefinitionTimeoutBlock>>("timeout");
        set => this.WithProperty("timeout", value);
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
