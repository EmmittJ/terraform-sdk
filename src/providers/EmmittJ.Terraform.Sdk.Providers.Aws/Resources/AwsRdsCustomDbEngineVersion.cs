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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("create_time");
        SetOutput("db_parameter_group_family");
        SetOutput("image_id");
        SetOutput("major_engine_version");
        SetOutput("manifest_computed");
        SetOutput("database_installation_files_s3_bucket_name");
        SetOutput("database_installation_files_s3_prefix");
        SetOutput("description");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("filename");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("manifest");
        SetOutput("manifest_hash");
        SetOutput("region");
        SetOutput("source_image_id");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The database_installation_files_s3_bucket_name attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseInstallationFilesS3BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_installation_files_s3_bucket_name");
        set => SetProperty("database_installation_files_s3_bucket_name", value);
    }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseInstallationFilesS3Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_installation_files_s3_prefix");
        set => SetProperty("database_installation_files_s3_prefix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string> Filename
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filename");
        set => SetProperty("filename", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformProperty<string> Manifest
    {
        get => GetRequiredOutput<TerraformProperty<string>>("manifest");
        set => SetProperty("manifest", value);
    }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    public TerraformProperty<string> ManifestHash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("manifest_hash");
        set => SetProperty("manifest_hash", value);
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
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_image_id");
        set => SetProperty("source_image_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsCustomDbEngineVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
