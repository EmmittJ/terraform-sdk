using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public partial class AwsElasticBeanstalkEnvironmentSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformProperty("resource")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Resource { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_environment resource.
/// </summary>
public partial class AwsElasticBeanstalkEnvironment : TerraformResource
{
    public AwsElasticBeanstalkEnvironment(string name) : base("aws_elastic_beanstalk_environment", name)
    {
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    [TerraformProperty("application")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Application { get; set; }

    /// <summary>
    /// The cname_prefix attribute.
    /// </summary>
    [TerraformProperty("cname_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CnamePrefix { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform_arn attribute.
    /// </summary>
    [TerraformProperty("platform_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PlatformArn { get; set; }

    /// <summary>
    /// The poll_interval attribute.
    /// </summary>
    [TerraformProperty("poll_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PollInterval { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    [TerraformProperty("solution_stack_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SolutionStackName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [TerraformProperty("template_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateName { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// The version_label attribute.
    /// </summary>
    [TerraformProperty("version_label")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VersionLabel { get; set; }

    /// <summary>
    /// The wait_for_ready_timeout attribute.
    /// </summary>
    [TerraformProperty("wait_for_ready_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WaitForReadyTimeout { get; set; }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("setting")]
    public partial TerraformSet<TerraformBlock<AwsElasticBeanstalkEnvironmentSettingBlock>>? Setting { get; set; }

    /// <summary>
    /// The all_settings attribute.
    /// </summary>
    [TerraformProperty("all_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> AllSettings { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    [TerraformProperty("autoscaling_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AutoscalingGroups { get; }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformProperty("cname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Cname { get; }

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    [TerraformProperty("endpoint_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointUrl { get; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Instances { get; }

    /// <summary>
    /// The launch_configurations attribute.
    /// </summary>
    [TerraformProperty("launch_configurations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LaunchConfigurations { get; }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformProperty("load_balancers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LoadBalancers { get; }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    [TerraformProperty("queues")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Queues { get; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Triggers { get; }

}
