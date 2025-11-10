using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetCertificateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateType
    {
        set => SetProperty("certificate_type", value);
    }

}

/// <summary>
/// Block type for ec2_inbound_permission in .
/// Nesting mode: set
/// </summary>
public class AwsGameliftFleetEc2InboundPermissionBlock : TerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformProperty<string> IpRange
    {
        set => SetProperty("ip_range", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        set => SetProperty("to_port", value);
    }

}

/// <summary>
/// Block type for resource_creation_limit_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetResourceCreationLimitPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The new_game_sessions_per_creator attribute.
    /// </summary>
    public TerraformProperty<double>? NewGameSessionsPerCreator
    {
        set => SetProperty("new_game_sessions_per_creator", value);
    }

    /// <summary>
    /// The policy_period_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? PolicyPeriodInMinutes
    {
        set => SetProperty("policy_period_in_minutes", value);
    }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftFleetRuntimeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The game_session_activation_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? GameSessionActivationTimeoutSeconds
    {
        set => SetProperty("game_session_activation_timeout_seconds", value);
    }

    /// <summary>
    /// The max_concurrent_game_session_activations attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentGameSessionActivations
    {
        set => SetProperty("max_concurrent_game_session_activations", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGameliftFleetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_gamelift_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGameliftFleet : TerraformResource
{
    public AwsGameliftFleet(string name) : base("aws_gamelift_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("build_arn");
        SetOutput("log_paths");
        SetOutput("operating_system");
        SetOutput("script_arn");
        SetOutput("build_id");
        SetOutput("description");
        SetOutput("ec2_instance_type");
        SetOutput("fleet_type");
        SetOutput("id");
        SetOutput("instance_role_arn");
        SetOutput("metric_groups");
        SetOutput("name");
        SetOutput("new_game_session_protection_policy");
        SetOutput("region");
        SetOutput("script_id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The build_id attribute.
    /// </summary>
    public TerraformProperty<string> BuildId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_id");
        set => SetProperty("build_id", value);
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
    /// The ec2_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceType is required")]
    public required TerraformProperty<string> Ec2InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ec2_instance_type");
        set => SetProperty("ec2_instance_type", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string> FleetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_type");
        set => SetProperty("fleet_type", value);
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
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> InstanceRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_role_arn");
        set => SetProperty("instance_role_arn", value);
    }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>> MetricGroups
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("metric_groups");
        set => SetProperty("metric_groups", value);
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
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    public TerraformProperty<string> NewGameSessionProtectionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("new_game_session_protection_policy");
        set => SetProperty("new_game_session_protection_policy", value);
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
    /// The script_id attribute.
    /// </summary>
    public TerraformProperty<string> ScriptId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("script_id");
        set => SetProperty("script_id", value);
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
    /// Block for certificate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateConfiguration block(s) allowed")]
    public List<AwsGameliftFleetCertificateConfigurationBlock>? CertificateConfiguration
    {
        set => SetProperty("certificate_configuration", value);
    }

    /// <summary>
    /// Block for ec2_inbound_permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Ec2InboundPermission block(s) allowed")]
    public HashSet<AwsGameliftFleetEc2InboundPermissionBlock>? Ec2InboundPermission
    {
        set => SetProperty("ec2_inbound_permission", value);
    }

    /// <summary>
    /// Block for resource_creation_limit_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceCreationLimitPolicy block(s) allowed")]
    public List<AwsGameliftFleetResourceCreationLimitPolicyBlock>? ResourceCreationLimitPolicy
    {
        set => SetProperty("resource_creation_limit_policy", value);
    }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfiguration block(s) allowed")]
    public List<AwsGameliftFleetRuntimeConfigurationBlock>? RuntimeConfiguration
    {
        set => SetProperty("runtime_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGameliftFleetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The build_arn attribute.
    /// </summary>
    public TerraformExpression BuildArn => this["build_arn"];

    /// <summary>
    /// The log_paths attribute.
    /// </summary>
    public TerraformExpression LogPaths => this["log_paths"];

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformExpression OperatingSystem => this["operating_system"];

    /// <summary>
    /// The script_arn attribute.
    /// </summary>
    public TerraformExpression ScriptArn => this["script_arn"];

}
