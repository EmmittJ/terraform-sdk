using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for open_api_toolset in .
/// Nesting mode: list
/// </summary>
public class GoogleCesToolsetOpenApiToolsetBlock : TerraformBlock
{
    /// <summary>
    /// If true, the agent will ignore unknown fields in the API response for all
    /// operations defined in the OpenAPI schema.
    /// </summary>
    public TerraformProperty<bool>? IgnoreUnknownFields
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_unknown_fields");
        set => WithProperty("ignore_unknown_fields", value);
    }

    /// <summary>
    /// The OpenAPI schema of the toolset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenApiSchema is required")]
    public required TerraformProperty<string> OpenApiSchema
    {
        get => GetProperty<TerraformProperty<string>>("open_api_schema");
        set => WithProperty("open_api_schema", value);
    }

    /// <summary>
    /// The server URL of the Open API schema.
    /// This field is only set in toolsets in the environment dependencies
    /// during the export process if the schema contains a server url.
    /// During the import process, if this url is present in the environment dependencies
    /// and the schema has the $env_var placeholder,
    /// it will replace the placeholder in the schema.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCesToolsetTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_ces_toolset resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    public required TerraformProperty<string> App
    {
        get => GetProperty<TerraformProperty<string>>("app");
        set => this.WithProperty("app", value);
    }

    /// <summary>
    /// The description of the toolset.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the toolset. Must be unique within the same app.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Possible values:
    /// SYNCHRONOUS
    /// ASYNCHRONOUS
    /// </summary>
    public TerraformProperty<string>? ExecutionType
    {
        get => GetProperty<TerraformProperty<string>>("execution_type");
        set => this.WithProperty("execution_type", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The ID to use for the toolset, which will become the final component of
    /// the toolset&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the toolset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToolsetId is required")]
    public required TerraformProperty<string> ToolsetId
    {
        get => GetProperty<TerraformProperty<string>>("toolset_id");
        set => this.WithProperty("toolset_id", value);
    }

    /// <summary>
    /// Block for open_api_toolset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiToolset block(s) allowed")]
    public List<GoogleCesToolsetOpenApiToolsetBlock>? OpenApiToolset
    {
        get => GetProperty<List<GoogleCesToolsetOpenApiToolsetBlock>>("open_api_toolset");
        set => this.WithProperty("open_api_toolset", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCesToolsetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCesToolsetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
