using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrManagementServerNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Network with format &#39;projects/{{project_id}}/global/networks/{{network_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// Type of Network peeringMode Default value: &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot; Possible values: [&amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PeeringMode
    {
        get => GetProperty<TerraformProperty<string>>("peering_mode");
        set => WithProperty("peering_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrManagementServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_backup_dr_management_server resource.
/// </summary>
public class GoogleBackupDrManagementServer : TerraformResource
{
    public GoogleBackupDrManagementServer(string name) : base("google_backup_dr_management_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("management_uri");
        this.WithOutput("oauth2_client_id");
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
    /// The location for the management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of management server (management console)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The type of management server (management console). Default value: &amp;quot;BACKUP_RESTORE&amp;quot; Possible values: [&amp;quot;BACKUP_RESTORE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBackupDrManagementServerNetworksBlock>? Networks
    {
        get => GetProperty<List<GoogleBackupDrManagementServerNetworksBlock>>("networks");
        set => this.WithProperty("networks", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBackupDrManagementServerTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBackupDrManagementServerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The management console URI
    /// </summary>
    public TerraformExpression ManagementUri => this["management_uri"];

    /// <summary>
    /// The oauth2ClientId of management console.
    /// </summary>
    public TerraformExpression Oauth2ClientId => this["oauth2_client_id"];

}
