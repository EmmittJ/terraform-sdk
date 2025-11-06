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
    public string? ApiCachingBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_caching_behavior")?.Value;
        set => this.WithProperty("api_caching_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public bool? AtRestEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("at_rest_encryption_enabled")?.Value;
        set => this.WithProperty("at_rest_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public bool? TransitEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transit_encryption_enabled")?.Value;
        set => this.WithProperty("transit_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public double? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ttl")?.Value;
        set => this.WithProperty("ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
