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
        this.DeclareOutput("credential_arn");
        this.DeclareOutput("custom_role_arn");
        this.DeclareOutput("registry_id");
        this.DeclareOutput("upstream_registry_url");
        this.DeclareOutput("upstream_repository_prefix");
    }

    /// <summary>
    /// The ecr_repository_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EcrRepositoryPrefix is required")]
    public required TerraformProperty<string> EcrRepositoryPrefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ecr_repository_prefix");
        set => this.WithProperty("ecr_repository_prefix", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
