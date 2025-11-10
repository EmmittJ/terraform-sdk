using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_function.
/// </summary>
public class AwsLambdaFunctionDataSource : TerraformDataSource
{
    public AwsLambdaFunctionDataSource(string name) : base("aws_lambda_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("architectures");
        SetOutput("arn");
        SetOutput("code_sha256");
        SetOutput("code_signing_config_arn");
        SetOutput("dead_letter_config");
        SetOutput("description");
        SetOutput("environment");
        SetOutput("ephemeral_storage");
        SetOutput("file_system_config");
        SetOutput("handler");
        SetOutput("image_uri");
        SetOutput("invoke_arn");
        SetOutput("kms_key_arn");
        SetOutput("last_modified");
        SetOutput("layers");
        SetOutput("logging_config");
        SetOutput("memory_size");
        SetOutput("qualified_arn");
        SetOutput("qualified_invoke_arn");
        SetOutput("reserved_concurrent_executions");
        SetOutput("role");
        SetOutput("runtime");
        SetOutput("signing_job_arn");
        SetOutput("signing_profile_version_arn");
        SetOutput("source_code_hash");
        SetOutput("source_code_size");
        SetOutput("source_kms_key_arn");
        SetOutput("timeout");
        SetOutput("tracing_config");
        SetOutput("version");
        SetOutput("vpc_config");
        SetOutput("function_name");
        SetOutput("id");
        SetOutput("qualifier");
        SetOutput("region");
        SetOutput("tags");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string> Qualifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qualifier");
        set => SetProperty("qualifier", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformExpression Architectures => this["architectures"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformExpression CodeSha256 => this["code_sha256"];

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformExpression CodeSigningConfigArn => this["code_signing_config_arn"];

    /// <summary>
    /// The dead_letter_config attribute.
    /// </summary>
    public TerraformExpression DeadLetterConfig => this["dead_letter_config"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformExpression Environment => this["environment"];

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformExpression EphemeralStorage => this["ephemeral_storage"];

    /// <summary>
    /// The file_system_config attribute.
    /// </summary>
    public TerraformExpression FileSystemConfig => this["file_system_config"];

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformExpression Handler => this["handler"];

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformExpression ImageUri => this["image_uri"];

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformExpression InvokeArn => this["invoke_arn"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformExpression Layers => this["layers"];

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    public TerraformExpression LoggingConfig => this["logging_config"];

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformExpression MemorySize => this["memory_size"];

    /// <summary>
    /// The qualified_arn attribute.
    /// </summary>
    public TerraformExpression QualifiedArn => this["qualified_arn"];

    /// <summary>
    /// The qualified_invoke_arn attribute.
    /// </summary>
    public TerraformExpression QualifiedInvokeArn => this["qualified_invoke_arn"];

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformExpression ReservedConcurrentExecutions => this["reserved_concurrent_executions"];

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformExpression Role => this["role"];

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformExpression Runtime => this["runtime"];

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformExpression SigningJobArn => this["signing_job_arn"];

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformExpression SigningProfileVersionArn => this["signing_profile_version_arn"];

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformExpression SourceCodeHash => this["source_code_hash"];

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformExpression SourceCodeSize => this["source_code_size"];

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformExpression SourceKmsKeyArn => this["source_kms_key_arn"];

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformExpression Timeout => this["timeout"];

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformExpression TracingConfig => this["tracing_config"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformExpression VpcConfig => this["vpc_config"];

}
