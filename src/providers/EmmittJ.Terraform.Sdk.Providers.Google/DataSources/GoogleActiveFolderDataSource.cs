using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_active_folder.
/// </summary>
public class GoogleActiveFolderDataSource : TerraformDataSource
{
    public GoogleActiveFolderDataSource(string name) : base("google_active_folder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("api_method");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("parent");
    }

    /// <summary>
    /// Provides the REST method through which to find the folder. LIST is recommended as it is strongly consistent.
    /// </summary>
    public TerraformProperty<string> ApiMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_method");
        set => SetProperty("api_method", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
