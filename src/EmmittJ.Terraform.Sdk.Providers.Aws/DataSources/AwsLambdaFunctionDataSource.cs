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
        this.DeclareOutput("architectures");
        this.DeclareOutput("arn");
        this.DeclareOutput("code_sha256");
        this.DeclareOutput("code_signing_config_arn");
        this.DeclareOutput("dead_letter_config");
        this.DeclareOutput("description");
        this.DeclareOutput("environment");
        this.DeclareOutput("ephemeral_storage");
        this.DeclareOutput("file_system_config");
        this.DeclareOutput("handler");
        this.DeclareOutput("image_uri");
        this.DeclareOutput("invoke_arn");
        this.DeclareOutput("kms_key_arn");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("layers");
        this.DeclareOutput("logging_config");
        this.DeclareOutput("memory_size");
        this.DeclareOutput("qualified_arn");
        this.DeclareOutput("qualified_invoke_arn");
        this.DeclareOutput("reserved_concurrent_executions");
        this.DeclareOutput("role");
        this.DeclareOutput("runtime");
        this.DeclareOutput("signing_job_arn");
        this.DeclareOutput("signing_profile_version_arn");
        this.DeclareOutput("source_code_hash");
        this.DeclareOutput("source_code_size");
        this.DeclareOutput("source_kms_key_arn");
        this.DeclareOutput("timeout");
        this.DeclareOutput("tracing_config");
        this.DeclareOutput("version");
        this.DeclareOutput("vpc_config");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
