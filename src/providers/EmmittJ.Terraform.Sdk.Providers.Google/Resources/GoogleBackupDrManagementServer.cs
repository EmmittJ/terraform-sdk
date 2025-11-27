using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for networks in GoogleBackupDrManagementServer.
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrManagementServerNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networks";

    /// <summary>
    /// Network with format &#39;projects/{{project_id}}/global/networks/{{network_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Type of Network peeringMode Default value: &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot; Possible values: [&amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PeeringMode
    {
        get => new TerraformReference<string>(this, "peering_mode");
        set => SetArgument("peering_mode", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBackupDrManagementServer.
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrManagementServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_backup_dr_management_server Terraform resource.
/// Manages a google_backup_dr_management_server resource.
/// </summary>
public partial class GoogleBackupDrManagementServer(string name) : TerraformResource("google_backup_dr_management_server", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The management console URI
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementUri
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "management_uri").ResolveNodes(ctx));
    }

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    public TerraformValue<string> Oauth2ClientId
    {
        get => new TerraformReference<string>(this, "oauth2_client_id");
    }

    /// <summary>
    /// Networks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBackupDrManagementServerNetworksBlock>? Networks
    {
        get => GetArgument<TerraformList<GoogleBackupDrManagementServerNetworksBlock>>("networks");
        set => SetArgument("networks", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBackupDrManagementServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBackupDrManagementServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
