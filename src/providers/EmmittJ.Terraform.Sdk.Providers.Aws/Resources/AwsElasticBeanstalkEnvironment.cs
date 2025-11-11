using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkEnvironmentSettingBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformPropertyName("namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Resource { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_environment resource.
/// </summary>
public class AwsElasticBeanstalkEnvironment : TerraformResource
{
    public AwsElasticBeanstalkEnvironment(string name) : base("aws_elastic_beanstalk_environment", name)
    {
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    [TerraformPropertyName("application")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Application { get; set; }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    [TerraformPropertyName("cname_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CnamePrefix { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform_arn attribute.
    /// </summary>
    [TerraformPropertyName("platform_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PlatformArn { get; set; } = default!;

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    [TerraformPropertyName("poll_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PollInterval { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    [TerraformPropertyName("solution_stack_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SolutionStackName { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [TerraformPropertyName("template_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateName { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    [TerraformPropertyName("version_label")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VersionLabel { get; set; } = default!;

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_ready_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WaitForReadyTimeout { get; set; }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("setting")]
    public TerraformSet<TerraformBlock<AwsElasticBeanstalkEnvironmentSettingBlock>>? Setting { get; set; }

    /// <summary>
    /// The all_settings attribute.
    /// </summary>
    [TerraformPropertyName("all_settings")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> AllSettings => new TerraformReference(this, "all_settings");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AutoscalingGroups => new TerraformReference(this, "autoscaling_groups");

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformPropertyName("cname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Cname => new TerraformReference(this, "cname");

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointUrl => new TerraformReference(this, "endpoint_url");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Instances => new TerraformReference(this, "instances");

    /// <summary>
    /// The launch_configurations attribute.
    /// </summary>
    [TerraformPropertyName("launch_configurations")]
    // Output-only attribute - read-only reference
    public TerraformList<string> LaunchConfigurations => new TerraformReference(this, "launch_configurations");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> LoadBalancers => new TerraformReference(this, "load_balancers");

    /// <summary>
    /// The queues attribute.
    /// </summary>
    [TerraformPropertyName("queues")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Queues => new TerraformReference(this, "queues");

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Triggers => new TerraformReference(this, "triggers");

}
