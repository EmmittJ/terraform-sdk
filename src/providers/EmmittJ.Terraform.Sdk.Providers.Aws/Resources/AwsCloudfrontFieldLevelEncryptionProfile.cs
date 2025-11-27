using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_entities in AwsCloudfrontFieldLevelEncryptionProfile.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_entities";

    /// <summary>
    /// Items block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformSet<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The provider_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    public required TerraformValue<string> ProviderId
    {
        get => new TerraformReference<string>(this, "provider_id");
        set => SetArgument("provider_id", value);
    }

    /// <summary>
    /// The public_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKeyId is required")]
    public required TerraformValue<string> PublicKeyId
    {
        get => new TerraformReference<string>(this, "public_key_id");
        set => SetArgument("public_key_id", value);
    }

    /// <summary>
    /// FieldPatterns block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldPatterns is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldPatterns block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FieldPatterns block(s) allowed")]
    public required TerraformList<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlockFieldPatternsBlock> FieldPatterns
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlockFieldPatternsBlock>>("field_patterns");
        set => SetArgument("field_patterns", value);
    }

}

/// <summary>
/// Block type for field_patterns in AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlockItemsBlockFieldPatternsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_patterns";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "items").ResolveNodes(ctx));
        set => SetArgument("items", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_field_level_encryption_profile Terraform resource.
/// Manages a aws_cloudfront_field_level_encryption_profile resource.
/// </summary>
public partial class AwsCloudfrontFieldLevelEncryptionProfile(string name) : TerraformResource("aws_cloudfront_field_level_encryption_profile", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// EncryptionEntities block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionEntities is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionEntities block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionEntities block(s) allowed")]
    public required TerraformList<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlock> EncryptionEntities
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontFieldLevelEncryptionProfileEncryptionEntitiesBlock>>("encryption_entities");
        set => SetArgument("encryption_entities", value);
    }

}
