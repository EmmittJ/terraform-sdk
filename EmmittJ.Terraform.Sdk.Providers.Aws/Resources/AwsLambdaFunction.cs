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
    public List<string>? Architectures
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("architectures")?.Value;
        set => this.WithProperty("architectures", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The code_signing_config_arn attribute.
    /// </summary>
    public string? CodeSigningConfigArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code_signing_config_arn")?.Value;
        set => this.WithProperty("code_signing_config_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public string? Filename
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filename")?.Value;
        set => this.WithProperty("filename", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public string? Handler
    {
        get => GetProperty<TerraformLiteralProperty<string>>("handler")?.Value;
        set => this.WithProperty("handler", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public string? ImageUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_uri")?.Value;
        set => this.WithProperty("image_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The layers attribute.
    /// </summary>
    public List<string>? Layers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("layers")?.Value;
        set => this.WithProperty("layers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The memory_size attribute.
    /// </summary>
    public double? MemorySize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("memory_size")?.Value;
        set => this.WithProperty("memory_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public string? PackageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_type")?.Value;
        set => this.WithProperty("package_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public bool? Publish
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publish")?.Value;
        set => this.WithProperty("publish", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The replace_security_groups_on_destroy attribute.
    /// </summary>
    public bool? ReplaceSecurityGroupsOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("replace_security_groups_on_destroy")?.Value;
        set => this.WithProperty("replace_security_groups_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The replacement_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? ReplacementSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("replacement_security_group_ids")?.Value;
        set => this.WithProperty("replacement_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The reserved_concurrent_executions attribute.
    /// </summary>
    public double? ReservedConcurrentExecutions
    {
        get => GetProperty<TerraformLiteralProperty<double>>("reserved_concurrent_executions")?.Value;
        set => this.WithProperty("reserved_concurrent_executions", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public string? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime")?.Value;
        set => this.WithProperty("runtime", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public string? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket")?.Value;
        set => this.WithProperty("s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public string? S3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key")?.Value;
        set => this.WithProperty("s3_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public string? S3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_object_version")?.Value;
        set => this.WithProperty("s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public string? SourceCodeHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_code_hash")?.Value;
        set => this.WithProperty("source_code_hash", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public double? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
