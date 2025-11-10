using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkEnvironmentSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformPropertyName("namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Namespace { get; set; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Resource { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> Application { get; set; }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    [TerraformPropertyName("cname_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CnamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cname_prefix");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The platform_arn attribute.
    /// </summary>
    [TerraformPropertyName("platform_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PlatformArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_arn");

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    [TerraformPropertyName("poll_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PollInterval { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    [TerraformPropertyName("solution_stack_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SolutionStackName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "solution_stack_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [TerraformPropertyName("template_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemplateName { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tier { get; set; }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    [TerraformPropertyName("version_label")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VersionLabel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_label");

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_ready_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WaitForReadyTimeout { get; set; }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("setting")]
    public TerraformSet<TerraformBlock<AwsElasticBeanstalkEnvironmentSettingBlock>>? Setting { get; set; } = new();

    /// <summary>
    /// The all_settings attribute.
    /// </summary>
    [TerraformPropertyName("all_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> AllSettings => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "all_settings");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AutoscalingGroups => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "autoscaling_groups");

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformPropertyName("cname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Cname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cname");

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_url");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Instances => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "instances");

    /// <summary>
    /// The launch_configurations attribute.
    /// </summary>
    [TerraformPropertyName("launch_configurations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LaunchConfigurations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "launch_configurations");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LoadBalancers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "load_balancers");

    /// <summary>
    /// The queues attribute.
    /// </summary>
    [TerraformPropertyName("queues")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Queues => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "queues");

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Triggers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "triggers");

}
