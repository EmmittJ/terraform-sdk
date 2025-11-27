using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsEcrRepositoryCreationTemplate.
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string> KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for image_tag_mutability_exclusion_filter in AwsEcrRepositoryCreationTemplate.
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_tag_mutability_exclusion_filter";

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformValue<string> FilterType
    {
        get => new TerraformReference<string>(this, "filter_type");
        set => SetArgument("filter_type", value);
    }

}


/// <summary>
/// Represents a aws_ecr_repository_creation_template Terraform resource.
/// Manages a aws_ecr_repository_creation_template resource.
/// </summary>
public partial class AwsEcrRepositoryCreationTemplate(string name) : TerraformResource("aws_ecr_repository_creation_template", name)
{
    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliedFor is required")]
    public required TerraformSet<string> AppliedFor
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "applied_for").ResolveNodes(ctx));
        set => SetArgument("applied_for", value);
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? CustomRoleArn
    {
        get => new TerraformReference<string>(this, "custom_role_arn");
        set => SetArgument("custom_role_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformValue<string>? ImageTagMutability
    {
        get => new TerraformReference<string>(this, "image_tag_mutability");
        set => SetArgument("image_tag_mutability", value);
    }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformValue<string>? LifecyclePolicy
    {
        get => new TerraformReference<string>(this, "lifecycle_policy");
        set => SetArgument("lifecycle_policy", value);
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
    /// The repository_policy attribute.
    /// </summary>
    public TerraformValue<string>? RepositoryPolicy
    {
        get => new TerraformReference<string>(this, "repository_policy");
        set => SetArgument("repository_policy", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string>? ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// ImageTagMutabilityExclusionFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    public TerraformList<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>? ImageTagMutabilityExclusionFilter
    {
        get => GetArgument<TerraformList<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>>("image_tag_mutability_exclusion_filter");
        set => SetArgument("image_tag_mutability_exclusion_filter", value);
    }

}
