using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_cache_policy resource.
/// </summary>
public class AwsCloudfrontCachePolicy : TerraformResource
{
    public AwsCloudfrontCachePolicy(string name) : base("aws_cloudfront_cache_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public string? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment")?.Value;
        set => this.WithProperty("comment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public double? DefaultTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_ttl")?.Value;
        set => this.WithProperty("default_ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The max_ttl attribute.
    /// </summary>
    public double? MaxTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_ttl")?.Value;
        set => this.WithProperty("max_ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public double? MinTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_ttl")?.Value;
        set => this.WithProperty("min_ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
