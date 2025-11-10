using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folders.
/// </summary>
public class GoogleFoldersDataSource : TerraformDataSource
{
    public GoogleFoldersDataSource(string name) : base("google_folders", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("folders");
        SetOutput("id");
        SetOutput("parent_id");
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
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_id");
        set => SetProperty("parent_id", value);
    }

    /// <summary>
    /// The folders attribute.
    /// </summary>
    public TerraformExpression Folders => this["folders"];

}
