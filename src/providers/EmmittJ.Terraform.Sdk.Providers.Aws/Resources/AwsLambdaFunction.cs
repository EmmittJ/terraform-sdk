using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionDeadLetterConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformPropertyName("target_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetArn { get; set; }

}

/// <summary>
/// Block type for environment in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEnvironmentBlock : ITerraformBlock
{
    /// <summary>
    /// The variables attribute.
    /// </summary>
    [TerraformPropertyName("variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Variables { get; set; }

}

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEphemeralStorageBlock : ITerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Size { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "size");

}

/// <summary>
/// Block type for file_system_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionFileSystemConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The local_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalMountPath is required")]
    [TerraformPropertyName("local_mount_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LocalMountPath { get; set; }

}

/// <summary>
/// Block type for image_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionImageConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The command attribute.
    /// </summary>
    [TerraformPropertyName("command")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Command { get; set; }

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    [TerraformPropertyName("entry_point")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? EntryPoint { get; set; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformPropertyName("working_directory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkingDirectory { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The application_log_level attribute.
    /// </summary>
    [TerraformPropertyName("application_log_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationLogLevel { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    [TerraformPropertyName("log_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogFormat { get; set; }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    [TerraformPropertyName("log_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "log_group");

    /// <summary>
    /// The system_log_level attribute.
    /// </summary>
    [TerraformPropertyName("system_log_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SystemLogLevel { get; set; }

}

/// <summary>
/// Block type for snap_start in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionSnapStartBlock : ITerraformBlock
{
    /// <summary>
    /// The apply_on attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplyOn is required")]
    [TerraformPropertyName("apply_on")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplyOn { get; set; }

    /// <summary>
    /// The optimization_status attribute.
    /// </summary>
    [TerraformPropertyName("optimization_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OptimizationStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "optimization_status");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLambdaFunctionTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for tracing_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionTracingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The ipv6_allowed_for_dual_stack attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_allowed_for_dual_stack")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Ipv6AllowedForDualStack { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>("", "vpc_id");

}

/// <summary>
/// Manages a aws_lambda_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaFunction : TerraformResource
{
    public AwsLambdaFunction(string name) : base("aws_lambda_function", name)
    {
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformPropertyName("architectures")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Architectures { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "architectures");

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("code_signing_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CodeSigningConfigArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformPropertyName("filename")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filename { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionName { get; set; }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [TerraformPropertyName("handler")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Handler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageUri { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    [TerraformPropertyName("layers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Layers { get; set; }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformPropertyName("memory_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MemorySize { get; set; }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [TerraformPropertyName("package_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PackageType { get; set; }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    [TerraformPropertyName("publish")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Publish { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    [TerraformPropertyName("replace_security_groups_on_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReplaceSecurityGroupsOnDestroy { get; set; }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("replacement_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ReplacementSecurityGroupIds { get; set; }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    [TerraformPropertyName("reserved_concurrent_executions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReservedConcurrentExecutions { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Role { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Runtime { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [TerraformPropertyName("s3_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Key { get; set; }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("s3_object_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3ObjectVersion { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_code_hash")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SourceCodeHash { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_code_hash");

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceKmsKeyArn { get; set; }

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
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Timeout { get; set; }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    [TerraformPropertyName("dead_letter_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionDeadLetterConfigBlock>>? DeadLetterConfig { get; set; } = new();

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    [TerraformPropertyName("environment")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionEnvironmentBlock>>? Environment { get; set; } = new();

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    [TerraformPropertyName("ephemeral_storage")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionEphemeralStorageBlock>>? EphemeralStorage { get; set; } = new();

    /// <summary>
    /// Block for file_system_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    [TerraformPropertyName("file_system_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionFileSystemConfigBlock>>? FileSystemConfig { get; set; } = new();

    /// <summary>
    /// Block for image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    [TerraformPropertyName("image_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionImageConfigBlock>>? ImageConfig { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for snap_start.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapStart block(s) allowed")]
    [TerraformPropertyName("snap_start")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionSnapStartBlock>>? SnapStart { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLambdaFunctionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tracing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfig block(s) allowed")]
    [TerraformPropertyName("tracing_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionTracingConfigBlock>>? TracingConfig { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("code_sha256")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CodeSha256 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "code_sha256");

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    [TerraformPropertyName("invoke_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvokeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invoke_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    [TerraformPropertyName("qualified_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QualifiedArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "qualified_arn");

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    [TerraformPropertyName("qualified_invoke_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QualifiedInvokeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "qualified_invoke_arn");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_job_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningJobArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_profile_version_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningProfileVersionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_profile_version_arn");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformPropertyName("source_code_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SourceCodeSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "source_code_size");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
