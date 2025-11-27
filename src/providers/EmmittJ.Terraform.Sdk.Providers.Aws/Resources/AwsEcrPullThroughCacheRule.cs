using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_pull_through_cache_rule Terraform resource.
/// Manages a aws_ecr_pull_through_cache_rule resource.
/// </summary>
public partial class AwsEcrPullThroughCacheRule(string name) : TerraformResource("aws_ecr_pull_through_cache_rule", name)
{
    /// <summary>
    /// The credential_arn attribute.
    /// </summary>
    public TerraformValue<string>? CredentialArn
    {
        get => new TerraformReference<string>(this, "credential_arn");
        set => SetArgument("credential_arn", value);
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
    /// The ecr_repository_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EcrRepositoryPrefix is required")]
    public required TerraformValue<string> EcrRepositoryPrefix
    {
        get => new TerraformReference<string>(this, "ecr_repository_prefix");
        set => SetArgument("ecr_repository_prefix", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpstreamRegistryUrl is required")]
    public required TerraformValue<string> UpstreamRegistryUrl
    {
        get => new TerraformReference<string>(this, "upstream_registry_url");
        set => SetArgument("upstream_registry_url", value);
    }

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    public TerraformValue<string>? UpstreamRepositoryPrefix
    {
        get => new TerraformReference<string>(this, "upstream_repository_prefix");
        set => SetArgument("upstream_repository_prefix", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
    }

}
