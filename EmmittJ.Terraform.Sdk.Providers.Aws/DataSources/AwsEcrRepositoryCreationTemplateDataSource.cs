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
        this.DeclareOutput("lifecycle_policy");
        this.DeclareOutput("registry_id");
        this.DeclareOutput("repository_policy");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public string? Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix")?.Value;
        set => this.WithProperty("prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, string>? ResourceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("resource_tags")?.Value;
        set => this.WithProperty("resource_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
