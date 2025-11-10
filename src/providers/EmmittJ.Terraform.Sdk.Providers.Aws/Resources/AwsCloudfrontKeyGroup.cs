using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_key_group resource.
/// </summary>
public class AwsCloudfrontKeyGroup : TerraformResource
{
    public AwsCloudfrontKeyGroup(string name) : base("aws_cloudfront_key_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("comment");
        SetOutput("id");
        SetOutput("items");
        SetOutput("name");
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
    /// The items attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Items is required")]
    public HashSet<TerraformProperty<string>> Items
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("items");
        set => SetProperty("items", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
