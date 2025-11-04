using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ecs_task_set resource.
/// </summary>
public class AwsEcsTaskSet : TerraformResource
{
    public AwsEcsTaskSet(string name) : base("aws_ecs_task_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("stability_status");
        this.DeclareOutput("status");
        this.DeclareOutput("task_set_id");
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public string? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster")?.Value;
        set => this.WithProperty("cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public string? ExternalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_id")?.Value;
        set => this.WithProperty("external_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public bool? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete")?.Value;
        set => this.WithProperty("force_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The launch_type attribute.
    /// </summary>
    public string? LaunchType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_type")?.Value;
        set => this.WithProperty("launch_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public string? PlatformVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_version")?.Value;
        set => this.WithProperty("platform_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The task_definition attribute.
    /// </summary>
    public string? TaskDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_definition")?.Value;
        set => this.WithProperty("task_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    public bool? WaitUntilStable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_until_stable")?.Value;
        set => this.WithProperty("wait_until_stable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    public string? WaitUntilStableTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("wait_until_stable_timeout")?.Value;
        set => this.WithProperty("wait_until_stable_timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stability_status attribute.
    /// </summary>
    public TerraformExpression StabilityStatus => this["stability_status"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The task_set_id attribute.
    /// </summary>
    public TerraformExpression TaskSetId => this["task_set_id"];

}
