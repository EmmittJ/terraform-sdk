using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_batch_job_definition resource.
/// </summary>
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
    public string? ContainerProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_properties")?.Value;
        set => this.WithProperty("container_properties", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    public bool? DeregisterOnNewRevision
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deregister_on_new_revision")?.Value;
        set => this.WithProperty("deregister_on_new_revision", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    public string? EcsProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ecs_properties")?.Value;
        set => this.WithProperty("ecs_properties", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public string? NodeProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_properties")?.Value;
        set => this.WithProperty("node_properties", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    public HashSet<string>? PlatformCapabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("platform_capabilities")?.Value;
        set => this.WithProperty("platform_capabilities", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public bool? PropagateTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("propagate_tags")?.Value;
        set => this.WithProperty("propagate_tags", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    public double? SchedulingPriority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scheduling_priority")?.Value;
        set => this.WithProperty("scheduling_priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
