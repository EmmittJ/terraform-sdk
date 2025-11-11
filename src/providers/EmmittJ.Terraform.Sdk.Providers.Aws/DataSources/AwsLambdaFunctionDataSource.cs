using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_function.
/// </summary>
public class AwsLambdaFunctionDataSource : TerraformDataSource
{
    public AwsLambdaFunctionDataSource(string name) : base("aws_lambda_function", name)
    {
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformPropertyName("qualifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformPropertyName("architectures")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Architectures => new TerraformReference(this, "architectures");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("code_sha256")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CodeSha256 => new TerraformReference(this, "code_sha256");

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("code_signing_config_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CodeSigningConfigArn => new TerraformReference(this, "code_signing_config_arn");

    /// <summary>
    /// The dead_letter_config attribute.
    /// </summary>
    [TerraformPropertyName("dead_letter_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DeadLetterConfig => new TerraformReference(this, "dead_letter_config");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Environment => new TerraformReference(this, "environment");

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EphemeralStorage => new TerraformReference(this, "ephemeral_storage");

    /// <summary>
    /// The file_system_config attribute.
    /// </summary>
    [TerraformPropertyName("file_system_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FileSystemConfig => new TerraformReference(this, "file_system_config");

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [TerraformPropertyName("handler")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Handler => new TerraformReference(this, "handler");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageUri => new TerraformReference(this, "image_uri");

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    [TerraformPropertyName("invoke_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InvokeArn => new TerraformReference(this, "invoke_arn");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyArn => new TerraformReference(this, "kms_key_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The layers attribute.
    /// </summary>
    [TerraformPropertyName("layers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Layers => new TerraformReference(this, "layers");

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    [TerraformPropertyName("logging_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LoggingConfig => new TerraformReference(this, "logging_config");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformPropertyName("memory_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySize => new TerraformReference(this, "memory_size");

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    [TerraformPropertyName("qualified_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QualifiedArn => new TerraformReference(this, "qualified_arn");

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    [TerraformPropertyName("qualified_invoke_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QualifiedInvokeArn => new TerraformReference(this, "qualified_invoke_arn");

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    [TerraformPropertyName("reserved_concurrent_executions")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReservedConcurrentExecutions => new TerraformReference(this, "reserved_concurrent_executions");

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformPropertyName("role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Role => new TerraformReference(this, "role");

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Runtime => new TerraformReference(this, "runtime");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_job_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SigningJobArn => new TerraformReference(this, "signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_profile_version_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SigningProfileVersionArn => new TerraformReference(this, "signing_profile_version_arn");

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_code_hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceCodeHash => new TerraformReference(this, "source_code_hash");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformPropertyName("source_code_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SourceCodeSize => new TerraformReference(this, "source_code_size");

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceKmsKeyArn => new TerraformReference(this, "source_kms_key_arn");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Timeout => new TerraformReference(this, "timeout");

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    [TerraformPropertyName("tracing_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TracingConfig => new TerraformReference(this, "tracing_config");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpcConfig => new TerraformReference(this, "vpc_config");

}
