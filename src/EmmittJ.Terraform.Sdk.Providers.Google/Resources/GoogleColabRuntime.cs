using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_colab_runtime resource.
/// </summary>
public class GoogleColabRuntime : TerraformResource
{
    public GoogleColabRuntime(string name) : base("google_colab_runtime", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expiration_time");
        this.DeclareOutput("is_upgradable");
        this.DeclareOutput("notebook_runtime_type");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Triggers an upgrade anytime the runtime is started if it is upgradable.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade");
        set => this.WithProperty("auto_upgrade", value);
    }

    /// <summary>
    /// The description of the Runtime.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Desired state of the Colab Runtime. Set this field to &#39;RUNNING&#39; to start the runtime, and &#39;STOPPED&#39; to stop it.
    /// </summary>
    public TerraformProperty<string>? DesiredState
    {
        get => GetProperty<TerraformProperty<string>>("desired_state");
        set => this.WithProperty("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime.
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The user email of the NotebookRuntime.
    /// </summary>
    public TerraformProperty<string>? RuntimeUser
    {
        get => GetProperty<TerraformProperty<string>>("runtime_user");
        set => this.WithProperty("runtime_user", value);
    }

    /// <summary>
    /// Output only. Timestamp when this NotebookRuntime will be expired.
    /// </summary>
    public TerraformExpression ExpirationTime => this["expiration_time"];

    /// <summary>
    /// Output only. Checks if the NotebookRuntime is upgradable.
    /// </summary>
    public TerraformExpression IsUpgradable => this["is_upgradable"];

    /// <summary>
    /// Output only. The type of the notebook runtime.
    /// </summary>
    public TerraformExpression NotebookRuntimeType => this["notebook_runtime_type"];

    /// <summary>
    /// Output only. The state of the runtime.
    /// </summary>
    public TerraformExpression State => this["state"];

}
