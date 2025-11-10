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
        SetOutput("registry_id");
        SetOutput("credential_arn");
        SetOutput("custom_role_arn");
        SetOutput("ecr_repository_prefix");
        SetOutput("id");
        SetOutput("region");
        SetOutput("upstream_registry_url");
        SetOutput("upstream_repository_prefix");
    }

    /// <summary>
    /// The credential_arn attribute.
    /// </summary>
    public TerraformProperty<string> CredentialArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credential_arn");
        set => SetProperty("credential_arn", value);
    }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> CustomRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_role_arn");
        set => SetProperty("custom_role_arn", value);
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
    /// The upstream_registry_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpstreamRegistryUrl is required")]
    public required TerraformProperty<string> UpstreamRegistryUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upstream_registry_url");
        set => SetProperty("upstream_registry_url", value);
    }

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    public TerraformProperty<string> UpstreamRepositoryPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upstream_repository_prefix");
        set => SetProperty("upstream_repository_prefix", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
