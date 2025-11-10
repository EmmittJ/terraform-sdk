using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_pull_through_cache_rule.
/// </summary>
public class AwsEcrPullThroughCacheRuleDataSource : TerraformDataSource
{
    public AwsEcrPullThroughCacheRuleDataSource(string name) : base("aws_ecr_pull_through_cache_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("credential_arn");
        SetOutput("custom_role_arn");
        SetOutput("registry_id");
        SetOutput("upstream_registry_url");
        SetOutput("upstream_repository_prefix");
        SetOutput("ecr_repository_prefix");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The ecr_repository_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EcrRepositoryPrefix is required")]
    public required TerraformProperty<string> EcrRepositoryPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ecr_repository_prefix");
        set => SetProperty("ecr_repository_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The credential_arn attribute.
    /// </summary>
    public TerraformExpression CredentialArn => this["credential_arn"];

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformExpression CustomRoleArn => this["custom_role_arn"];

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    public TerraformExpression UpstreamRegistryUrl => this["upstream_registry_url"];

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    public TerraformExpression UpstreamRepositoryPrefix => this["upstream_repository_prefix"];

}
