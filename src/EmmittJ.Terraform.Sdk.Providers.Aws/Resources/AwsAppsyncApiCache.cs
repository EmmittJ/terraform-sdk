using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_api_cache resource.
/// </summary>
public class AwsAppsyncApiCache : TerraformResource
{
    public AwsAppsyncApiCache(string name) : base("aws_appsync_api_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_caching_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? ApiCachingBehavior
    {
        get => GetProperty<TerraformProperty<string>>("api_caching_behavior");
        set => this.WithProperty("api_caching_behavior", value);
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AtRestEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("at_rest_encryption_enabled");
        set => this.WithProperty("at_rest_encryption_enabled", value);
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
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TransitEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("transit_encryption_enabled");
        set => this.WithProperty("transit_encryption_enabled", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
