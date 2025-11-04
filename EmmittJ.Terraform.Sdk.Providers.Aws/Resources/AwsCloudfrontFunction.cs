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
    public string? Code
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code")?.Value;
        set => this.WithProperty("code", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    public HashSet<string>? KeyValueStoreAssociations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("key_value_store_associations")?.Value;
        set => this.WithProperty("key_value_store_associations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The publish attribute.
    /// </summary>
    public bool? Publish
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publish")?.Value;
        set => this.WithProperty("publish", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public string? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime")?.Value;
        set => this.WithProperty("runtime", value == null ? null : new TerraformLiteralProperty<string>(value));
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
