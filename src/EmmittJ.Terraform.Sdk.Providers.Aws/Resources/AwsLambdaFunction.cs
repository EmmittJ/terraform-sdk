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
    public TerraformProperty<List<string>>? Architectures
    {
        get => GetProperty<TerraformProperty<List<string>>>("architectures");
        set => this.WithProperty("architectures", value);
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CodeSigningConfigArn
    {
        get => GetProperty<TerraformProperty<string>>("code_signing_config_arn");
        set => this.WithProperty("code_signing_config_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string>? Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => this.WithProperty("filename", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionName
    {
        get => GetProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformProperty<string>? Handler
    {
        get => GetProperty<TerraformProperty<string>>("handler");
        set => this.WithProperty("handler", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ImageUri
    {
        get => GetProperty<TerraformProperty<string>>("image_uri");
        set => this.WithProperty("image_uri", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Layers
    {
        get => GetProperty<TerraformProperty<List<string>>>("layers");
        set => this.WithProperty("layers", value);
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public TerraformProperty<double>? MemorySize
    {
        get => GetProperty<TerraformProperty<double>>("memory_size");
        set => this.WithProperty("memory_size", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformProperty<string>? PackageType
    {
        get => GetProperty<TerraformProperty<string>>("package_type");
        set => this.WithProperty("package_type", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformProperty<bool>? Publish
    {
        get => GetProperty<TerraformProperty<bool>>("publish");
        set => this.WithProperty("publish", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplaceSecurityGroupsOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("replace_security_groups_on_destroy");
        set => this.WithProperty("replace_security_groups_on_destroy", value);
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ReplacementSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("replacement_security_group_ids");
        set => this.WithProperty("replacement_security_group_ids", value);
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public TerraformProperty<double>? ReservedConcurrentExecutions
    {
        get => GetProperty<TerraformProperty<double>>("reserved_concurrent_executions");
        set => this.WithProperty("reserved_concurrent_executions", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        get => GetProperty<TerraformProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformProperty<string>? S3Key
    {
        get => GetProperty<TerraformProperty<string>>("s3_key");
        set => this.WithProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? S3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("s3_object_version");
        set => this.WithProperty("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformProperty<string>? SourceCodeHash
    {
        get => GetProperty<TerraformProperty<string>>("source_code_hash");
        set => this.WithProperty("source_code_hash", value);
    }

    /// <summary>
    /// The source_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceKmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("source_kms_key_arn");
        set => this.WithProperty("source_kms_key_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
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
