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
        this.WithOutput("arn");
        this.WithOutput("etag");
        this.WithOutput("live_stage_etag");
        this.WithOutput("status");
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformProperty<string> Code
    {
        get => GetRequiredProperty<TerraformProperty<string>>("code");
        set => this.WithProperty("code", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
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
    /// The key_value_store_associations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? KeyValueStoreAssociations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("key_value_store_associations");
        set => this.WithProperty("key_value_store_associations", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformProperty<bool>? Publish
    {
        get => GetProperty<TerraformProperty<bool>>("publish");
        set => this.WithProperty("publish", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformProperty<string> Runtime
    {
        get => GetRequiredProperty<TerraformProperty<string>>("runtime");
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
