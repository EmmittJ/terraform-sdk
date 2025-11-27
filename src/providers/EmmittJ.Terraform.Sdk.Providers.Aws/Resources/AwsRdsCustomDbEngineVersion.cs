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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "database_installation_files_s3_bucket_name");
        set => SetArgument("database_installation_files_s3_bucket_name", value);
    }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseInstallationFilesS3Prefix
    {
        get => new TerraformReference<string>(this, "database_installation_files_s3_prefix");
        set => SetArgument("database_installation_files_s3_prefix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    public TerraformValue<string>? Manifest
    {
        get => new TerraformReference<string>(this, "manifest");
        set => SetArgument("manifest", value);
    }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    public TerraformValue<string>? ManifestHash
    {
        get => new TerraformReference<string>(this, "manifest_hash");
        set => SetArgument("manifest_hash", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
        set => SetArgument("source_image_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The db_parameter_group_family attribute.
    /// </summary>
    public TerraformValue<string> DbParameterGroupFamily
    {
        get => new TerraformReference<string>(this, "db_parameter_group_family");
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
    }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MajorEngineVersion
    {
        get => new TerraformReference<string>(this, "major_engine_version");
    }

    /// <summary>
    /// The manifest_computed attribute.
    /// </summary>
    public TerraformValue<string> ManifestComputed
    {
        get => new TerraformReference<string>(this, "manifest_computed");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsCustomDbEngineVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsCustomDbEngineVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
