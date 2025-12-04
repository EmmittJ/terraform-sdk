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
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
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
        get => GetRequiredArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformValue<string>? DocumentFormat
    {
        get => GetArgument<TerraformValue<string>>("document_format");
        set => SetArgument("document_format", value);
    }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentType is required")]
    public required TerraformValue<string> DocumentType
    {
        get => GetRequiredArgument<TerraformValue<string>>("document_type");
        set => SetArgument("document_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformMap<string>? Permissions
    {
        get => GetArgument<TerraformMap<string>>("permissions");
        set => SetArgument("permissions", value);
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
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetType
    {
        get => GetArgument<TerraformValue<string>>("target_type");
        set => SetArgument("target_type", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformValue<string>? VersionName
    {
        get => GetArgument<TerraformValue<string>>("version_name");
        set => SetArgument("version_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultVersion
        => AsReference("default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string> DocumentVersion
        => AsReference("document_version");

    /// <summary>
    /// The hash attribute.
    /// </summary>
    public TerraformValue<string> Hash
        => AsReference("hash");

    /// <summary>
    /// The hash_type attribute.
    /// </summary>
    public TerraformValue<string> HashType
        => AsReference("hash_type");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<string> LatestVersion
        => AsReference("latest_version");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Parameter
        => AsReference("parameter");

    /// <summary>
    /// The platform_types attribute.
    /// </summary>
    public TerraformList<string> PlatformTypes
        => AsReference("platform_types");

    /// <summary>
    /// The schema_version attribute.
    /// </summary>
    public TerraformValue<string> SchemaVersion
        => AsReference("schema_version");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

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
