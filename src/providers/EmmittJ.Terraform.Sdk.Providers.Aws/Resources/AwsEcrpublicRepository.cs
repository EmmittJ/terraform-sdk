using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_data in AwsEcrpublicRepository.
/// Nesting mode: list
/// </summary>
public class AwsEcrpublicRepositoryCatalogDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "catalog_data";

    /// <summary>
    /// The about_text attribute.
    /// </summary>
    public TerraformValue<string>? AboutText
    {
        get => new TerraformReference<string>(this, "about_text");
        set => SetArgument("about_text", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformSet<string>? Architectures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "architectures").ResolveNodes(ctx));
        set => SetArgument("architectures", value);
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
    /// The logo_image_blob attribute.
    /// </summary>
    public TerraformValue<string> LogoImageBlob
    {
        get => new TerraformReference<string>(this, "logo_image_blob");
        set => SetArgument("logo_image_blob", value);
    }

    /// <summary>
    /// The operating_systems attribute.
    /// </summary>
    public TerraformSet<string>? OperatingSystems
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "operating_systems").ResolveNodes(ctx));
        set => SetArgument("operating_systems", value);
    }

    /// <summary>
    /// The usage_text attribute.
    /// </summary>
    public TerraformValue<string>? UsageText
    {
        get => new TerraformReference<string>(this, "usage_text");
        set => SetArgument("usage_text", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEcrpublicRepository.
/// Nesting mode: single
/// </summary>
public class AwsEcrpublicRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a aws_ecrpublic_repository Terraform resource.
/// Manages a aws_ecrpublic_repository resource.
/// </summary>
public partial class AwsEcrpublicRepository(string name) : TerraformResource("aws_ecrpublic_repository", name)
{
    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
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
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
    }

    /// <summary>
    /// The repository_uri attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUri
    {
        get => new TerraformReference<string>(this, "repository_uri");
    }

    /// <summary>
    /// CatalogData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogData block(s) allowed")]
    public TerraformList<AwsEcrpublicRepositoryCatalogDataBlock>? CatalogData
    {
        get => GetArgument<TerraformList<AwsEcrpublicRepositoryCatalogDataBlock>>("catalog_data");
        set => SetArgument("catalog_data", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEcrpublicRepositoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEcrpublicRepositoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
