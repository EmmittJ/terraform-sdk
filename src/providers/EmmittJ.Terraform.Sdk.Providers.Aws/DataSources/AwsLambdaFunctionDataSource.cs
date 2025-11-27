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
        get => new TerraformReference<string>(this, "function_name");
        set => SetArgument("function_name", value);
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
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => new TerraformReference<string>(this, "qualifier");
        set => SetArgument("qualifier", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformList<string> Architectures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "architectures").ResolveNodes(ctx));
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
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformValue<string> CodeSigningConfigArn
    {
        get => new TerraformReference<string>(this, "code_signing_config_arn");
    }

    /// <summary>
    /// The dead_letter_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeadLetterConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dead_letter_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Environment
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "environment").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EphemeralStorage
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ephemeral_storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The file_system_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FileSystemConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "file_system_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformValue<string> Handler
    {
        get => new TerraformReference<string>(this, "handler");
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string> ImageUri
    {
        get => new TerraformReference<string>(this, "image_uri");
    }

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> InvokeArn
    {
        get => new TerraformReference<string>(this, "invoke_arn");
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformList<string> Layers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "layers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LoggingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logging_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformValue<double> MemorySize
    {
        get => new TerraformReference<double>(this, "memory_size");
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
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformValue<double> ReservedConcurrentExecutions
    {
        get => new TerraformReference<double>(this, "reserved_concurrent_executions");
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string> Runtime
    {
        get => new TerraformReference<string>(this, "runtime");
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
    /// The source_code_hash attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> SourceCodeHash
    {
        get => new TerraformReference<string>(this, "source_code_hash");
    }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
    {
        get => new TerraformReference<double>(this, "source_code_size");
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceKmsKeyArn
    {
        get => new TerraformReference<string>(this, "source_kms_key_arn");
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double> Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TracingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "tracing_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_config").ResolveNodes(ctx));
    }

}
