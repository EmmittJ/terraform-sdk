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
        get => GetProperty<TerraformProperty<string>>("about_text");
        set => WithProperty("about_text", value);
    }

    /// <summary>
    /// The architectures attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Architectures
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("architectures");
        set => WithProperty("architectures", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The logo_image_blob attribute.
    /// </summary>
    public TerraformProperty<string>? LogoImageBlob
    {
        get => GetProperty<TerraformProperty<string>>("logo_image_blob");
        set => WithProperty("logo_image_blob", value);
    }

    /// <summary>
    /// The operating_systems attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OperatingSystems
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("operating_systems");
        set => WithProperty("operating_systems", value);
    }

    /// <summary>
    /// The usage_text attribute.
    /// </summary>
    public TerraformProperty<string>? UsageText
    {
        get => GetProperty<TerraformProperty<string>>("usage_text");
        set => WithProperty("usage_text", value);
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
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.WithOutput("arn");
        this.WithOutput("registry_id");
        this.WithOutput("repository_uri");
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for catalog_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogData block(s) allowed")]
    public List<AwsEcrpublicRepositoryCatalogDataBlock>? CatalogData
    {
        get => GetProperty<List<AwsEcrpublicRepositoryCatalogDataBlock>>("catalog_data");
        set => this.WithProperty("catalog_data", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEcrpublicRepositoryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEcrpublicRepositoryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
