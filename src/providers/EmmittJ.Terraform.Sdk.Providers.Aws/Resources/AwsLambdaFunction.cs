using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dead_letter_config in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_config";

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformValue<string> TargetArn
    {
        get => GetArgument<TerraformValue<string>>("target_arn");
        set => SetArgument("target_arn", value);
    }

}


/// <summary>
/// Block type for environment in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public TerraformMap<string>? Variables
    {
        get => GetArgument<TerraformMap<string>>("variables");
        set => SetArgument("variables", value);
    }

}


/// <summary>
/// Block type for ephemeral_storage in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEphemeralStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_storage";

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

}


/// <summary>
/// Block type for file_system_config in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The local_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalMountPath is required")]
    public required TerraformValue<string> LocalMountPath
    {
        get => GetArgument<TerraformValue<string>>("local_mount_path");
        set => SetArgument("local_mount_path", value);
    }

}


/// <summary>
/// Block type for image_config in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_config";

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    public TerraformList<string>? EntryPoint
    {
        get => GetArgument<TerraformList<string>>("entry_point");
        set => SetArgument("entry_point", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string>? WorkingDirectory
    {
        get => GetArgument<TerraformValue<string>>("working_directory");
        set => SetArgument("working_directory", value);
    }

}


/// <summary>
/// Block type for logging_config in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The application_log_level attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationLogLevel
    {
        get => GetArgument<TerraformValue<string>>("application_log_level");
        set => SetArgument("application_log_level", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformValue<string> LogFormat
    {
        get => GetArgument<TerraformValue<string>>("log_format");
        set => SetArgument("log_format", value);
    }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformValue<string>? LogGroup
    {
        get => GetArgument<TerraformValue<string>>("log_group");
        set => SetArgument("log_group", value);
    }

    /// <summary>
    /// The system_log_level attribute.
    /// </summary>
    public TerraformValue<string>? SystemLogLevel
    {
        get => GetArgument<TerraformValue<string>>("system_log_level");
        set => SetArgument("system_log_level", value);
    }

}


/// <summary>
/// Block type for snap_start in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionSnapStartBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snap_start";

    /// <summary>
    /// The apply_on attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplyOn is required")]
    public required TerraformValue<string> ApplyOn
    {
        get => GetArgument<TerraformValue<string>>("apply_on");
        set => SetArgument("apply_on", value);
    }

    /// <summary>
    /// The optimization_status attribute.
    /// </summary>
    public TerraformValue<string> OptimizationStatus
        => AsReference("optimization_status");

}


/// <summary>
/// Block type for timeouts in AwsLambdaFunction.
/// Nesting mode: single
/// </summary>
public class AwsLambdaFunctionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for tracing_config in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionTracingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tracing_config";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsLambdaFunction.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionVpcConfigBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
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
/// Represents a aws_lambda_function Terraform resource.
/// Manages a aws_lambda_function resource.
/// </summary>
public partial class AwsLambdaFunction(string name) : TerraformResource("aws_lambda_function", name)
{
    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformList<string>? Architectures
    {
        get => GetArgument<TerraformList<string>>("architectures");
        set => SetArgument("architectures", value);
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? CodeSigningConfigArn
    {
        get => GetArgument<TerraformValue<string>>("code_signing_config_arn");
        set => SetArgument("code_signing_config_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => GetArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformValue<string>? Handler
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
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string>? ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformList<string>? Layers
    {
        get => GetArgument<TerraformList<string>>("layers");
        set => SetArgument("layers", value);
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double>? MemorySize
    {
        get => GetArgument<TerraformValue<double>>("memory_size");
        set => SetArgument("memory_size", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformValue<string>? PackageType
    {
        get => GetArgument<TerraformValue<string>>("package_type");
        set => SetArgument("package_type", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformValue<bool>? Publish
    {
        get => GetArgument<TerraformValue<bool>>("publish");
        set => SetArgument("publish", value);
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
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ReplaceSecurityGroupsOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("replace_security_groups_on_destroy");
        set => SetArgument("replace_security_groups_on_destroy", value);
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? ReplacementSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("replacement_security_group_ids");
        set => SetArgument("replacement_security_group_ids", value);
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformValue<double>? ReservedConcurrentExecutions
    {
        get => GetArgument<TerraformValue<double>>("reserved_concurrent_executions");
        set => SetArgument("reserved_concurrent_executions", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string>? Runtime
    {
        get => GetArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
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
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("s3_object_version");
        set => SetArgument("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => GetArgument<TerraformValue<bool>>("skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformValue<string>? SourceCodeHash
    {
        get => GetArgument<TerraformValue<string>>("source_code_hash");
        set => SetArgument("source_code_hash", value);
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceKmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("source_kms_key_arn");
        set => SetArgument("source_kms_key_arn", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => GetArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformValue<string> CodeSha256
        => AsReference("code_sha256");

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> InvokeArn
        => AsReference("invoke_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => AsReference("last_modified");

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    public TerraformValue<string> QualifiedArn
        => AsReference("qualified_arn");

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> QualifiedInvokeArn
        => AsReference("qualified_invoke_arn");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningJobArn
        => AsReference("signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningProfileVersionArn
        => AsReference("signing_profile_version_arn");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
        => AsReference("source_code_size");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// DeadLetterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionDeadLetterConfigBlock>>("dead_letter_config");
        set => SetArgument("dead_letter_config", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public TerraformList<AwsLambdaFunctionEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// EphemeralStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public TerraformList<AwsLambdaFunctionEphemeralStorageBlock>? EphemeralStorage
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionEphemeralStorageBlock>>("ephemeral_storage");
        set => SetArgument("ephemeral_storage", value);
    }

    /// <summary>
    /// FileSystemConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionFileSystemConfigBlock>? FileSystemConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionFileSystemConfigBlock>>("file_system_config");
        set => SetArgument("file_system_config", value);
    }

    /// <summary>
    /// ImageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionImageConfigBlock>? ImageConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionImageConfigBlock>>("image_config");
        set => SetArgument("image_config", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// SnapStart block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapStart block(s) allowed")]
    public TerraformList<AwsLambdaFunctionSnapStartBlock>? SnapStart
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionSnapStartBlock>>("snap_start");
        set => SetArgument("snap_start", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLambdaFunctionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLambdaFunctionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TracingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionTracingConfigBlock>? TracingConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionTracingConfigBlock>>("tracing_config");
        set => SetArgument("tracing_config", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
