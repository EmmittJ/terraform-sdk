using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_store_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolDataStoreSpecBlock : TerraformBlock
{
}

/// <summary>
/// Block type for function_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolFunctionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the input of the function.
    /// This input is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    public TerraformProperty<string>? InputSchema
    {
        get => GetProperty<TerraformProperty<string>>("input_schema");
        set => WithProperty("input_schema", value);
    }

    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the output of the function.
    /// This output is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    public TerraformProperty<string>? OutputSchema
    {
        get => GetProperty<TerraformProperty<string>>("output_schema");
        set => WithProperty("output_schema", value);
    }

}

/// <summary>
/// Block type for open_api_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlock : TerraformBlock
{
    /// <summary>
    /// The OpenAPI schema specified as a text.
    /// This field is part of a union field &#39;schema&#39;: only one of &#39;textSchema&#39; may be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextSchema is required")]
    public required TerraformProperty<string> TextSchema
    {
        get => GetProperty<TerraformProperty<string>>("text_schema");
        set => WithProperty("text_schema", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxToolTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_tool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxTool : TerraformResource
{
    public GoogleDialogflowCxTool(string name) : base("google_dialogflow_cx_tool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("tool_type");
    }

    /// <summary>
    /// High level description of the Tool and its usage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The human-readable name of the tool, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    /// The agent to create a Tool for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for data_store_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSpec block(s) allowed")]
    public List<GoogleDialogflowCxToolDataStoreSpecBlock>? DataStoreSpec
    {
        get => GetProperty<List<GoogleDialogflowCxToolDataStoreSpecBlock>>("data_store_spec");
        set => this.WithProperty("data_store_spec", value);
    }

    /// <summary>
    /// Block for function_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FunctionSpec block(s) allowed")]
    public List<GoogleDialogflowCxToolFunctionSpecBlock>? FunctionSpec
    {
        get => GetProperty<List<GoogleDialogflowCxToolFunctionSpecBlock>>("function_spec");
        set => this.WithProperty("function_spec", value);
    }

    /// <summary>
    /// Block for open_api_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiSpec block(s) allowed")]
    public List<GoogleDialogflowCxToolOpenApiSpecBlock>? OpenApiSpec
    {
        get => GetProperty<List<GoogleDialogflowCxToolOpenApiSpecBlock>>("open_api_spec");
        set => this.WithProperty("open_api_spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxToolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxToolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the Tool.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/tools/&amp;lt;Tool ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The tool type.
    /// </summary>
    public TerraformExpression ToolType => this["tool_type"];

}
