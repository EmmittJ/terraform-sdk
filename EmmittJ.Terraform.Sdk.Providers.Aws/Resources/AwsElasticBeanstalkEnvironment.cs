using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elastic_beanstalk_environment resource.
/// </summary>
public class AwsElasticBeanstalkEnvironment : TerraformResource
{
    public AwsElasticBeanstalkEnvironment(string name) : base("aws_elastic_beanstalk_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("all_settings");
        this.DeclareOutput("arn");
        this.DeclareOutput("autoscaling_groups");
        this.DeclareOutput("cname");
        this.DeclareOutput("endpoint_url");
        this.DeclareOutput("instances");
        this.DeclareOutput("launch_configurations");
        this.DeclareOutput("load_balancers");
        this.DeclareOutput("queues");
        this.DeclareOutput("triggers");
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    public string? Application
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application")?.Value;
        set => this.WithProperty("application", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    public string? CnamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cname_prefix")?.Value;
        set => this.WithProperty("cname_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The platform_arn attribute.
    /// </summary>
    public string? PlatformArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_arn")?.Value;
        set => this.WithProperty("platform_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    public string? PollInterval
    {
        get => GetProperty<TerraformLiteralProperty<string>>("poll_interval")?.Value;
        set => this.WithProperty("poll_interval", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The solution_stack_name attribute.
    /// </summary>
    public string? SolutionStackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("solution_stack_name")?.Value;
        set => this.WithProperty("solution_stack_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The template_name attribute.
    /// </summary>
    public string? TemplateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_name")?.Value;
        set => this.WithProperty("template_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    public string? VersionLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_label")?.Value;
        set => this.WithProperty("version_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    public string? WaitForReadyTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("wait_for_ready_timeout")?.Value;
        set => this.WithProperty("wait_for_ready_timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The all_settings attribute.
    /// </summary>
    public TerraformExpression AllSettings => this["all_settings"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public TerraformExpression AutoscalingGroups => this["autoscaling_groups"];

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformExpression Cname => this["cname"];

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    public TerraformExpression EndpointUrl => this["endpoint_url"];

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

    /// <summary>
    /// The launch_configurations attribute.
    /// </summary>
    public TerraformExpression LaunchConfigurations => this["launch_configurations"];

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformExpression LoadBalancers => this["load_balancers"];

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public TerraformExpression Queues => this["queues"];

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformExpression Triggers => this["triggers"];

}
