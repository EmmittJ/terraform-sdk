using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folder.
/// </summary>
public class GoogleFolderDataSource : TerraformDataSource
{
    public GoogleFolderDataSource(string name) : base("google_folder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("configured_capabilities");
        SetOutput("create_time");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("folder_id");
        SetOutput("lifecycle_state");
        SetOutput("management_project");
        SetOutput("name");
        SetOutput("organization");
        SetOutput("parent");
        SetOutput("folder");
        SetOutput("id");
        SetOutput("lookup_organization");
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder");
        set => SetProperty("folder", value);
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
    /// The lookup_organization attribute.
    /// </summary>
    public TerraformProperty<bool> LookupOrganization
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("lookup_organization");
        set => SetProperty("lookup_organization", value);
    }

    /// <summary>
    /// The configured_capabilities attribute.
    /// </summary>
    public TerraformExpression ConfiguredCapabilities => this["configured_capabilities"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    public TerraformExpression FolderId => this["folder_id"];

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The management_project attribute.
    /// </summary>
    public TerraformExpression ManagementProject => this["management_project"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public TerraformExpression Organization => this["organization"];

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformExpression Parent => this["parent"];

}
