using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_repository_creation_template Terraform data source.
/// Retrieves information about a aws_ecr_repository_creation_template.
/// </summary>
public partial class AwsEcrRepositoryCreationTemplateDataSource(string name) : TerraformDataSource("aws_ecr_repository_creation_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string> ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    public TerraformSet<string> AppliedFor
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "applied_for").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformValue<string> CustomRoleArn
    {
        get => new TerraformReference<string>(this, "custom_role_arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformValue<string> ImageTagMutability
    {
        get => new TerraformReference<string>(this, "image_tag_mutability");
    }

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageTagMutabilityExclusionFilter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_tag_mutability_exclusion_filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformValue<string> LifecyclePolicy
    {
        get => new TerraformReference<string>(this, "lifecycle_policy");
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
    }

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    public TerraformValue<string> RepositoryPolicy
    {
        get => new TerraformReference<string>(this, "repository_policy");
    }

}
