using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_config in AwsSyntheticsCanary.
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryArtifactConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "artifact_config";

    /// <summary>
    /// S3Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Encryption block(s) allowed")]
    public TerraformList<AwsSyntheticsCanaryArtifactConfigBlockS3EncryptionBlock>? S3Encryption
    {
        get => GetArgument<TerraformList<AwsSyntheticsCanaryArtifactConfigBlockS3EncryptionBlock>>("s3_encryption");
        set => SetArgument("s3_encryption", value);
    }

}

/// <summary>
/// Block type for s3_encryption in AwsSyntheticsCanaryArtifactConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryArtifactConfigBlockS3EncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_encryption";

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("encryption_mode");
        set => SetArgument("encryption_mode", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Block type for run_config in AwsSyntheticsCanary.
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryRunConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "run_config";

    /// <summary>
    /// The active_tracing attribute.
    /// </summary>
    public TerraformValue<bool>? ActiveTracing
    {
        get => GetArgument<TerraformValue<bool>>("active_tracing");
        set => SetArgument("active_tracing", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformValue<double>? EphemeralStorage
    {
        get => GetArgument<TerraformValue<double>>("ephemeral_storage");
        set => SetArgument("ephemeral_storage", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? MemoryInMb
    {
        get => GetArgument<TerraformValue<double>>("memory_in_mb");
        set => SetArgument("memory_in_mb", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

}


/// <summary>
/// Block type for schedule in AwsSyntheticsCanary.
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DurationInSeconds
    {
        get => GetArgument<TerraformValue<double>>("duration_in_seconds");
        set => SetArgument("duration_in_seconds", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// RetryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    public TerraformList<AwsSyntheticsCanaryScheduleBlockRetryConfigBlock>? RetryConfig
    {
        get => GetArgument<TerraformList<AwsSyntheticsCanaryScheduleBlockRetryConfigBlock>>("retry_config");
        set => SetArgument("retry_config", value);
    }

}

/// <summary>
/// Block type for retry_config in AwsSyntheticsCanaryScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryScheduleBlockRetryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_config";

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetries is required")]
    public required TerraformValue<double> MaxRetries
    {
        get => GetArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsSyntheticsCanary.
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The ipv6_allowed_for_dual_stack attribute.
    /// </summary>
    public TerraformValue<bool>? Ipv6AllowedForDualStack
    {
        get => GetArgument<TerraformValue<bool>>("ipv6_allowed_for_dual_stack");
        set => SetArgument("ipv6_allowed_for_dual_stack", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}


/// <summary>
/// Represents a aws_synthetics_canary Terraform resource.
/// Manages a aws_synthetics_canary resource.
/// </summary>
public partial class AwsSyntheticsCanary(string name) : TerraformResource("aws_synthetics_canary", name)
{
    /// <summary>
    /// The artifact_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactS3Location is required")]
    public required TerraformValue<string> ArtifactS3Location
    {
        get => GetArgument<TerraformValue<string>>("artifact_s3_location");
        set => SetArgument("artifact_s3_location", value);
    }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteLambda
    {
        get => GetArgument<TerraformValue<bool>>("delete_lambda");
        set => SetArgument("delete_lambda", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? FailureRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("failure_retention_period");
        set => SetArgument("failure_retention_period", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handler is required")]
    public required TerraformValue<string> Handler
    {
        get => GetArgument<TerraformValue<string>>("handler");
        set => SetArgument("handler", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformValue<string> RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? S3Bucket
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformValue<string>? S3Key
    {
        get => GetArgument<TerraformValue<string>>("s3_key");
        set => SetArgument("s3_key", value);
    }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    public TerraformValue<string>? S3Version
    {
        get => GetArgument<TerraformValue<string>>("s3_version");
        set => SetArgument("s3_version", value);
    }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    public TerraformValue<bool>? StartCanary
    {
        get => GetArgument<TerraformValue<bool>>("start_canary");
        set => SetArgument("start_canary", value);
    }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? SuccessRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("success_retention_period");
        set => SetArgument("success_retention_period", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The zip_file attribute.
    /// </summary>
    public TerraformValue<string>? ZipFile
    {
        get => GetArgument<TerraformValue<string>>("zip_file");
        set => SetArgument("zip_file", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The engine_arn attribute.
    /// </summary>
    public TerraformValue<string> EngineArn
        => AsReference("engine_arn");

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceLocationArn
        => AsReference("source_location_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The timeline attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Timeline
        => AsReference("timeline");

    /// <summary>
    /// ArtifactConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArtifactConfig block(s) allowed")]
    public TerraformList<AwsSyntheticsCanaryArtifactConfigBlock>? ArtifactConfig
    {
        get => GetArgument<TerraformList<AwsSyntheticsCanaryArtifactConfigBlock>>("artifact_config");
        set => SetArgument("artifact_config", value);
    }

    /// <summary>
    /// RunConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunConfig block(s) allowed")]
    public TerraformList<AwsSyntheticsCanaryRunConfigBlock>? RunConfig
    {
        get => GetArgument<TerraformList<AwsSyntheticsCanaryRunConfigBlock>>("run_config");
        set => SetArgument("run_config", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<AwsSyntheticsCanaryScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AwsSyntheticsCanaryScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsSyntheticsCanaryVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsSyntheticsCanaryVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
