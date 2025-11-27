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
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lookup_organization attribute.
    /// </summary>
    public TerraformValue<bool>? LookupOrganization
    {
        get => new TerraformReference<bool>(this, "lookup_organization");
        set => SetArgument("lookup_organization", value);
    }

    /// <summary>
    /// The configured_capabilities attribute.
    /// </summary>
    public TerraformList<string> ConfiguredCapabilities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "configured_capabilities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    public TerraformValue<string> FolderId
    {
        get => new TerraformReference<string>(this, "folder_id");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The management_project attribute.
    /// </summary>
    public TerraformValue<string> ManagementProject
    {
        get => new TerraformReference<string>(this, "management_project");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public TerraformValue<string> Organization
    {
        get => new TerraformReference<string>(this, "organization");
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
    }

}
