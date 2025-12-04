using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_function Terraform data source.
/// Retrieves information about a aws_lambda_function.
/// </summary>
public partial class AwsLambdaFunctionDataSource(string name) : TerraformDataSource("aws_lambda_function", name)
{
    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => GetArgument<TerraformValue<string>>("qualifier");
        set => SetArgument("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformList<string> Architectures
        => AsReference("architectures");

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
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformValue<string> CodeSigningConfigArn
        => AsReference("code_signing_config_arn");

    /// <summary>
    /// The dead_letter_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeadLetterConfig
        => AsReference("dead_letter_config");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Environment
        => AsReference("environment");

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralStorage
        => AsReference("ephemeral_storage");

    /// <summary>
    /// The file_system_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FileSystemConfig
        => AsReference("file_system_config");

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformValue<string> Handler
        => AsReference("handler");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string> ImageUri
        => AsReference("image_uri");

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> InvokeArn
        => AsReference("invoke_arn");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => AsReference("last_modified");

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformList<string> Layers
        => AsReference("layers");

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LoggingConfig
        => AsReference("logging_config");

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double> MemorySize
        => AsReference("memory_size");

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
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformValue<double> ReservedConcurrentExecutions
        => AsReference("reserved_concurrent_executions");

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformValue<string> Role
        => AsReference("role");

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string> Runtime
        => AsReference("runtime");

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
    /// The source_code_hash attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> SourceCodeHash
        => AsReference("source_code_hash");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
        => AsReference("source_code_size");

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceKmsKeyArn
        => AsReference("source_kms_key_arn");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double> Timeout
        => AsReference("timeout");

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TracingConfig
        => AsReference("tracing_config");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
        => AsReference("vpc_config");

}
