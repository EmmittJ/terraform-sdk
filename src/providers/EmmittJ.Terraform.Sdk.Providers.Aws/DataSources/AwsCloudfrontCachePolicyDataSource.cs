using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_cache_policy.
/// </summary>
public class AwsCloudfrontCachePolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontCachePolicyDataSource(string name) : base("aws_cloudfront_cache_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("comment");
        this.WithOutput("default_ttl");
        this.WithOutput("etag");
        this.WithOutput("max_ttl");
        this.WithOutput("min_ttl");
        this.WithOutput("parameters_in_cache_key_and_forwarded_to_origin");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformExpression Comment => this["comment"];

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformExpression DefaultTtl => this["default_ttl"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformExpression MaxTtl => this["max_ttl"];

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformExpression MinTtl => this["min_ttl"];

    /// <summary>
    /// The parameters_in_cache_key_and_forwarded_to_origin attribute.
    /// </summary>
    public TerraformExpression ParametersInCacheKeyAndForwardedToOrigin => this["parameters_in_cache_key_and_forwarded_to_origin"];

}
