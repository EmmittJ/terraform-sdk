using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsCustomDbEngineVersion.
/// Nesting mode: single
/// </summary>
public class AwsRdsCustomDbEngineVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_rds_custom_db_engine_version Terraform resource.
/// Manages a aws_rds_custom_db_engine_version resource.
/// </summary>
public partial class AwsRdsCustomDbEngineVersion(string name) : TerraformResource("aws_rds_custom_db_engine_version", name)
{
    /// <summary>
    /// The database_installation_files_s3_bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseInstallationFilesS3BucketName
    {
        get => GetArgument<TerraformValue<string>>("database_installation_files_s3_bucket_name");
        set => SetArgument("database_installation_files_s3_bucket_name", value);
    }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseInstallationFilesS3Prefix
    {
        get => GetArgument<TerraformValue<string>>("database_installation_files_s3_prefix");
        set => SetArgument("database_installation_files_s3_prefix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformValue<string> EngineVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => GetArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? AsReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformValue<string>? Manifest
    {
        get => GetArgument<TerraformValue<string>>("manifest");
        set => SetArgument("manifest", value);
    }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    public TerraformValue<string>? ManifestHash
    {
        get => GetArgument<TerraformValue<string>>("manifest_hash");
        set => SetArgument("manifest_hash", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceImageId
    {
        get => GetArgument<TerraformValue<string>>("source_image_id");
        set => SetArgument("source_image_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? AsReference("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The db_parameter_group_family attribute.
    /// </summary>
    public TerraformValue<string> DbParameterGroupFamily
        => AsReference("db_parameter_group_family");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => AsReference("image_id");

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MajorEngineVersion
        => AsReference("major_engine_version");

    /// <summary>
    /// The manifest_computed attribute.
    /// </summary>
    public TerraformValue<string> ManifestComputed
        => AsReference("manifest_computed");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsCustomDbEngineVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsCustomDbEngineVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
