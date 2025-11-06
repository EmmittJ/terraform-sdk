using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_key_value_store resource.
/// </summary>
public class AwsCloudfrontKeyValueStore : TerraformResource
{
    public AwsCloudfrontKeyValueStore(string name) : base("aws_cloudfront_key_value_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
        this.DeclareOutput("id");
        this.DeclareOutput("last_modified_time");
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

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

}
