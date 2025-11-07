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
    public TerraformLiteralProperty<string>? CredentialArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credential_arn");
        set => this.WithProperty("credential_arn", value);
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_role_arn");
        set => this.WithProperty("custom_role_arn", value);
    }

    /// <summary>
    /// The ecr_repository_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EcrRepositoryPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ecr_repository_prefix");
        set => this.WithProperty("ecr_repository_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UpstreamRegistryUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upstream_registry_url");
        set => this.WithProperty("upstream_registry_url", value);
    }

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UpstreamRepositoryPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upstream_repository_prefix");
        set => this.WithProperty("upstream_repository_prefix", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
