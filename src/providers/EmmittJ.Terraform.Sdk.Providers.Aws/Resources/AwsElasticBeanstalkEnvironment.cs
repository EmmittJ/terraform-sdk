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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
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
        get => GetRequiredArgument<TerraformValue<string>>("application");
        set => SetArgument("application", value);
    }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    public TerraformValue<string> CnamePrefix
    {
        get => GetArgument<TerraformValue<string>>("cname_prefix") ?? AsReference("cname_prefix");
        set => SetArgument("cname_prefix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform_arn attribute.
    /// </summary>
    public TerraformValue<string> PlatformArn
    {
        get => GetArgument<TerraformValue<string>>("platform_arn") ?? AsReference("platform_arn");
        set => SetArgument("platform_arn", value);
    }

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    public TerraformValue<string>? PollInterval
    {
        get => GetArgument<TerraformValue<string>>("poll_interval");
        set => SetArgument("poll_interval", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    public TerraformValue<string> SolutionStackName
    {
        get => GetArgument<TerraformValue<string>>("solution_stack_name") ?? AsReference("solution_stack_name");
        set => SetArgument("solution_stack_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformValue<string>? TemplateName
    {
        get => GetArgument<TerraformValue<string>>("template_name");
        set => SetArgument("template_name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    public TerraformValue<string> VersionLabel
    {
        get => GetArgument<TerraformValue<string>>("version_label") ?? AsReference("version_label");
        set => SetArgument("version_label", value);
    }

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    public TerraformValue<string>? WaitForReadyTimeout
    {
        get => GetArgument<TerraformValue<string>>("wait_for_ready_timeout");
        set => SetArgument("wait_for_ready_timeout", value);
    }

    /// <summary>
    /// The all_settings attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> AllSettings
        => AsReference("all_settings");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public TerraformList<string> AutoscalingGroups
        => AsReference("autoscaling_groups");

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformValue<string> Cname
        => AsReference("cname");

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    public TerraformValue<string> EndpointUrl
        => AsReference("endpoint_url");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<string> Instances
        => AsReference("instances");

    /// <summary>
    /// The launch_configurations attribute.
    /// </summary>
    public TerraformList<string> LaunchConfigurations
        => AsReference("launch_configurations");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformList<string> LoadBalancers
        => AsReference("load_balancers");

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public TerraformList<string> Queues
        => AsReference("queues");

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformList<string> Triggers
        => AsReference("triggers");

    /// <summary>
    /// Setting block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElasticBeanstalkEnvironmentSettingBlock>? Setting
    {
        get => GetArgument<TerraformSet<AwsElasticBeanstalkEnvironmentSettingBlock>>("setting");
        set => SetArgument("setting", value);
    }

}
