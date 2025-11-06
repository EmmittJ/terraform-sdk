using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_ces_toolset resource.
/// </summary>
public class GoogleCesToolset : TerraformResource
{
    public GoogleCesToolset(string name) : base("google_ces_toolset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public string? App
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app")?.Value;
        set => this.WithProperty("app", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the toolset.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the toolset. Must be unique within the same app.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Possible values:
    /// SYNCHRONOUS
    /// ASYNCHRONOUS
    /// </summary>
    public string? ExecutionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_type")?.Value;
        set => this.WithProperty("execution_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the toolset, which will become the final component of
    /// the toolset&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the toolset.
    /// </summary>
    public string? ToolsetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("toolset_id")?.Value;
        set => this.WithProperty("toolset_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Timestamp when the toolset was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// ETag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. The unique identifier of the toolset.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Timestamp when the toolset was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
