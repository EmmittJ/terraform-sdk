using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_repository_creation_template.
/// </summary>
public class AwsEcrRepositoryCreationTemplateDataSource : TerraformDataSource
{
    public AwsEcrRepositoryCreationTemplateDataSource(string name) : base("aws_ecr_repository_creation_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("applied_for");
        this.DeclareOutput("custom_role_arn");
        this.DeclareOutput("description");
        this.DeclareOutput("encryption_configuration");
        this.DeclareOutput("image_tag_mutability");
        this.DeclareOutput("image_tag_mutability_exclusion_filter");
        this.DeclareOutput("lifecycle_policy");
        this.DeclareOutput("registry_id");
        this.DeclareOutput("repository_policy");
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
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
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
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    public TerraformExpression AppliedFor => this["applied_for"];

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformExpression CustomRoleArn => this["custom_role_arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformExpression EncryptionConfiguration => this["encryption_configuration"];

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformExpression ImageTagMutability => this["image_tag_mutability"];

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    public TerraformExpression ImageTagMutabilityExclusionFilter => this["image_tag_mutability_exclusion_filter"];

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformExpression LifecyclePolicy => this["lifecycle_policy"];

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    public TerraformExpression RepositoryPolicy => this["repository_policy"];

}
