using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkEnvironmentSettingBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformProperty<string>? Resource
    {
        set => SetProperty("resource", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

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
        SetOutput("all_settings");
        SetOutput("arn");
        SetOutput("autoscaling_groups");
        SetOutput("cname");
        SetOutput("endpoint_url");
        SetOutput("instances");
        SetOutput("launch_configurations");
        SetOutput("load_balancers");
        SetOutput("queues");
        SetOutput("triggers");
        SetOutput("application");
        SetOutput("cname_prefix");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("platform_arn");
        SetOutput("poll_interval");
        SetOutput("region");
        SetOutput("solution_stack_name");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("template_name");
        SetOutput("tier");
        SetOutput("version_label");
        SetOutput("wait_for_ready_timeout");
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    public required TerraformProperty<string> Application
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application");
        set => SetProperty("application", value);
    }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    public TerraformProperty<string> CnamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cname_prefix");
        set => SetProperty("cname_prefix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The platform_arn attribute.
    /// </summary>
    public TerraformProperty<string> PlatformArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_arn");
        set => SetProperty("platform_arn", value);
    }

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    public TerraformProperty<string> PollInterval
    {
        get => GetRequiredOutput<TerraformProperty<string>>("poll_interval");
        set => SetProperty("poll_interval", value);
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
    /// The solution_stack_name attribute.
    /// </summary>
    public TerraformProperty<string> SolutionStackName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("solution_stack_name");
        set => SetProperty("solution_stack_name", value);
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
    /// The template_name attribute.
    /// </summary>
    public TerraformProperty<string> TemplateName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_name");
        set => SetProperty("template_name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    public TerraformProperty<string> VersionLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_label");
        set => SetProperty("version_label", value);
    }

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    public TerraformProperty<string> WaitForReadyTimeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("wait_for_ready_timeout");
        set => SetProperty("wait_for_ready_timeout", value);
    }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElasticBeanstalkEnvironmentSettingBlock>? Setting
    {
        set => SetProperty("setting", value);
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
