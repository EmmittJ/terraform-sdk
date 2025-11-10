using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_config in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryArtifactConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for run_config in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryRunConfigBlock : TerraformBlock
{
    /// <summary>
    /// The active_tracing attribute.
    /// </summary>
    public TerraformProperty<bool>? ActiveTracing
    {
        set => SetProperty("active_tracing", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformProperty<double>? EphemeralStorage
    {
        set => SetProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryInMb
    {
        set => SetProperty("memory_in_mb", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        set => SetProperty("timeout_in_seconds", value);
    }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DurationInSeconds
    {
        set => SetProperty("duration_in_seconds", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        set => SetProperty("expression", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The ipv6_allowed_for_dual_stack attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv6AllowedForDualStack
    {
        set => SetProperty("ipv6_allowed_for_dual_stack", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        set => SetProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_synthetics_canary resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSyntheticsCanary : TerraformResource
{
    public AwsSyntheticsCanary(string name) : base("aws_synthetics_canary", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("engine_arn");
        SetOutput("source_location_arn");
        SetOutput("status");
        SetOutput("timeline");
        SetOutput("artifact_s3_location");
        SetOutput("delete_lambda");
        SetOutput("execution_role_arn");
        SetOutput("failure_retention_period");
        SetOutput("handler");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("runtime_version");
        SetOutput("s3_bucket");
        SetOutput("s3_key");
        SetOutput("s3_version");
        SetOutput("start_canary");
        SetOutput("success_retention_period");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("zip_file");
    }

    /// <summary>
    /// The artifact_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactS3Location is required")]
    public required TerraformProperty<string> ArtifactS3Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("artifact_s3_location");
        set => SetProperty("artifact_s3_location", value);
    }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteLambda
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_lambda");
        set => SetProperty("delete_lambda", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> FailureRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("failure_retention_period");
        set => SetProperty("failure_retention_period", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handler is required")]
    public required TerraformProperty<string> Handler
    {
        get => GetRequiredOutput<TerraformProperty<string>>("handler");
        set => SetProperty("handler", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformProperty<string> RuntimeVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_version");
        set => SetProperty("runtime_version", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string> S3Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket");
        set => SetProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformProperty<string> S3Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_key");
        set => SetProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    public TerraformProperty<string> S3Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_version");
        set => SetProperty("s3_version", value);
    }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    public TerraformProperty<bool> StartCanary
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_canary");
        set => SetProperty("start_canary", value);
    }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> SuccessRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("success_retention_period");
        set => SetProperty("success_retention_period", value);
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
    /// The zip_file attribute.
    /// </summary>
    public TerraformProperty<string> ZipFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zip_file");
        set => SetProperty("zip_file", value);
    }

    /// <summary>
    /// Block for artifact_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArtifactConfig block(s) allowed")]
    public List<AwsSyntheticsCanaryArtifactConfigBlock>? ArtifactConfig
    {
        set => SetProperty("artifact_config", value);
    }

    /// <summary>
    /// Block for run_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunConfig block(s) allowed")]
    public List<AwsSyntheticsCanaryRunConfigBlock>? RunConfig
    {
        set => SetProperty("run_config", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AwsSyntheticsCanaryScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsSyntheticsCanaryVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The engine_arn attribute.
    /// </summary>
    public TerraformExpression EngineArn => this["engine_arn"];

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    public TerraformExpression SourceLocationArn => this["source_location_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The timeline attribute.
    /// </summary>
    public TerraformExpression Timeline => this["timeline"];

}
