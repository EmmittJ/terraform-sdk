using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for location in AwsMskconnectCustomPlugin.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectCustomPluginLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public required TerraformList<AwsMskconnectCustomPluginLocationBlockS3Block> S3
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectCustomPluginLocationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsMskconnectCustomPluginLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectCustomPluginLocationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The file_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileKey is required")]
    public required TerraformValue<string> FileKey
    {
        get => new TerraformReference<string>(this, "file_key");
        set => SetArgument("file_key", value);
    }

    /// <summary>
    /// The object_version attribute.
    /// </summary>
    public TerraformValue<string>? ObjectVersion
    {
        get => new TerraformReference<string>(this, "object_version");
        set => SetArgument("object_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMskconnectCustomPlugin.
/// Nesting mode: single
/// </summary>
public class AwsMskconnectCustomPluginTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_mskconnect_custom_plugin Terraform resource.
/// Manages a aws_mskconnect_custom_plugin resource.
/// </summary>
public partial class AwsMskconnectCustomPlugin(string name) : TerraformResource("aws_mskconnect_custom_plugin", name)
{
    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The latest_revision attribute.
    /// </summary>
    public TerraformValue<double> LatestRevision
    {
        get => new TerraformReference<double>(this, "latest_revision");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Location block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Location block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public required TerraformList<AwsMskconnectCustomPluginLocationBlock> Location
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectCustomPluginLocationBlock>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMskconnectCustomPluginTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMskconnectCustomPluginTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
