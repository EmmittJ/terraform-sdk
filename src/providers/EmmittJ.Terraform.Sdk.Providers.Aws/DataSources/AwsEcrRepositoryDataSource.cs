using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_repository.
/// </summary>
public class AwsEcrRepositoryDataSource : TerraformDataSource
{
    public AwsEcrRepositoryDataSource(string name) : base("aws_ecr_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("encryption_configuration");
        SetOutput("image_scanning_configuration");
        SetOutput("image_tag_mutability");
        SetOutput("image_tag_mutability_exclusion_filter");
        SetOutput("most_recent_image_tags");
        SetOutput("repository_url");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("registry_id");
        SetOutput("tags");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The registry_id attribute.
    /// </summary>
    public TerraformProperty<string> RegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("registry_id");
        set => SetProperty("registry_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformExpression EncryptionConfiguration => this["encryption_configuration"];

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    public TerraformExpression ImageScanningConfiguration => this["image_scanning_configuration"];

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformExpression ImageTagMutability => this["image_tag_mutability"];

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    public TerraformExpression ImageTagMutabilityExclusionFilter => this["image_tag_mutability_exclusion_filter"];

    /// <summary>
    /// The most_recent_image_tags attribute.
    /// </summary>
    public TerraformExpression MostRecentImageTags => this["most_recent_image_tags"];

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformExpression RepositoryUrl => this["repository_url"];

}
