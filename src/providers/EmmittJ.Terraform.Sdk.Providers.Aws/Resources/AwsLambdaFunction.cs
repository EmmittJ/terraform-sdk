using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionDeadLetterConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformProperty("target_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetArn { get; set; }

}

/// <summary>
/// Block type for environment in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionEnvironmentBlock : TerraformBlockBase
{
    /// <summary>
    /// The variables attribute.
    /// </summary>
    [TerraformProperty("variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Variables { get; set; }

}

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionEphemeralStorageBlock : TerraformBlockBase
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Size { get; set; }

}

/// <summary>
/// Block type for file_system_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionFileSystemConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The local_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalMountPath is required")]
    [TerraformProperty("local_mount_path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LocalMountPath { get; set; }

}

/// <summary>
/// Block type for image_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionImageConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The command attribute.
    /// </summary>
    [TerraformProperty("command")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Command { get; set; }

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    [TerraformProperty("entry_point")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? EntryPoint { get; set; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformProperty("working_directory")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WorkingDirectory { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The application_log_level attribute.
    /// </summary>
    [TerraformProperty("application_log_level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApplicationLogLevel { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFormat is required")]
    [TerraformProperty("log_format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogFormat { get; set; }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    [TerraformProperty("log_group")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LogGroup { get; set; }

    /// <summary>
    /// The system_log_level attribute.
    /// </summary>
    [TerraformProperty("system_log_level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SystemLogLevel { get; set; }

}

/// <summary>
/// Block type for snap_start in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionSnapStartBlock : TerraformBlockBase
{
    /// <summary>
    /// The apply_on attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplyOn is required")]
    [TerraformProperty("apply_on")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplyOn { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLambdaFunctionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tracing_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionTracingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The ipv6_allowed_for_dual_stack attribute.
    /// </summary>
    [TerraformProperty("ipv6_allowed_for_dual_stack")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Ipv6AllowedForDualStack { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }


}

/// <summary>
/// Manages a aws_lambda_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLambdaFunction : TerraformResource
{
    public AwsLambdaFunction(string name) : base("aws_lambda_function", name)
    {
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformProperty("architectures")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> Architectures { get; set; }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    [TerraformProperty("code_signing_config_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CodeSigningConfigArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformProperty("filename")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [TerraformProperty("handler")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Handler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformProperty("image_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageUri { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    [TerraformProperty("layers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Layers { get; set; }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformProperty("memory_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MemorySize { get; set; }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    [TerraformProperty("package_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PackageType { get; set; }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    [TerraformProperty("publish")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Publish { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    [TerraformProperty("replace_security_groups_on_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ReplaceSecurityGroupsOnDestroy { get; set; }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("replacement_security_group_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ReplacementSecurityGroupIds { get; set; }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    [TerraformProperty("reserved_concurrent_executions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ReservedConcurrentExecutions { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformProperty("runtime")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Runtime { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformProperty("s3_bucket")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [TerraformProperty("s3_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3Key { get; set; }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    [TerraformProperty("s3_object_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3ObjectVersion { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformProperty("source_code_hash")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SourceCodeHash { get; set; }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("source_kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceKmsKeyArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    [TerraformProperty("dead_letter_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionDeadLetterConfigBlock>>? DeadLetterConfig { get; set; }

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    [TerraformProperty("environment")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionEnvironmentBlock>>? Environment { get; set; }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    [TerraformProperty("ephemeral_storage")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionEphemeralStorageBlock>>? EphemeralStorage { get; set; }

    /// <summary>
    /// Block for file_system_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    [TerraformProperty("file_system_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionFileSystemConfigBlock>>? FileSystemConfig { get; set; }

    /// <summary>
    /// Block for image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    [TerraformProperty("image_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionImageConfigBlock>>? ImageConfig { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// Block for snap_start.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapStart block(s) allowed")]
    [TerraformProperty("snap_start")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionSnapStartBlock>>? SnapStart { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsLambdaFunctionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for tracing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfig block(s) allowed")]
    [TerraformProperty("tracing_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionTracingConfigBlock>>? TracingConfig { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformProperty("code_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CodeSha256 { get; }

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    [TerraformProperty("invoke_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InvokeArn { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    [TerraformProperty("qualified_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QualifiedArn { get; }

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    [TerraformProperty("qualified_invoke_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QualifiedInvokeArn { get; }

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformProperty("signing_job_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningJobArn { get; }

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformProperty("signing_profile_version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningProfileVersionArn { get; }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformProperty("source_code_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SourceCodeSize { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
