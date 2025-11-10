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
        set => SetProperty("input_schema", value);
    }

    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the output of the function.
    /// This output is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    public TerraformProperty<string>? OutputSchema
    {
        set => SetProperty("output_schema", value);
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
        set => SetProperty("text_schema", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("name");
        SetOutput("tool_type");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("parent");
    }

    /// <summary>
    /// High level description of the Tool and its usage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The human-readable name of the tool, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The agent to create a Tool for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for data_store_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSpec block(s) allowed")]
    public List<GoogleDialogflowCxToolDataStoreSpecBlock>? DataStoreSpec
    {
        set => SetProperty("data_store_spec", value);
    }

    /// <summary>
    /// Block for function_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FunctionSpec block(s) allowed")]
    public List<GoogleDialogflowCxToolFunctionSpecBlock>? FunctionSpec
    {
        set => SetProperty("function_spec", value);
    }

    /// <summary>
    /// Block for open_api_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiSpec block(s) allowed")]
    public List<GoogleDialogflowCxToolOpenApiSpecBlock>? OpenApiSpec
    {
        set => SetProperty("open_api_spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxToolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
