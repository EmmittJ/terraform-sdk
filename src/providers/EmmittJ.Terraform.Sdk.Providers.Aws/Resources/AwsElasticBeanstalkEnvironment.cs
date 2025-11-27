using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in AwsElasticBeanstalkEnvironment.
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkEnvironmentSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "setting";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => new TerraformReference<string>(this, "resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_elastic_beanstalk_environment Terraform resource.
/// Manages a aws_elastic_beanstalk_environment resource.
/// </summary>
public partial class AwsElasticBeanstalkEnvironment(string name) : TerraformResource("aws_elastic_beanstalk_environment", name)
{
    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    public required TerraformValue<string> Application
    {
        get => new TerraformReference<string>(this, "application");
        set => SetArgument("application", value);
    }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    public TerraformValue<string> CnamePrefix
    {
        get => new TerraformReference<string>(this, "cname_prefix");
        set => SetArgument("cname_prefix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform_arn attribute.
    /// </summary>
    public TerraformValue<string> PlatformArn
    {
        get => new TerraformReference<string>(this, "platform_arn");
        set => SetArgument("platform_arn", value);
    }

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    public TerraformValue<string>? PollInterval
    {
        get => new TerraformReference<string>(this, "poll_interval");
        set => SetArgument("poll_interval", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    public TerraformValue<string> SolutionStackName
    {
        get => new TerraformReference<string>(this, "solution_stack_name");
        set => SetArgument("solution_stack_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformValue<string>? TemplateName
    {
        get => new TerraformReference<string>(this, "template_name");
        set => SetArgument("template_name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    public TerraformValue<string> VersionLabel
    {
        get => new TerraformReference<string>(this, "version_label");
        set => SetArgument("version_label", value);
    }

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    public TerraformValue<string>? WaitForReadyTimeout
    {
        get => new TerraformReference<string>(this, "wait_for_ready_timeout");
        set => SetArgument("wait_for_ready_timeout", value);
    }

    /// <summary>
    /// The all_settings attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> AllSettings
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "all_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public TerraformList<string> AutoscalingGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "autoscaling_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformValue<string> Cname
    {
        get => new TerraformReference<string>(this, "cname");
    }

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    public TerraformValue<string> EndpointUrl
    {
        get => new TerraformReference<string>(this, "endpoint_url");
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<string> Instances
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "instances").ResolveNodes(ctx));
    }

    /// <summary>
    /// The launch_configurations attribute.
    /// </summary>
    public TerraformList<string> LaunchConfigurations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "launch_configurations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformList<string> LoadBalancers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "load_balancers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public TerraformList<string> Queues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "queues").ResolveNodes(ctx));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformList<string> Triggers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "triggers").ResolveNodes(ctx));
    }

    /// <summary>
    /// Setting block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElasticBeanstalkEnvironmentSettingBlock>? Setting
    {
        get => GetArgument<TerraformSet<AwsElasticBeanstalkEnvironmentSettingBlock>>("setting");
        set => SetArgument("setting", value);
    }

}
