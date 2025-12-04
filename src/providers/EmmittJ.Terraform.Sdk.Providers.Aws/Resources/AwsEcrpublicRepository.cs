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
        get => GetArgument<TerraformValue<string>>("about_text");
        set => SetArgument("about_text", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public TerraformSet<string>? Architectures
    {
        get => GetArgument<TerraformSet<string>>("architectures");
        set => SetArgument("architectures", value);
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
    /// The logo_image_blob attribute.
    /// </summary>
    public TerraformValue<string> LogoImageBlob
    {
        get => GetArgument<TerraformValue<string>>("logo_image_blob") ?? AsReference("logo_image_blob");
        set => SetArgument("logo_image_blob", value);
    }

    /// <summary>
    /// The operating_systems attribute.
    /// </summary>
    public TerraformSet<string>? OperatingSystems
    {
        get => GetArgument<TerraformSet<string>>("operating_systems");
        set => SetArgument("operating_systems", value);
    }

    /// <summary>
    /// The usage_text attribute.
    /// </summary>
    public TerraformValue<string>? UsageText
    {
        get => GetArgument<TerraformValue<string>>("usage_text");
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
        get => GetArgument<TerraformValue<string>>("delete");
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
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
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
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
        => AsReference("registry_id");

    /// <summary>
    /// The repository_uri attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUri
        => AsReference("repository_uri");

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
