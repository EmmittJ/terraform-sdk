using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_key.
/// </summary>
public class GoogleTagsTagKeyDataSource : TerraformDataSource
{
    public GoogleTagsTagKeyDataSource(string name) : base("google_tags_tag_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("description");
        this.WithOutput("id");
        this.WithOutput("name");
        this.WithOutput("namespaced_name");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformProperty<string> ShortName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("short_name");
        set => this.WithProperty("short_name", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The namespaced_name attribute.
    /// </summary>
    public TerraformExpression NamespacedName => this["namespaced_name"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
