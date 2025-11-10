using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_public_key resource.
/// </summary>
public class AwsCloudfrontPublicKey : TerraformResource
{
    public AwsCloudfrontPublicKey(string name) : base("aws_cloudfront_public_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("caller_reference");
        this.DeclareOutput("etag");
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
    /// The encoded_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedKey is required")]
    public required TerraformProperty<string> EncodedKey
    {
        get => GetProperty<TerraformProperty<string>>("encoded_key");
        set => this.WithProperty("encoded_key", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformExpression CallerReference => this["caller_reference"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
