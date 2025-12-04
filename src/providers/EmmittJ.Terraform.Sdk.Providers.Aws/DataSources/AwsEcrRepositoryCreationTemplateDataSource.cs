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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string> ResourceTags
    {
        get => GetArgument<TerraformMap<string>>("resource_tags") ?? AsReference("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    public TerraformSet<string> AppliedFor
        => AsReference("applied_for");

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformValue<string> CustomRoleArn
        => AsReference("custom_role_arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
        => AsReference("encryption_configuration");

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformValue<string> ImageTagMutability
        => AsReference("image_tag_mutability");

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageTagMutabilityExclusionFilter
        => AsReference("image_tag_mutability_exclusion_filter");

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformValue<string> LifecyclePolicy
        => AsReference("lifecycle_policy");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
        => AsReference("registry_id");

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    public TerraformValue<string> RepositoryPolicy
        => AsReference("repository_policy");

}
