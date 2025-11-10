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
        get => GetProperty<TerraformProperty<string>>("certificate_type");
        set => WithProperty("certificate_type", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("from_port");
        set => WithProperty("from_port", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformProperty<string> IpRange
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ip_range");
        set => WithProperty("ip_range", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("to_port");
        set => WithProperty("to_port", value);
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
        get => GetProperty<TerraformProperty<double>>("new_game_sessions_per_creator");
        set => WithProperty("new_game_sessions_per_creator", value);
    }

    /// <summary>
    /// The policy_period_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? PolicyPeriodInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("policy_period_in_minutes");
        set => WithProperty("policy_period_in_minutes", value);
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
        get => GetProperty<TerraformProperty<double>>("game_session_activation_timeout_seconds");
        set => WithProperty("game_session_activation_timeout_seconds", value);
    }

    /// <summary>
    /// The max_concurrent_game_session_activations attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentGameSessionActivations
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrent_game_session_activations");
        set => WithProperty("max_concurrent_game_session_activations", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("build_arn");
        this.DeclareOutput("log_paths");
        this.DeclareOutput("operating_system");
        this.DeclareOutput("script_arn");
    }

    /// <summary>
    /// The build_id attribute.
    /// </summary>
    public TerraformProperty<string>? BuildId
    {
        get => GetProperty<TerraformProperty<string>>("build_id");
        set => this.WithProperty("build_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2InstanceType is required")]
    public required TerraformProperty<string> Ec2InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ec2_instance_type");
        set => this.WithProperty("ec2_instance_type", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string>? FleetType
    {
        get => GetProperty<TerraformProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("instance_role_arn");
        set => this.WithProperty("instance_role_arn", value);
    }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? MetricGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("metric_groups");
        set => this.WithProperty("metric_groups", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    public TerraformProperty<string>? NewGameSessionProtectionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("new_game_session_protection_policy");
        set => this.WithProperty("new_game_session_protection_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The script_id attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptId
    {
        get => GetProperty<TerraformProperty<string>>("script_id");
        set => this.WithProperty("script_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for certificate_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateConfiguration block(s) allowed")]
    public List<AwsGameliftFleetCertificateConfigurationBlock>? CertificateConfiguration
    {
        get => GetProperty<List<AwsGameliftFleetCertificateConfigurationBlock>>("certificate_configuration");
        set => this.WithProperty("certificate_configuration", value);
    }

    /// <summary>
    /// Block for ec2_inbound_permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Ec2InboundPermission block(s) allowed")]
    public HashSet<AwsGameliftFleetEc2InboundPermissionBlock>? Ec2InboundPermission
    {
        get => GetProperty<HashSet<AwsGameliftFleetEc2InboundPermissionBlock>>("ec2_inbound_permission");
        set => this.WithProperty("ec2_inbound_permission", value);
    }

    /// <summary>
    /// Block for resource_creation_limit_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceCreationLimitPolicy block(s) allowed")]
    public List<AwsGameliftFleetResourceCreationLimitPolicyBlock>? ResourceCreationLimitPolicy
    {
        get => GetProperty<List<AwsGameliftFleetResourceCreationLimitPolicyBlock>>("resource_creation_limit_policy");
        set => this.WithProperty("resource_creation_limit_policy", value);
    }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfiguration block(s) allowed")]
    public List<AwsGameliftFleetRuntimeConfigurationBlock>? RuntimeConfiguration
    {
        get => GetProperty<List<AwsGameliftFleetRuntimeConfigurationBlock>>("runtime_configuration");
        set => this.WithProperty("runtime_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGameliftFleetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGameliftFleetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
