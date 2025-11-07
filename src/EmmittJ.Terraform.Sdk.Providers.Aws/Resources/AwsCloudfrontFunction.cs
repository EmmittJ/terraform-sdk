using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_function resource.
/// </summary>
public class AwsCloudfrontFunction : TerraformResource
{
    public AwsCloudfrontFunction(string name) : base("aws_cloudfront_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
        this.DeclareOutput("live_stage_etag");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Code
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code");
        set => this.WithProperty("code", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? KeyValueStoreAssociations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("key_value_store_associations");
        set => this.WithProperty("key_value_store_associations", value);
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
    /// The publish attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Publish
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publish");
        set => this.WithProperty("publish", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The live_stage_etag attribute.
    /// </summary>
    public TerraformExpression LiveStageEtag => this["live_stage_etag"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
