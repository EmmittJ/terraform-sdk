using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_values.
/// </summary>
public class GoogleTagsTagValuesDataSource : TerraformDataSource
{
    public GoogleTagsTagValuesDataSource(string name) : base("google_tags_tag_values", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("values");
        SetOutput("id");
        SetOutput("parent");
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
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformExpression Values => this["values"];

}
