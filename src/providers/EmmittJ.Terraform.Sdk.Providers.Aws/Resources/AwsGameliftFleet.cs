using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetCertificateConfigurationBlock
{
    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformPropertyName("certificate_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateType { get; set; }

}

/// <summary>
/// Block type for ec2_inbound_permission in .
/// Nesting mode: set
/// </summary>
public class AwsGameliftFleetEc2InboundPermissionBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformPropertyName("from_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    [TerraformPropertyName("ip_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IpRange { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformPropertyName("to_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Block type for resource_creation_limit_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetResourceCreationLimitPolicyBlock
{
    /// <summary>
    /// The new_game_sessions_per_creator attribute.
    /// </summary>
    [TerraformPropertyName("new_game_sessions_per_creator")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NewGameSessionsPerCreator { get; set; }

    /// <summary>
    /// The policy_period_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("policy_period_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PolicyPeriodInMinutes { get; set; }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetRuntimeConfigurationBlock
{
    /// <summary>
    /// The game_session_activation_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("game_session_activation_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>
    /// The max_concurrent_game_session_activations attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_game_session_activations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrentGameSessionActivations { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGameliftFleetTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGameliftFleet : TerraformResource
{
    public AwsGameliftFleet(string name) : base("aws_gamelift_fleet", name)
    {
    }

    /// <summary>
    /// The build_id attribute.
    /// </summary>
    [TerraformPropertyName("build_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BuildId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceType is required")]
    [TerraformPropertyName("ec2_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Ec2InstanceType { get; set; }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformPropertyName("fleet_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FleetType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("instance_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceRoleArn { get; set; }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    [TerraformPropertyName("metric_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> MetricGroups { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    [TerraformPropertyName("new_game_session_protection_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The script_id attribute.
    /// </summary>
    [TerraformPropertyName("script_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScriptId { get; set; }

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
    /// Block for certificate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateConfiguration block(s) allowed")]
    [TerraformPropertyName("certificate_configuration")]
    public TerraformList<TerraformBlock<AwsGameliftFleetCertificateConfigurationBlock>>? CertificateConfiguration { get; set; }

    /// <summary>
    /// Block for ec2_inbound_permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Ec2InboundPermission block(s) allowed")]
    [TerraformPropertyName("ec2_inbound_permission")]
    public TerraformSet<TerraformBlock<AwsGameliftFleetEc2InboundPermissionBlock>>? Ec2InboundPermission { get; set; }

    /// <summary>
    /// Block for resource_creation_limit_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceCreationLimitPolicy block(s) allowed")]
    [TerraformPropertyName("resource_creation_limit_policy")]
    public TerraformList<TerraformBlock<AwsGameliftFleetResourceCreationLimitPolicyBlock>>? ResourceCreationLimitPolicy { get; set; }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfiguration block(s) allowed")]
    [TerraformPropertyName("runtime_configuration")]
    public TerraformList<TerraformBlock<AwsGameliftFleetRuntimeConfigurationBlock>>? RuntimeConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGameliftFleetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The build_arn attribute.
    /// </summary>
    [TerraformPropertyName("build_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BuildArn => new TerraformReference(this, "build_arn");

    /// <summary>
    /// The log_paths attribute.
    /// </summary>
    [TerraformPropertyName("log_paths")]
    // Output-only attribute - read-only reference
    public TerraformList<string> LogPaths => new TerraformReference(this, "log_paths");

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [TerraformPropertyName("operating_system")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OperatingSystem => new TerraformReference(this, "operating_system");

    /// <summary>
    /// The script_arn attribute.
    /// </summary>
    [TerraformPropertyName("script_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScriptArn => new TerraformReference(this, "script_arn");

}
