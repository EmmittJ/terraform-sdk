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
        get => new TerraformReference<string>(this, "target_arn");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "variables").ResolveNodes(ctx));
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
    public TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The local_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalMountPath is required")]
    public required TerraformValue<string> LocalMountPath
    {
        get => new TerraformReference<string>(this, "local_mount_path");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "command").ResolveNodes(ctx));
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    public TerraformList<string>? EntryPoint
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "entry_point").ResolveNodes(ctx));
        set => SetArgument("entry_point", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string>? WorkingDirectory
    {
        get => new TerraformReference<string>(this, "working_directory");
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
        get => new TerraformReference<string>(this, "application_log_level");
        set => SetArgument("application_log_level", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformValue<string> LogFormat
    {
        get => new TerraformReference<string>(this, "log_format");
        set => SetArgument("log_format", value);
    }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformValue<string> LogGroup
    {
        get => new TerraformReference<string>(this, "log_group");
        set => SetArgument("log_group", value);
    }

    /// <summary>
    /// The system_log_level attribute.
    /// </summary>
    public TerraformValue<string>? SystemLogLevel
    {
        get => new TerraformReference<string>(this, "system_log_level");
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
        get => new TerraformReference<string>(this, "apply_on");
        set => SetArgument("apply_on", value);
    }

    /// <summary>
    /// The optimization_status attribute.
    /// </summary>
    public TerraformValue<string> OptimizationStatus
    {
        get => new TerraformReference<string>(this, "optimization_status");
    }

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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "mode");
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
        get => new TerraformReference<bool>(this, "ipv6_allowed_for_dual_stack");
        set => SetArgument("ipv6_allowed_for_dual_stack", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

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
    public TerraformList<string> Architectures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "architectures").ResolveNodes(ctx));
        set => SetArgument("architectures", value);
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? CodeSigningConfigArn
    {
        get => new TerraformReference<string>(this, "code_signing_config_arn");
        set => SetArgument("code_signing_config_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => new TerraformReference<string>(this, "function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformValue<string>? Handler
    {
        get => new TerraformReference<string>(this, "handler");
        set => SetArgument("handler", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string>? ImageUri
    {
        get => new TerraformReference<string>(this, "image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformList<string>? Layers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "layers").ResolveNodes(ctx));
        set => SetArgument("layers", value);
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double>? MemorySize
    {
        get => new TerraformReference<double>(this, "memory_size");
        set => SetArgument("memory_size", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformValue<string>? PackageType
    {
        get => new TerraformReference<string>(this, "package_type");
        set => SetArgument("package_type", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformValue<bool>? Publish
    {
        get => new TerraformReference<bool>(this, "publish");
        set => SetArgument("publish", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ReplaceSecurityGroupsOnDestroy
    {
        get => new TerraformReference<bool>(this, "replace_security_groups_on_destroy");
        set => SetArgument("replace_security_groups_on_destroy", value);
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? ReplacementSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "replacement_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("replacement_security_group_ids", value);
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformValue<double>? ReservedConcurrentExecutions
    {
        get => new TerraformReference<double>(this, "reserved_concurrent_executions");
        set => SetArgument("reserved_concurrent_executions", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string>? Runtime
    {
        get => new TerraformReference<string>(this, "runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? S3Bucket
    {
        get => new TerraformReference<string>(this, "s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformValue<string>? S3Key
    {
        get => new TerraformReference<string>(this, "s3_key");
        set => SetArgument("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectVersion
    {
        get => new TerraformReference<string>(this, "s3_object_version");
        set => SetArgument("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformValue<string> SourceCodeHash
    {
        get => new TerraformReference<string>(this, "source_code_hash");
        set => SetArgument("source_code_hash", value);
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceKmsKeyArn
    {
        get => new TerraformReference<string>(this, "source_kms_key_arn");
        set => SetArgument("source_kms_key_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformValue<string> CodeSha256
    {
        get => new TerraformReference<string>(this, "code_sha256");
    }

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> InvokeArn
    {
        get => new TerraformReference<string>(this, "invoke_arn");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    public TerraformValue<string> QualifiedArn
    {
        get => new TerraformReference<string>(this, "qualified_arn");
    }

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> QualifiedInvokeArn
    {
        get => new TerraformReference<string>(this, "qualified_invoke_arn");
    }

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningJobArn
    {
        get => new TerraformReference<string>(this, "signing_job_arn");
    }

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningProfileVersionArn
    {
        get => new TerraformReference<string>(this, "signing_profile_version_arn");
    }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
    {
        get => new TerraformReference<double>(this, "source_code_size");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

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
