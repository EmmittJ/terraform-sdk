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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public string? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id")?.Value;
        set => this.WithProperty("parent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The folders attribute.
    /// </summary>
    public TerraformExpression Folders => this["folders"];

}
