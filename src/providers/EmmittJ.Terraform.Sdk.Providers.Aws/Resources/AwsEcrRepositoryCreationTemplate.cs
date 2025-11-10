using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        set => SetProperty("encryption_type", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        set => SetProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for image_tag_mutability_exclusion_filter in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock : TerraformBlock
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformProperty<string> FilterType
    {
        set => SetProperty("filter_type", value);
    }

}

/// <summary>
/// Manages a aws_ecr_repository_creation_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcrRepositoryCreationTemplate : TerraformResource
{
    public AwsEcrRepositoryCreationTemplate(string name) : base("aws_ecr_repository_creation_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("registry_id");
        SetOutput("applied_for");
        SetOutput("custom_role_arn");
        SetOutput("description");
        SetOutput("id");
        SetOutput("image_tag_mutability");
        SetOutput("lifecycle_policy");
        SetOutput("prefix");
        SetOutput("region");
        SetOutput("repository_policy");
        SetOutput("resource_tags");
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliedFor is required")]
    public HashSet<TerraformProperty<string>> AppliedFor
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("applied_for");
        set => SetProperty("applied_for", value);
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> CustomRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_role_arn");
        set => SetProperty("custom_role_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformProperty<string> ImageTagMutability
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_tag_mutability");
        set => SetProperty("image_tag_mutability", value);
    }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformProperty<string> LifecyclePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifecycle_policy");
        set => SetProperty("lifecycle_policy", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prefix");
        set => SetProperty("prefix", value);
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
    /// The repository_policy attribute.
    /// </summary>
    public TerraformProperty<string> RepositoryPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_policy");
        set => SetProperty("repository_policy", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResourceTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => SetProperty("resource_tags", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        set => SetProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for image_tag_mutability_exclusion_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    public List<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>? ImageTagMutabilityExclusionFilter
    {
        set => SetProperty("image_tag_mutability_exclusion_filter", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
