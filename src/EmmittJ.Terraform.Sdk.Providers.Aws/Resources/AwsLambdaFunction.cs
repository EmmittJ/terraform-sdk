using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_function resource.
/// </summary>
public class AwsLambdaFunction : TerraformResource
{
    public AwsLambdaFunction(string name) : base("aws_lambda_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("code_sha256");
        this.DeclareOutput("invoke_arn");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("qualified_arn");
        this.DeclareOutput("qualified_invoke_arn");
        this.DeclareOutput("signing_job_arn");
        this.DeclareOutput("signing_profile_version_arn");
        this.DeclareOutput("source_code_size");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Architectures
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("architectures");
        set => this.WithProperty("architectures", value);
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CodeSigningConfigArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code_signing_config_arn");
        set => this.WithProperty("code_signing_config_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Filename
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filename");
        set => this.WithProperty("filename", value);
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
    /// The handler attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Handler
    {
        get => GetProperty<TerraformLiteralProperty<string>>("handler");
        set => this.WithProperty("handler", value);
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
    /// The image_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_uri");
        set => this.WithProperty("image_uri", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Layers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("layers");
        set => this.WithProperty("layers", value);
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MemorySize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("memory_size");
        set => this.WithProperty("memory_size", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PackageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_type");
        set => this.WithProperty("package_type", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Publish
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publish");
        set => this.WithProperty("publish", value);
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
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ReplaceSecurityGroupsOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("replace_security_groups_on_destroy");
        set => this.WithProperty("replace_security_groups_on_destroy", value);
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ReplacementSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("replacement_security_group_ids");
        set => this.WithProperty("replacement_security_group_ids", value);
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReservedConcurrentExecutions
    {
        get => GetProperty<TerraformLiteralProperty<double>>("reserved_concurrent_executions");
        set => this.WithProperty("reserved_concurrent_executions", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key");
        set => this.WithProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_object_version");
        set => this.WithProperty("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceCodeHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_code_hash");
        set => this.WithProperty("source_code_hash", value);
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceKmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_kms_key_arn");
        set => this.WithProperty("source_kms_key_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout");
        set => this.WithProperty("timeout", value);
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
