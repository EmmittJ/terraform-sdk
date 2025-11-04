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
    public string? EcrRepositoryPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ecr_repository_prefix")?.Value;
        set => this.WithProperty("ecr_repository_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
