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
    public HashSet<string>? AppliedFor
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("applied_for")?.Value;
        set => this.WithProperty("applied_for", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public string? CustomRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_role_arn")?.Value;
        set => this.WithProperty("custom_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The image_tag_mutability attribute.
    /// </summary>
    public string? ImageTagMutability
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_tag_mutability")?.Value;
        set => this.WithProperty("image_tag_mutability", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public string? LifecyclePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_policy")?.Value;
        set => this.WithProperty("lifecycle_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    public string? RepositoryPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_policy")?.Value;
        set => this.WithProperty("repository_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
