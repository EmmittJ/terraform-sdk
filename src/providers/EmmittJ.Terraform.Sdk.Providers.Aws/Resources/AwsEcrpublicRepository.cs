using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_data in .
/// Nesting mode: list
/// </summary>
public class AwsEcrpublicRepositoryCatalogDataBlock : TerraformBlock
{
    /// <summary>
    /// The about_text attribute.
    /// </summary>
    public TerraformProperty<string>? AboutText
    {
        set => SetProperty("about_text", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Architectures
    {
        set => SetProperty("architectures", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The logo_image_blob attribute.
    /// </summary>
    public TerraformProperty<string>? LogoImageBlob
    {
        set => SetProperty("logo_image_blob", value);
    }

    /// <summary>
    /// The operating_systems attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OperatingSystems
    {
        set => SetProperty("operating_systems", value);
    }

    /// <summary>
    /// The usage_text attribute.
    /// </summary>
    public TerraformProperty<string>? UsageText
    {
        set => SetProperty("usage_text", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEcrpublicRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ecrpublic_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcrpublicRepository : TerraformResource
{
    public AwsEcrpublicRepository(string name) : base("aws_ecrpublic_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("registry_id");
        SetOutput("repository_uri");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("region");
        SetOutput("repository_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_name");
        set => SetProperty("repository_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for catalog_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogData block(s) allowed")]
    public List<AwsEcrpublicRepositoryCatalogDataBlock>? CatalogData
    {
        set => SetProperty("catalog_data", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEcrpublicRepositoryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

    /// <summary>
    /// The repository_uri attribute.
    /// </summary>
    public TerraformExpression RepositoryUri => this["repository_uri"];

}
