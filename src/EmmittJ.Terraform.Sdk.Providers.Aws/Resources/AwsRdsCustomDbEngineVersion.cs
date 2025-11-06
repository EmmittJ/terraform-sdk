using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_custom_db_engine_version resource.
/// </summary>
public class AwsRdsCustomDbEngineVersion : TerraformResource
{
    public AwsRdsCustomDbEngineVersion(string name) : base("aws_rds_custom_db_engine_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
        this.DeclareOutput("db_parameter_group_family");
        this.DeclareOutput("image_id");
        this.DeclareOutput("major_engine_version");
        this.DeclareOutput("manifest_computed");
    }

    /// <summary>
    /// The database_installation_files_s3_bucket_name attribute.
    /// </summary>
    public string? DatabaseInstallationFilesS3BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_installation_files_s3_bucket_name")?.Value;
        set => this.WithProperty("database_installation_files_s3_bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    public string? DatabaseInstallationFilesS3Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_installation_files_s3_prefix")?.Value;
        set => this.WithProperty("database_installation_files_s3_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public string? Manifest
    {
        get => GetProperty<TerraformLiteralProperty<string>>("manifest")?.Value;
        set => this.WithProperty("manifest", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    public string? ManifestHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("manifest_hash")?.Value;
        set => this.WithProperty("manifest_hash", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public string? SourceImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_image_id")?.Value;
        set => this.WithProperty("source_image_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The db_parameter_group_family attribute.
    /// </summary>
    public TerraformExpression DbParameterGroupFamily => this["db_parameter_group_family"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformExpression MajorEngineVersion => this["major_engine_version"];

    /// <summary>
    /// The manifest_computed attribute.
    /// </summary>
    public TerraformExpression ManifestComputed => this["manifest_computed"];

}
