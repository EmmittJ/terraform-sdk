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
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Human-readable description of the app.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Display name of the app.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Instructions for all the agents in the app.
    /// You can use this instruction to set up a stable identity or personality
    /// across all the agents.
    /// </summary>
    public string? GlobalInstruction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_instruction")?.Value;
        set => this.WithProperty("global_instruction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of guardrails for the app.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}&#39;
    /// </summary>
    public List<string>? Guardrails
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("guardrails")?.Value;
        set => this.WithProperty("guardrails", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// Metadata about the app. This field can be used to store additional
    /// information relevant to the app&#39;s details or intended usages.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The root agent is the entry point of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}/agents/{agent}&#39;
    /// </summary>
    public string? RootAgent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_agent")?.Value;
        set => this.WithProperty("root_agent", value == null ? null : new TerraformLiteralProperty<string>(value));
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
