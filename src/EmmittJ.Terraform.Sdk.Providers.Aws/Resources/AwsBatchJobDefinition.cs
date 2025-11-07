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
    public TerraformLiteralProperty<string>? ContainerProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_properties");
        set => this.WithProperty("container_properties", value);
    }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeregisterOnNewRevision
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deregister_on_new_revision");
        set => this.WithProperty("deregister_on_new_revision", value);
    }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EcsProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ecs_properties");
        set => this.WithProperty("ecs_properties", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_properties");
        set => this.WithProperty("node_properties", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PlatformCapabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("platform_capabilities");
        set => this.WithProperty("platform_capabilities", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PropagateTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SchedulingPriority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scheduling_priority");
        set => this.WithProperty("scheduling_priority", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
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
