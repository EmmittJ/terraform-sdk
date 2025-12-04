using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_folder Terraform data source.
/// Retrieves information about a google_folder.
/// </summary>
public partial class GoogleFolderDataSource(string name) : TerraformDataSource("google_folder", name)
{
    /// <summary>
    /// The folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformValue<string> Folder
    {
        get => GetRequiredArgument<TerraformValue<string>>("folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lookup_organization attribute.
    /// </summary>
    public TerraformValue<bool>? LookupOrganization
    {
        get => GetArgument<TerraformValue<bool>>("lookup_organization");
        set => SetArgument("lookup_organization", value);
    }

    /// <summary>
    /// The configured_capabilities attribute.
    /// </summary>
    public TerraformList<string> ConfiguredCapabilities
        => AsReference("configured_capabilities");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
        => AsReference("deletion_protection");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    public TerraformValue<string> FolderId
        => AsReference("folder_id");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => AsReference("lifecycle_state");

    /// <summary>
    /// The management_project attribute.
    /// </summary>
    public TerraformValue<string> ManagementProject
        => AsReference("management_project");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public TerraformValue<string> Organization
        => AsReference("organization");

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformValue<string> Parent
        => AsReference("parent");

}
