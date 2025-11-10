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
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => WithProperty("encryption_type", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => WithProperty("kms_key", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformProperty<string> FilterType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filter_type");
        set => WithProperty("filter_type", value);
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
        this.WithOutput("registry_id");
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliedFor is required")]
    public HashSet<TerraformProperty<string>>? AppliedFor
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("applied_for");
        set => this.WithProperty("applied_for", value);
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("custom_role_arn");
        set => this.WithProperty("custom_role_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformProperty<string>? ImageTagMutability
    {
        get => GetProperty<TerraformProperty<string>>("image_tag_mutability");
        set => this.WithProperty("image_tag_mutability", value);
    }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformProperty<string>? LifecyclePolicy
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle_policy");
        set => this.WithProperty("lifecycle_policy", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
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
    /// The repository_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RepositoryPolicy
    {
        get => GetProperty<TerraformProperty<string>>("repository_policy");
        set => this.WithProperty("repository_policy", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for image_tag_mutability_exclusion_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    public List<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>? ImageTagMutabilityExclusionFilter
    {
        get => GetProperty<List<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>>("image_tag_mutability_exclusion_filter");
        set => this.WithProperty("image_tag_mutability_exclusion_filter", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
