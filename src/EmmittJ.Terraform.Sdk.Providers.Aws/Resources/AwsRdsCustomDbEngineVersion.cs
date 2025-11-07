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
    public TerraformLiteralProperty<string>? DatabaseInstallationFilesS3BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_installation_files_s3_bucket_name");
        set => this.WithProperty("database_installation_files_s3_bucket_name", value);
    }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseInstallationFilesS3Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_installation_files_s3_prefix");
        set => this.WithProperty("database_installation_files_s3_prefix", value);
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
    /// The engine attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Manifest
    {
        get => GetProperty<TerraformLiteralProperty<string>>("manifest");
        set => this.WithProperty("manifest", value);
    }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManifestHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("manifest_hash");
        set => this.WithProperty("manifest_hash", value);
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
    /// The source_image_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_image_id");
        set => this.WithProperty("source_image_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status");
        set => this.WithProperty("status", value);
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
