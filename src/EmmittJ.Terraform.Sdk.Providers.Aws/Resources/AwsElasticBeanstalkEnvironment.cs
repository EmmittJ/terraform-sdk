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
    public TerraformProperty<string>? Application
    {
        get => GetProperty<TerraformProperty<string>>("application");
        set => this.WithProperty("application", value);
    }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? CnamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("cname_prefix");
        set => this.WithProperty("cname_prefix", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformArn
    {
        get => GetProperty<TerraformProperty<string>>("platform_arn");
        set => this.WithProperty("platform_arn", value);
    }

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    public TerraformProperty<string>? PollInterval
    {
        get => GetProperty<TerraformProperty<string>>("poll_interval");
        set => this.WithProperty("poll_interval", value);
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
    /// The solution_stack_name attribute.
    /// </summary>
    public TerraformProperty<string>? SolutionStackName
    {
        get => GetProperty<TerraformProperty<string>>("solution_stack_name");
        set => this.WithProperty("solution_stack_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateName
    {
        get => GetProperty<TerraformProperty<string>>("template_name");
        set => this.WithProperty("template_name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    public TerraformProperty<string>? VersionLabel
    {
        get => GetProperty<TerraformProperty<string>>("version_label");
        set => this.WithProperty("version_label", value);
    }

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? WaitForReadyTimeout
    {
        get => GetProperty<TerraformProperty<string>>("wait_for_ready_timeout");
        set => this.WithProperty("wait_for_ready_timeout", value);
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
