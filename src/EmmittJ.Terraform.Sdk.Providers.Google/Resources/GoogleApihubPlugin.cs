using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apihub_plugin resource.
/// </summary>
public class GoogleApihubPlugin : TerraformResource
{
    public GoogleApihubPlugin(string name) : base("google_apihub_plugin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("ownership_type");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The plugin description. Max length is 2000 characters (Unicode code
    /// points).
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the plugin. Max length is 50 characters (Unicode code
    /// points).
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Possible values:
    /// PLUGIN_CATEGORY_UNSPECIFIED
    /// API_GATEWAY
    /// API_PRODUCER
    /// </summary>
    public string? PluginCategory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plugin_category")?.Value;
        set => this.WithProperty("plugin_category", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the Plugin resource, which will become the final
    /// component of the Plugin&#39;s resource name. This field is optional.
    /// 
    /// * If provided, the same will be used. The service will throw an error if
    /// the specified id is already used by another Plugin resource in the API hub
    /// instance.
    /// * If not provided, a system generated id will be used.
    /// 
    /// This value should be 4-63 characters, overall resource name which will be
    /// of format
    /// &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;,
    /// its length is limited to 1000 characters and valid characters are
    /// /a-z[0-9]-_/.
    /// </summary>
    public string? PluginId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plugin_id")?.Value;
        set => this.WithProperty("plugin_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Timestamp indicating when the plugin was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Identifier. The name of the plugin.
    /// Format: &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type of the plugin, indicating whether it is &#39;SYSTEM_OWNED&#39; or
    /// &#39;USER_OWNED&#39;.
    /// Possible values:
    /// OWNERSHIP_TYPE_UNSPECIFIED
    /// SYSTEM_OWNED
    /// USER_OWNED
    /// </summary>
    public TerraformExpression OwnershipType => this["ownership_type"];

    /// <summary>
    /// Represents the state of the plugin.
    /// Note this field will not be set for plugins developed via plugin
    /// framework as the state will be managed at plugin instance level.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Timestamp indicating when the plugin was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
