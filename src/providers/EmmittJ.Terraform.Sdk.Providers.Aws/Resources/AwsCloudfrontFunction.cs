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
        SetOutput("arn");
        SetOutput("etag");
        SetOutput("live_stage_etag");
        SetOutput("status");
        SetOutput("code");
        SetOutput("comment");
        SetOutput("id");
        SetOutput("key_value_store_associations");
        SetOutput("name");
        SetOutput("publish");
        SetOutput("runtime");
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformProperty<string> Code
    {
        get => GetRequiredOutput<TerraformProperty<string>>("code");
        set => SetProperty("code", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
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
    /// The key_value_store_associations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> KeyValueStoreAssociations
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("key_value_store_associations");
        set => SetProperty("key_value_store_associations", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    public TerraformProperty<bool> Publish
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publish");
        set => SetProperty("publish", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformProperty<string> Runtime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime");
        set => SetProperty("runtime", value);
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
