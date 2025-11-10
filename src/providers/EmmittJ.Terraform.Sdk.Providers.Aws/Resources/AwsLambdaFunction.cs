using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformProperty<string> TargetArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_arn");
        set => WithProperty("target_arn", value);
    }

}

/// <summary>
/// Block type for environment in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Variables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("variables");
        set => WithProperty("variables", value);
    }

}

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEphemeralStorageBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

}

/// <summary>
/// Block type for file_system_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The local_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalMountPath is required")]
    public required TerraformProperty<string> LocalMountPath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("local_mount_path");
        set => WithProperty("local_mount_path", value);
    }

}

/// <summary>
/// Block type for image_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// The command attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Command
    {
        get => GetProperty<List<TerraformProperty<string>>>("command");
        set => WithProperty("command", value);
    }

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EntryPoint
    {
        get => GetProperty<List<TerraformProperty<string>>>("entry_point");
        set => WithProperty("entry_point", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformProperty<string>? WorkingDirectory
    {
        get => GetProperty<TerraformProperty<string>>("working_directory");
        set => WithProperty("working_directory", value);
    }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The application_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("application_log_level");
        set => WithProperty("application_log_level", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformProperty<string> LogFormat
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_format");
        set => WithProperty("log_format", value);
    }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformProperty<string>? LogGroup
    {
        get => GetProperty<TerraformProperty<string>>("log_group");
        set => WithProperty("log_group", value);
    }

    /// <summary>
    /// The system_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? SystemLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("system_log_level");
        set => WithProperty("system_log_level", value);
    }

}

/// <summary>
/// Block type for snap_start in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionSnapStartBlock : TerraformBlock
{
    /// <summary>
    /// The apply_on attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplyOn is required")]
    public required TerraformProperty<string> ApplyOn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("apply_on");
        set => WithProperty("apply_on", value);
    }

    /// <summary>
    /// The optimization_status attribute.
    /// </summary>
    public TerraformProperty<string>? OptimizationStatus
    {
        get => GetProperty<TerraformProperty<string>>("optimization_status");
        set => WithProperty("optimization_status", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLambdaFunctionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for tracing_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionTracingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionVpcConfigBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
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
/// Manages a aws_lambda_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaFunction : TerraformResource
{
    public AwsLambdaFunction(string name) : base("aws_lambda_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("code_sha256");
        this.WithOutput("invoke_arn");
        this.WithOutput("last_modified");
        this.WithOutput("qualified_arn");
        this.WithOutput("qualified_invoke_arn");
        this.WithOutput("signing_job_arn");
        this.WithOutput("signing_profile_version_arn");
        this.WithOutput("source_code_size");
        this.WithOutput("version");
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Architectures
    {
        get => GetProperty<List<TerraformProperty<string>>>("architectures");
        set => this.WithProperty("architectures", value);
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CodeSigningConfigArn
    {
        get => GetProperty<TerraformProperty<string>>("code_signing_config_arn");
        set => this.WithProperty("code_signing_config_arn", value);
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
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string>? Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => this.WithProperty("filename", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformProperty<string>? Handler
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
    /// The image_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ImageUri
    {
        get => GetProperty<TerraformProperty<string>>("image_uri");
        set => this.WithProperty("image_uri", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Layers
    {
        get => GetProperty<List<TerraformProperty<string>>>("layers");
        set => this.WithProperty("layers", value);
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformProperty<double>? MemorySize
    {
        get => GetProperty<TerraformProperty<double>>("memory_size");
        set => this.WithProperty("memory_size", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformProperty<string>? PackageType
    {
        get => GetProperty<TerraformProperty<string>>("package_type");
        set => this.WithProperty("package_type", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformProperty<bool>? Publish
    {
        get => GetProperty<TerraformProperty<bool>>("publish");
        set => this.WithProperty("publish", value);
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
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplaceSecurityGroupsOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("replace_security_groups_on_destroy");
        set => this.WithProperty("replace_security_groups_on_destroy", value);
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ReplacementSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("replacement_security_group_ids");
        set => this.WithProperty("replacement_security_group_ids", value);
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformProperty<double>? ReservedConcurrentExecutions
    {
        get => GetProperty<TerraformProperty<double>>("reserved_concurrent_executions");
        set => this.WithProperty("reserved_concurrent_executions", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        get => GetProperty<TerraformProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
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
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? S3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("s3_object_version");
        set => this.WithProperty("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformProperty<string>? SourceCodeHash
    {
        get => GetProperty<TerraformProperty<string>>("source_code_hash");
        set => this.WithProperty("source_code_hash", value);
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceKmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("source_kms_key_arn");
        set => this.WithProperty("source_kms_key_arn", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public List<AwsLambdaFunctionDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetProperty<List<AwsLambdaFunctionDeadLetterConfigBlock>>("dead_letter_config");
        set => this.WithProperty("dead_letter_config", value);
    }

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public List<AwsLambdaFunctionEnvironmentBlock>? Environment
    {
        get => GetProperty<List<AwsLambdaFunctionEnvironmentBlock>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public List<AwsLambdaFunctionEphemeralStorageBlock>? EphemeralStorage
    {
        get => GetProperty<List<AwsLambdaFunctionEphemeralStorageBlock>>("ephemeral_storage");
        set => this.WithProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// Block for file_system_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    public List<AwsLambdaFunctionFileSystemConfigBlock>? FileSystemConfig
    {
        get => GetProperty<List<AwsLambdaFunctionFileSystemConfigBlock>>("file_system_config");
        set => this.WithProperty("file_system_config", value);
    }

    /// <summary>
    /// Block for image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    public List<AwsLambdaFunctionImageConfigBlock>? ImageConfig
    {
        get => GetProperty<List<AwsLambdaFunctionImageConfigBlock>>("image_config");
        set => this.WithProperty("image_config", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<AwsLambdaFunctionLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<AwsLambdaFunctionLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// Block for snap_start.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapStart block(s) allowed")]
    public List<AwsLambdaFunctionSnapStartBlock>? SnapStart
    {
        get => GetProperty<List<AwsLambdaFunctionSnapStartBlock>>("snap_start");
        set => this.WithProperty("snap_start", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLambdaFunctionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLambdaFunctionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tracing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfig block(s) allowed")]
    public List<AwsLambdaFunctionTracingConfigBlock>? TracingConfig
    {
        get => GetProperty<List<AwsLambdaFunctionTracingConfigBlock>>("tracing_config");
        set => this.WithProperty("tracing_config", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsLambdaFunctionVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsLambdaFunctionVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformExpression CodeSha256 => this["code_sha256"];

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformExpression InvokeArn => this["invoke_arn"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    public TerraformExpression QualifiedArn => this["qualified_arn"];

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    public TerraformExpression QualifiedInvokeArn => this["qualified_invoke_arn"];

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformExpression SigningJobArn => this["signing_job_arn"];

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformExpression SigningProfileVersionArn => this["signing_profile_version_arn"];

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformExpression SourceCodeSize => this["source_code_size"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
