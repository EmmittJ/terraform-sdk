using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_config in AwsElastictranscoderPipeline.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineContentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_config";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket") ?? CreateReference("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}


/// <summary>
/// Block type for content_config_permissions in AwsElastictranscoderPipeline.
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineContentConfigPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_config_permissions";

    /// <summary>
    /// The access attribute.
    /// </summary>
    public TerraformList<string>? Access
    {
        get => GetArgument<TerraformList<string>>("access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformValue<string>? Grantee
    {
        get => GetArgument<TerraformValue<string>>("grantee");
        set => SetArgument("grantee", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    public TerraformValue<string>? GranteeType
    {
        get => GetArgument<TerraformValue<string>>("grantee_type");
        set => SetArgument("grantee_type", value);
    }

}


/// <summary>
/// Block type for notifications in AwsElastictranscoderPipeline.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notifications";

    /// <summary>
    /// The completed attribute.
    /// </summary>
    public TerraformValue<string>? Completed
    {
        get => GetArgument<TerraformValue<string>>("completed");
        set => SetArgument("completed", value);
    }

    /// <summary>
    /// The error attribute.
    /// </summary>
    public TerraformValue<string>? Error
    {
        get => GetArgument<TerraformValue<string>>("error");
        set => SetArgument("error", value);
    }

    /// <summary>
    /// The progressing attribute.
    /// </summary>
    public TerraformValue<string>? Progressing
    {
        get => GetArgument<TerraformValue<string>>("progressing");
        set => SetArgument("progressing", value);
    }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    public TerraformValue<string>? Warning
    {
        get => GetArgument<TerraformValue<string>>("warning");
        set => SetArgument("warning", value);
    }

}


/// <summary>
/// Block type for thumbnail_config in AwsElastictranscoderPipeline.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "thumbnail_config";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket") ?? CreateReference("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}


/// <summary>
/// Block type for thumbnail_config_permissions in AwsElastictranscoderPipeline.
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "thumbnail_config_permissions";

    /// <summary>
    /// The access attribute.
    /// </summary>
    public TerraformList<string>? Access
    {
        get => GetArgument<TerraformList<string>>("access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformValue<string>? Grantee
    {
        get => GetArgument<TerraformValue<string>>("grantee");
        set => SetArgument("grantee", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    public TerraformValue<string>? GranteeType
    {
        get => GetArgument<TerraformValue<string>>("grantee_type");
        set => SetArgument("grantee_type", value);
    }

}


/// <summary>
/// Represents a aws_elastictranscoder_pipeline Terraform resource.
/// Manages a aws_elastictranscoder_pipeline resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsElastictranscoderPipeline(string name) : TerraformResource("aws_elastictranscoder_pipeline", name)
{
    /// <summary>
    /// The aws_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? AwsKmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("aws_kms_key_arn");
        set => SetArgument("aws_kms_key_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The input_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputBucket is required")]
    public required TerraformValue<string> InputBucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("input_bucket");
        set => SetArgument("input_bucket", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    public TerraformValue<string> OutputBucket
    {
        get => GetArgument<TerraformValue<string>>("output_bucket") ?? CreateReference("output_bucket");
        set => SetArgument("output_bucket", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetRequiredArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// ContentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentConfig block(s) allowed")]
    public TerraformList<AwsElastictranscoderPipelineContentConfigBlock>? ContentConfig
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPipelineContentConfigBlock>>("content_config");
        set => SetArgument("content_config", value);
    }

    /// <summary>
    /// ContentConfigPermissions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElastictranscoderPipelineContentConfigPermissionsBlock>? ContentConfigPermissions
    {
        get => GetArgument<TerraformSet<AwsElastictranscoderPipelineContentConfigPermissionsBlock>>("content_config_permissions");
        set => SetArgument("content_config_permissions", value);
    }

    /// <summary>
    /// Notifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    public TerraformList<AwsElastictranscoderPipelineNotificationsBlock>? Notifications
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPipelineNotificationsBlock>>("notifications");
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// ThumbnailConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfig block(s) allowed")]
    public TerraformList<AwsElastictranscoderPipelineThumbnailConfigBlock>? ThumbnailConfig
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPipelineThumbnailConfigBlock>>("thumbnail_config");
        set => SetArgument("thumbnail_config", value);
    }

    /// <summary>
    /// ThumbnailConfigPermissions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>? ThumbnailConfigPermissions
    {
        get => GetArgument<TerraformSet<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>>("thumbnail_config_permissions");
        set => SetArgument("thumbnail_config_permissions", value);
    }

}
