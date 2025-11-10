using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsCustomDbEngineVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? DatabaseInstallationFilesS3BucketName
    {
        get => GetProperty<TerraformProperty<string>>("database_installation_files_s3_bucket_name");
        set => this.WithProperty("database_installation_files_s3_bucket_name", value);
    }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseInstallationFilesS3Prefix
    {
        get => GetProperty<TerraformProperty<string>>("database_installation_files_s3_prefix");
        set => this.WithProperty("database_installation_files_s3_prefix", value);
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
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformProperty<string> EngineVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformProperty<string>? Manifest
    {
        get => GetProperty<TerraformProperty<string>>("manifest");
        set => this.WithProperty("manifest", value);
    }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    public TerraformProperty<string>? ManifestHash
    {
        get => GetProperty<TerraformProperty<string>>("manifest_hash");
        set => this.WithProperty("manifest_hash", value);
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
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceImageId
    {
        get => GetProperty<TerraformProperty<string>>("source_image_id");
        set => this.WithProperty("source_image_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsCustomDbEngineVersionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRdsCustomDbEngineVersionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
