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
        set => SetProperty("target_arn", value);
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
        set => SetProperty("variables", value);
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
        set => SetProperty("size", value);
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
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The local_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalMountPath is required")]
    public required TerraformProperty<string> LocalMountPath
    {
        set => SetProperty("local_mount_path", value);
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
        set => SetProperty("command", value);
    }

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EntryPoint
    {
        set => SetProperty("entry_point", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformProperty<string>? WorkingDirectory
    {
        set => SetProperty("working_directory", value);
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
        set => SetProperty("application_log_level", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    public required TerraformProperty<string> LogFormat
    {
        set => SetProperty("log_format", value);
    }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformProperty<string>? LogGroup
    {
        set => SetProperty("log_group", value);
    }

    /// <summary>
    /// The system_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? SystemLogLevel
    {
        set => SetProperty("system_log_level", value);
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
        set => SetProperty("apply_on", value);
    }

    /// <summary>
    /// The optimization_status attribute.
    /// </summary>
    public TerraformProperty<string>? OptimizationStatus
    {
        set => SetProperty("optimization_status", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("mode", value);
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
        set => SetProperty("ipv6_allowed_for_dual_stack", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
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
        SetOutput("arn");
        SetOutput("code_sha256");
        SetOutput("invoke_arn");
        SetOutput("last_modified");
        SetOutput("qualified_arn");
        SetOutput("qualified_invoke_arn");
        SetOutput("signing_job_arn");
        SetOutput("signing_profile_version_arn");
        SetOutput("source_code_size");
        SetOutput("version");
        SetOutput("architectures");
        SetOutput("code_signing_config_arn");
        SetOutput("description");
        SetOutput("filename");
        SetOutput("function_name");
        SetOutput("handler");
        SetOutput("id");
        SetOutput("image_uri");
        SetOutput("kms_key_arn");
        SetOutput("layers");
        SetOutput("memory_size");
        SetOutput("package_type");
        SetOutput("publish");
        SetOutput("region");
        SetOutput("replace_security_groups_on_destroy");
        SetOutput("replacement_security_group_ids");
        SetOutput("reserved_concurrent_executions");
        SetOutput("role");
        SetOutput("runtime");
        SetOutput("s3_bucket");
        SetOutput("s3_key");
        SetOutput("s3_object_version");
        SetOutput("skip_destroy");
        SetOutput("source_code_hash");
        SetOutput("source_kms_key_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("timeout");
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public List<TerraformProperty<string>> Architectures
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("architectures");
        set => SetProperty("architectures", value);
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformProperty<string> CodeSigningConfigArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("code_signing_config_arn");
        set => SetProperty("code_signing_config_arn", value);
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
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string> Filename
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filename");
        set => SetProperty("filename", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformProperty<string> Handler
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
    /// The image_uri attribute.
    /// </summary>
    public TerraformProperty<string> ImageUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_uri");
        set => SetProperty("image_uri", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public List<TerraformProperty<string>> Layers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("layers");
        set => SetProperty("layers", value);
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformProperty<double> MemorySize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("memory_size");
        set => SetProperty("memory_size", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformProperty<string> PackageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_type");
        set => SetProperty("package_type", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformProperty<bool> Publish
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publish");
        set => SetProperty("publish", value);
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
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ReplaceSecurityGroupsOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("replace_security_groups_on_destroy");
        set => SetProperty("replace_security_groups_on_destroy", value);
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ReplacementSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("replacement_security_group_ids");
        set => SetProperty("replacement_security_group_ids", value);
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformProperty<double> ReservedConcurrentExecutions
    {
        get => GetRequiredOutput<TerraformProperty<double>>("reserved_concurrent_executions");
        set => SetProperty("reserved_concurrent_executions", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role");
        set => SetProperty("role", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformProperty<string> Runtime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime");
        set => SetProperty("runtime", value);
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
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string> S3ObjectVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_object_version");
        set => SetProperty("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformProperty<string> SourceCodeHash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_code_hash");
        set => SetProperty("source_code_hash", value);
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> SourceKmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_kms_key_arn");
        set => SetProperty("source_kms_key_arn", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public List<AwsLambdaFunctionDeadLetterConfigBlock>? DeadLetterConfig
    {
        set => SetProperty("dead_letter_config", value);
    }

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public List<AwsLambdaFunctionEnvironmentBlock>? Environment
    {
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public List<AwsLambdaFunctionEphemeralStorageBlock>? EphemeralStorage
    {
        set => SetProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// Block for file_system_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    public List<AwsLambdaFunctionFileSystemConfigBlock>? FileSystemConfig
    {
        set => SetProperty("file_system_config", value);
    }

    /// <summary>
    /// Block for image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    public List<AwsLambdaFunctionImageConfigBlock>? ImageConfig
    {
        set => SetProperty("image_config", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<AwsLambdaFunctionLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
    }

    /// <summary>
    /// Block for snap_start.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapStart block(s) allowed")]
    public List<AwsLambdaFunctionSnapStartBlock>? SnapStart
    {
        set => SetProperty("snap_start", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLambdaFunctionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tracing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfig block(s) allowed")]
    public List<AwsLambdaFunctionTracingConfigBlock>? TracingConfig
    {
        set => SetProperty("tracing_config", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsLambdaFunctionVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
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
