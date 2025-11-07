using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apihub_plugin_instance resource.
/// </summary>
public class GoogleApihubPluginInstance : TerraformResource
{
    public GoogleApihubPluginInstance(string name) : base("google_apihub_plugin_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("error_message");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    public TerraformProperty<bool>? Disable
    {
        get => GetProperty<TerraformProperty<bool>>("disable");
        set => this.WithProperty("disable", value);
    }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformProperty<string>? Plugin
    {
        get => GetProperty<TerraformProperty<string>>("plugin");
        set => this.WithProperty("plugin", value);
    }

    /// <summary>
    /// The ID to use for the plugin instance, which will become the final
    /// component of the plugin instance&#39;s resource name. This field is optional.
    /// 
    /// * If provided, the same will be used. The service will throw an error if
    /// the specified id is already used by another plugin instance in the plugin
    /// resource.
    /// * If not provided, a system generated id will be used.
    /// 
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z[0-9]-_/.
    /// </summary>
    public TerraformProperty<string>? PluginInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("plugin_instance_id");
        set => this.WithProperty("plugin_instance_id", value);
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
    /// Timestamp indicating when the plugin instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Error message describing the failure, if any, during Create, Delete or
    /// ApplyConfig operation corresponding to the plugin instance.This field will
    /// only be populated if the plugin instance is in the ERROR or FAILED state.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// Identifier. The unique name of the plugin instance resource.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the plugin instance (e.g., enabled, disabled,
    /// provisioning).
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// ACTIVE
    /// APPLYING_CONFIG
    /// ERROR
    /// FAILED
    /// DELETING
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Timestamp indicating when the plugin instance was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
