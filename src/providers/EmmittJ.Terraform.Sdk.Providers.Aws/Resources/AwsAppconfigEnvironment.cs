using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitor in .
/// Nesting mode: set
/// </summary>
public partial class AwsAppconfigEnvironmentMonitorBlock : TerraformBlockBase
{
    /// <summary>
    /// The alarm_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmArn is required")]
    [TerraformProperty("alarm_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AlarmArn { get; set; }

    /// <summary>
    /// The alarm_role_arn attribute.
    /// </summary>
    [TerraformProperty("alarm_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AlarmRoleArn { get; set; }

}

/// <summary>
/// Manages a aws_appconfig_environment resource.
/// </summary>
public partial class AwsAppconfigEnvironment : TerraformResource
{
    public AwsAppconfigEnvironment(string name) : base("aws_appconfig_environment", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for monitor.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("monitor")]
    public TerraformSet<TerraformBlock<AwsAppconfigEnvironmentMonitorBlock>>? Monitor { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [TerraformProperty("environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EnvironmentId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
