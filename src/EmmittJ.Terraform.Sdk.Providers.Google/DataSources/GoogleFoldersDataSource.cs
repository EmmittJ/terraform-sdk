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
        this.DeclareOutput("folders");
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
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetProperty<TerraformProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The folders attribute.
    /// </summary>
    public TerraformExpression Folders => this["folders"];

}
