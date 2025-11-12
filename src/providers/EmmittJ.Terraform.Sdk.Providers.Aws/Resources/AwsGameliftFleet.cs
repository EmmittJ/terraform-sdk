using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftFleetCertificateConfigurationBlock() : TerraformBlock("certificate_configuration")
{
    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformProperty("certificate_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateType { get; set; }

}

/// <summary>
/// Block type for ec2_inbound_permission in .
/// Nesting mode: set
/// </summary>
public partial class AwsGameliftFleetEc2InboundPermissionBlock() : TerraformBlock("ec2_inbound_permission")
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformProperty("from_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    [TerraformProperty("ip_range")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpRange { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformProperty("to_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Block type for resource_creation_limit_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftFleetResourceCreationLimitPolicyBlock() : TerraformBlock("resource_creation_limit_policy")
{
    /// <summary>
    /// The new_game_sessions_per_creator attribute.
    /// </summary>
    [TerraformProperty("new_game_sessions_per_creator")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NewGameSessionsPerCreator { get; set; }

    /// <summary>
    /// The policy_period_in_minutes attribute.
    /// </summary>
    [TerraformProperty("policy_period_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PolicyPeriodInMinutes { get; set; }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftFleetRuntimeConfigurationBlock() : TerraformBlock("runtime_configuration")
{
    /// <summary>
    /// The game_session_activation_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("game_session_activation_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>
    /// The max_concurrent_game_session_activations attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_game_session_activations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrentGameSessionActivations { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGameliftFleetTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGameliftFleet : TerraformResource
{
    public AwsGameliftFleet(string name) : base("aws_gamelift_fleet", name)
    {
    }

    /// <summary>
    /// The build_id attribute.
    /// </summary>
    [TerraformProperty("build_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BuildId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceType is required")]
    [TerraformProperty("ec2_instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Ec2InstanceType { get; set; }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformProperty("fleet_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FleetType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    [TerraformProperty("instance_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceRoleArn { get; set; }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    [TerraformProperty("metric_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> MetricGroups { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    [TerraformProperty("new_game_session_protection_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The script_id attribute.
    /// </summary>
    [TerraformProperty("script_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScriptId { get; set; }

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
    /// Block for certificate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateConfiguration block(s) allowed")]
    [TerraformProperty("certificate_configuration")]
    public TerraformList<AwsGameliftFleetCertificateConfigurationBlock> CertificateConfiguration { get; set; } = new();

    /// <summary>
    /// Block for ec2_inbound_permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Ec2InboundPermission block(s) allowed")]
    [TerraformProperty("ec2_inbound_permission")]
    public TerraformSet<AwsGameliftFleetEc2InboundPermissionBlock> Ec2InboundPermission { get; set; } = new();

    /// <summary>
    /// Block for resource_creation_limit_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceCreationLimitPolicy block(s) allowed")]
    [TerraformProperty("resource_creation_limit_policy")]
    public TerraformList<AwsGameliftFleetResourceCreationLimitPolicyBlock> ResourceCreationLimitPolicy { get; set; } = new();

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfiguration block(s) allowed")]
    [TerraformProperty("runtime_configuration")]
    public TerraformList<AwsGameliftFleetRuntimeConfigurationBlock> RuntimeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsGameliftFleetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The build_arn attribute.
    /// </summary>
    [TerraformProperty("build_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BuildArn { get; }

    /// <summary>
    /// The log_paths attribute.
    /// </summary>
    [TerraformProperty("log_paths")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LogPaths { get; }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [TerraformProperty("operating_system")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OperatingSystem { get; }

    /// <summary>
    /// The script_arn attribute.
    /// </summary>
    [TerraformProperty("script_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ScriptArn { get; }

}
