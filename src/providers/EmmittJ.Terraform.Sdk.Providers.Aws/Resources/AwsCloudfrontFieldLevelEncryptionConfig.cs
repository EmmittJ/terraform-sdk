using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_type_profile_config in AwsCloudfrontFieldLevelEncryptionConfig.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_type_profile_config";

    /// <summary>
    /// The forward_when_content_type_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenContentTypeIsUnknown is required")]
    public required TerraformValue<bool> ForwardWhenContentTypeIsUnknown
    {
        get => new TerraformReference<bool>(this, "forward_when_content_type_is_unknown");
        set => SetArgument("forward_when_content_type_is_unknown", value);
    }

    /// <summary>
    /// ContentTypeProfiles block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypeProfiles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTypeProfiles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeProfiles block(s) allowed")]
    public required TerraformList<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlock> ContentTypeProfiles
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlock>>("content_type_profiles");
        set => SetArgument("content_type_profiles", value);
    }

}

/// <summary>
/// Block type for content_type_profiles in AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_type_profiles";

    /// <summary>
    /// Items block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Items is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Items block(s) required")]
    public required TerraformSet<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlockItemsBlock> Items
    {
        get => GetRequiredArgument<TerraformSet<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlockContentTypeProfilesBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

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
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformValue<string>? ProfileId
    {
        get => new TerraformReference<string>(this, "profile_id");
        set => SetArgument("profile_id", value);
    }

}


/// <summary>
/// Block type for query_arg_profile_config in AwsCloudfrontFieldLevelEncryptionConfig.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_arg_profile_config";

    /// <summary>
    /// The forward_when_query_arg_profile_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenQueryArgProfileIsUnknown is required")]
    public required TerraformValue<bool> ForwardWhenQueryArgProfileIsUnknown
    {
        get => new TerraformReference<bool>(this, "forward_when_query_arg_profile_is_unknown");
        set => SetArgument("forward_when_query_arg_profile_is_unknown", value);
    }

    /// <summary>
    /// QueryArgProfiles block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryArgProfiles block(s) allowed")]
    public TerraformList<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlock>? QueryArgProfiles
    {
        get => GetArgument<TerraformList<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlock>>("query_arg_profiles");
        set => SetArgument("query_arg_profiles", value);
    }

}

/// <summary>
/// Block type for query_arg_profiles in AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_arg_profiles";

    /// <summary>
    /// Items block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformSet<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlockQueryArgProfilesBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformValue<string> ProfileId
    {
        get => new TerraformReference<string>(this, "profile_id");
        set => SetArgument("profile_id", value);
    }

    /// <summary>
    /// The query_arg attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryArg is required")]
    public required TerraformValue<string> QueryArg
    {
        get => new TerraformReference<string>(this, "query_arg");
        set => SetArgument("query_arg", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_field_level_encryption_config Terraform resource.
/// Manages a aws_cloudfront_field_level_encryption_config resource.
/// </summary>
public partial class AwsCloudfrontFieldLevelEncryptionConfig(string name) : TerraformResource("aws_cloudfront_field_level_encryption_config", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
    {
        get => new TerraformReference<string>(this, "caller_reference");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// ContentTypeProfileConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypeProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTypeProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeProfileConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock> ContentTypeProfileConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock>>("content_type_profile_config");
        set => SetArgument("content_type_profile_config", value);
    }

    /// <summary>
    /// QueryArgProfileConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryArgProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryArgProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryArgProfileConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock> QueryArgProfileConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock>>("query_arg_profile_config");
        set => SetArgument("query_arg_profile_config", value);
    }

}
