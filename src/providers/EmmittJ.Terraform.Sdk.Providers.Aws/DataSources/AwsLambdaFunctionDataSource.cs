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
    public required TerraformProperty<TerraformProperty<string>> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformPropertyName("qualifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformPropertyName("architectures")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Architectures => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "architectures");

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
    /// The code_signing_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("code_signing_config_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CodeSigningConfigArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "code_signing_config_arn");

    /// <summary>
    /// The dead_letter_config attribute.
    /// </summary>
    [TerraformPropertyName("dead_letter_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DeadLetterConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dead_letter_config");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Environment => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "environment");

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EphemeralStorage => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ephemeral_storage");

    /// <summary>
    /// The file_system_config attribute.
    /// </summary>
    [TerraformPropertyName("file_system_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FileSystemConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "file_system_config");

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [TerraformPropertyName("handler")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Handler => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "handler");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_uri");

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    [TerraformPropertyName("invoke_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvokeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invoke_arn");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The layers attribute.
    /// </summary>
    [TerraformPropertyName("layers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Layers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "layers");

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    [TerraformPropertyName("logging_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LoggingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logging_config");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformPropertyName("memory_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size");

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
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    [TerraformPropertyName("reserved_concurrent_executions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReservedConcurrentExecutions => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "reserved_concurrent_executions");

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformPropertyName("role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Role => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role");

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Runtime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "runtime");

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
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_code_hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceCodeHash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_code_hash");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformPropertyName("source_code_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SourceCodeSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "source_code_size");

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceKmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_kms_key_arn");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Timeout => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "timeout");

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    [TerraformPropertyName("tracing_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TracingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tracing_config");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_config");

}
