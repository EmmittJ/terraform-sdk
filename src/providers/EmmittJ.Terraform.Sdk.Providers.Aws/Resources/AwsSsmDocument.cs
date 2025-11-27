using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_source in AwsSsmDocument.
/// Nesting mode: list
/// </summary>
public class AwsSsmDocumentAttachmentsSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attachments_source";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ssm_document Terraform resource.
/// Manages a aws_ssm_document resource.
/// </summary>
public partial class AwsSsmDocument(string name) : TerraformResource("aws_ssm_document", name)
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformValue<string>? DocumentFormat
    {
        get => new TerraformReference<string>(this, "document_format");
        set => SetArgument("document_format", value);
    }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentType is required")]
    public required TerraformValue<string> DocumentType
    {
        get => new TerraformReference<string>(this, "document_type");
        set => SetArgument("document_type", value);
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
    /// The permissions attribute.
    /// </summary>
    public TerraformMap<string>? Permissions
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "permissions").ResolveNodes(ctx));
        set => SetArgument("permissions", value);
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
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetType
    {
        get => new TerraformReference<string>(this, "target_type");
        set => SetArgument("target_type", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformValue<string>? VersionName
    {
        get => new TerraformReference<string>(this, "version_name");
        set => SetArgument("version_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultVersion
    {
        get => new TerraformReference<string>(this, "default_version");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string> DocumentVersion
    {
        get => new TerraformReference<string>(this, "document_version");
    }

    /// <summary>
    /// The hash attribute.
    /// </summary>
    public TerraformValue<string> Hash
    {
        get => new TerraformReference<string>(this, "hash");
    }

    /// <summary>
    /// The hash_type attribute.
    /// </summary>
    public TerraformValue<string> HashType
    {
        get => new TerraformReference<string>(this, "hash_type");
    }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<string> LatestVersion
    {
        get => new TerraformReference<string>(this, "latest_version");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Parameter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "parameter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The platform_types attribute.
    /// </summary>
    public TerraformList<string> PlatformTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "platform_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The schema_version attribute.
    /// </summary>
    public TerraformValue<string> SchemaVersion
    {
        get => new TerraformReference<string>(this, "schema_version");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// AttachmentsSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 AttachmentsSource block(s) allowed")]
    public TerraformList<AwsSsmDocumentAttachmentsSourceBlock>? AttachmentsSource
    {
        get => GetArgument<TerraformList<AwsSsmDocumentAttachmentsSourceBlock>>("attachments_source");
        set => SetArgument("attachments_source", value);
    }

}
