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
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalId
    {
        get => GetProperty<TerraformProperty<string>>("external_id");
        set => this.WithProperty("external_id", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchType
    {
        get => GetProperty<TerraformProperty<string>>("launch_type");
        set => this.WithProperty("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
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
    /// The service attribute.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformProperty<string>? TaskDefinition
    {
        get => GetProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitUntilStable
    {
        get => GetProperty<TerraformProperty<bool>>("wait_until_stable");
        set => this.WithProperty("wait_until_stable", value);
    }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? WaitUntilStableTimeout
    {
        get => GetProperty<TerraformProperty<string>>("wait_until_stable_timeout");
        set => this.WithProperty("wait_until_stable_timeout", value);
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
