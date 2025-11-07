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
    public TerraformLiteralProperty<string>? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_ttl");
        set => this.WithProperty("default_ttl", value);
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
    /// The max_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_ttl");
        set => this.WithProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_ttl");
        set => this.WithProperty("min_ttl", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
