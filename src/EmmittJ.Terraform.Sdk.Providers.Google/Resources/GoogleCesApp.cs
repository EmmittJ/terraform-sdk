using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_ces_app resource.
/// </summary>
public class GoogleCesApp : TerraformResource
{
    public GoogleCesApp(string name) : base("google_ces_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("deployment_count");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID to use for the app, which will become the final component of
    /// the app&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the app.
    /// </summary>
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// Human-readable description of the app.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Display name of the app.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Instructions for all the agents in the app.
    /// You can use this instruction to set up a stable identity or personality
    /// across all the agents.
    /// </summary>
    public TerraformProperty<string>? GlobalInstruction
    {
        get => GetProperty<TerraformProperty<string>>("global_instruction");
        set => this.WithProperty("global_instruction", value);
    }

    /// <summary>
    /// List of guardrails for the app.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}&#39;
    /// </summary>
    public TerraformProperty<List<string>>? Guardrails
    {
        get => GetProperty<TerraformProperty<List<string>>>("guardrails");
        set => this.WithProperty("guardrails", value);
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
    /// Metadata about the app. This field can be used to store additional
    /// information relevant to the app&#39;s details or intended usages.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The root agent is the entry point of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}/agents/{agent}&#39;
    /// </summary>
    public TerraformProperty<string>? RootAgent
    {
        get => GetProperty<TerraformProperty<string>>("root_agent");
        set => this.WithProperty("root_agent", value);
    }

    /// <summary>
    /// Timestamp when the app was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Number of deployments in the app.
    /// </summary>
    public TerraformExpression DeploymentCount => this["deployment_count"];

    /// <summary>
    /// Etag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. The unique identifier of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Timestamp when the app was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
