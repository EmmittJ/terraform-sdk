using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ecr_repository_creation_template resource.
/// </summary>
public class AwsEcrRepositoryCreationTemplate : TerraformResource
{
    public AwsEcrRepositoryCreationTemplate(string name) : base("aws_ecr_repository_creation_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("registry_id");
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AppliedFor
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("applied_for");
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
    public TerraformProperty<string>? Prefix
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
    public TerraformMapProperty<string>? ResourceTags
    {
        get => GetProperty<TerraformMapProperty<string>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
