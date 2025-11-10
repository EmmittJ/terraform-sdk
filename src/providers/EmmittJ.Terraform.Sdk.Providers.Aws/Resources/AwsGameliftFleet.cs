using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetCertificateConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformPropertyName("certificate_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateType { get; set; }

}

/// <summary>
/// Block type for ec2_inbound_permission in .
/// Nesting mode: set
/// </summary>
public class AwsGameliftFleetEc2InboundPermissionBlock : ITerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformPropertyName("from_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> FromPort { get; set; }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    [TerraformPropertyName("ip_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpRange { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformPropertyName("to_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ToPort { get; set; }

}

/// <summary>
/// Block type for resource_creation_limit_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetResourceCreationLimitPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The new_game_sessions_per_creator attribute.
    /// </summary>
    [TerraformPropertyName("new_game_sessions_per_creator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NewGameSessionsPerCreator { get; set; }

    /// <summary>
    /// The policy_period_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("policy_period_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PolicyPeriodInMinutes { get; set; }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetRuntimeConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The game_session_activation_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("game_session_activation_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>
    /// The max_concurrent_game_session_activations attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_game_session_activations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrentGameSessionActivations { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGameliftFleetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? BuildId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceType is required")]
    [TerraformPropertyName("ec2_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Ec2InstanceType { get; set; }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformPropertyName("fleet_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FleetType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("instance_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceRoleArn { get; set; }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    [TerraformPropertyName("metric_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> MetricGroups { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "metric_groups");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    [TerraformPropertyName("new_game_session_protection_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The script_id attribute.
    /// </summary>
    [TerraformPropertyName("script_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScriptId { get; set; }

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
    /// Block for certificate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateConfiguration block(s) allowed")]
    [TerraformPropertyName("certificate_configuration")]
    public TerraformList<TerraformBlock<AwsGameliftFleetCertificateConfigurationBlock>>? CertificateConfiguration { get; set; } = new();

    /// <summary>
    /// Block for ec2_inbound_permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Ec2InboundPermission block(s) allowed")]
    [TerraformPropertyName("ec2_inbound_permission")]
    public TerraformSet<TerraformBlock<AwsGameliftFleetEc2InboundPermissionBlock>>? Ec2InboundPermission { get; set; } = new();

    /// <summary>
    /// Block for resource_creation_limit_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceCreationLimitPolicy block(s) allowed")]
    [TerraformPropertyName("resource_creation_limit_policy")]
    public TerraformList<TerraformBlock<AwsGameliftFleetResourceCreationLimitPolicyBlock>>? ResourceCreationLimitPolicy { get; set; } = new();

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfiguration block(s) allowed")]
    [TerraformPropertyName("runtime_configuration")]
    public TerraformList<TerraformBlock<AwsGameliftFleetRuntimeConfigurationBlock>>? RuntimeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGameliftFleetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The build_arn attribute.
    /// </summary>
    [TerraformPropertyName("build_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BuildArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "build_arn");

    /// <summary>
    /// The log_paths attribute.
    /// </summary>
    [TerraformPropertyName("log_paths")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LogPaths => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "log_paths");

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [TerraformPropertyName("operating_system")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OperatingSystem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "operating_system");

    /// <summary>
    /// The script_arn attribute.
    /// </summary>
    [TerraformPropertyName("script_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScriptArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "script_arn");

}
