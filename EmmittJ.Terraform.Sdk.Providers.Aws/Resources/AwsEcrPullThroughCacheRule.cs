using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ecr_pull_through_cache_rule resource.
/// </summary>
public class AwsEcrPullThroughCacheRule : TerraformResource
{
    public AwsEcrPullThroughCacheRule(string name) : base("aws_ecr_pull_through_cache_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("registry_id");
    }

    /// <summary>
    /// The credential_arn attribute.
    /// </summary>
    public string? CredentialArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credential_arn")?.Value;
        set => this.WithProperty("credential_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The upstream_registry_url attribute.
    /// </summary>
    public string? UpstreamRegistryUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upstream_registry_url")?.Value;
        set => this.WithProperty("upstream_registry_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    public string? UpstreamRepositoryPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upstream_repository_prefix")?.Value;
        set => this.WithProperty("upstream_repository_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
