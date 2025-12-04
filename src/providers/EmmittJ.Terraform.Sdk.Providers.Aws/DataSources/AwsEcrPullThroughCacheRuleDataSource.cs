using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_pull_through_cache_rule Terraform data source.
/// Retrieves information about a aws_ecr_pull_through_cache_rule.
/// </summary>
public partial class AwsEcrPullThroughCacheRuleDataSource(string name) : TerraformDataSource("aws_ecr_pull_through_cache_rule", name)
{
    /// <summary>
    /// The ecr_repository_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EcrRepositoryPrefix is required")]
    public required TerraformValue<string> EcrRepositoryPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("ecr_repository_prefix");
        set => SetArgument("ecr_repository_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The credential_arn attribute.
    /// </summary>
    public TerraformValue<string> CredentialArn
        => AsReference("credential_arn");

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformValue<string> CustomRoleArn
        => AsReference("custom_role_arn");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
        => AsReference("registry_id");

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    public TerraformValue<string> UpstreamRegistryUrl
        => AsReference("upstream_registry_url");

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    public TerraformValue<string> UpstreamRepositoryPrefix
        => AsReference("upstream_repository_prefix");

}
