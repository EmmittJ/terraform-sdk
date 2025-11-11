using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_function.
/// </summary>
public partial class AwsLambdaFunctionDataSource : TerraformDataSource
{
    public AwsLambdaFunctionDataSource(string name) : base("aws_lambda_function", name)
    {
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformProperty("qualifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    [TerraformProperty("architectures")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Architectures { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformProperty("code_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CodeSha256 { get; }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    [TerraformProperty("code_signing_config_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CodeSigningConfigArn { get; }

    /// <summary>
    /// The dead_letter_config attribute.
    /// </summary>
    [TerraformProperty("dead_letter_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DeadLetterConfig { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Environment { get; }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformProperty("ephemeral_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EphemeralStorage { get; }

    /// <summary>
    /// The file_system_config attribute.
    /// </summary>
    [TerraformProperty("file_system_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FileSystemConfig { get; }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [TerraformProperty("handler")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Handler { get; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformProperty("image_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageUri { get; }

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    [TerraformProperty("invoke_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvokeArn { get; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyArn { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    [TerraformProperty("layers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Layers { get; }

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    [TerraformProperty("logging_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LoggingConfig { get; }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    [TerraformProperty("memory_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySize { get; }

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    [TerraformProperty("qualified_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> QualifiedArn { get; }

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    [TerraformProperty("qualified_invoke_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> QualifiedInvokeArn { get; }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    [TerraformProperty("reserved_concurrent_executions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReservedConcurrentExecutions { get; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformProperty("role")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Role { get; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformProperty("runtime")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Runtime { get; }

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformProperty("signing_job_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SigningJobArn { get; }

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformProperty("signing_profile_version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SigningProfileVersionArn { get; }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformProperty("source_code_hash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceCodeHash { get; }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformProperty("source_code_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SourceCodeSize { get; }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("source_kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceKmsKeyArn { get; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Timeout { get; }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    [TerraformProperty("tracing_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TracingConfig { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformProperty("vpc_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VpcConfig { get; }

}
