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
        get => GetProperty<TerraformProperty<bool>>("active_tracing");
        set => WithProperty("active_tracing", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformProperty<double>? EphemeralStorage
    {
        get => GetProperty<TerraformProperty<double>>("ephemeral_storage");
        set => WithProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryInMb
    {
        get => GetProperty<TerraformProperty<double>>("memory_in_mb");
        set => WithProperty("memory_in_mb", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
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
        get => GetProperty<TerraformProperty<double>>("duration_in_seconds");
        set => WithProperty("duration_in_seconds", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
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
        get => GetProperty<TerraformProperty<bool>>("ipv6_allowed_for_dual_stack");
        set => WithProperty("ipv6_allowed_for_dual_stack", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_synthetics_canary resource.
/// </summary>
public class AwsSyntheticsCanary : TerraformResource
{
    public AwsSyntheticsCanary(string name) : base("aws_synthetics_canary", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("engine_arn");
        this.DeclareOutput("source_location_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("timeline");
    }

    /// <summary>
    /// The artifact_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactS3Location is required")]
    public required TerraformProperty<string> ArtifactS3Location
    {
        get => GetProperty<TerraformProperty<string>>("artifact_s3_location");
        set => this.WithProperty("artifact_s3_location", value);
    }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteLambda
    {
        get => GetProperty<TerraformProperty<bool>>("delete_lambda");
        set => this.WithProperty("delete_lambda", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? FailureRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("failure_retention_period");
        set => this.WithProperty("failure_retention_period", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handler is required")]
    public required TerraformProperty<string> Handler
    {
        get => GetProperty<TerraformProperty<string>>("handler");
        set => this.WithProperty("handler", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformProperty<string> RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => this.WithProperty("runtime_version", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformProperty<string>? S3Key
    {
        get => GetProperty<TerraformProperty<string>>("s3_key");
        set => this.WithProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    public TerraformProperty<string>? S3Version
    {
        get => GetProperty<TerraformProperty<string>>("s3_version");
        set => this.WithProperty("s3_version", value);
    }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    public TerraformProperty<bool>? StartCanary
    {
        get => GetProperty<TerraformProperty<bool>>("start_canary");
        set => this.WithProperty("start_canary", value);
    }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? SuccessRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("success_retention_period");
        set => this.WithProperty("success_retention_period", value);
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
    /// The zip_file attribute.
    /// </summary>
    public TerraformProperty<string>? ZipFile
    {
        get => GetProperty<TerraformProperty<string>>("zip_file");
        set => this.WithProperty("zip_file", value);
    }

    /// <summary>
    /// Block for artifact_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArtifactConfig block(s) allowed")]
    public List<AwsSyntheticsCanaryArtifactConfigBlock>? ArtifactConfig
    {
        get => GetProperty<List<AwsSyntheticsCanaryArtifactConfigBlock>>("artifact_config");
        set => this.WithProperty("artifact_config", value);
    }

    /// <summary>
    /// Block for run_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunConfig block(s) allowed")]
    public List<AwsSyntheticsCanaryRunConfigBlock>? RunConfig
    {
        get => GetProperty<List<AwsSyntheticsCanaryRunConfigBlock>>("run_config");
        set => this.WithProperty("run_config", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AwsSyntheticsCanaryScheduleBlock>? Schedule
    {
        get => GetProperty<List<AwsSyntheticsCanaryScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsSyntheticsCanaryVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsSyntheticsCanaryVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
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
