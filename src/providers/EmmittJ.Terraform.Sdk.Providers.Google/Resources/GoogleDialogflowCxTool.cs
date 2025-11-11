using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_store_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolDataStoreSpecBlock
{
}

/// <summary>
/// Block type for function_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolFunctionSpecBlock
{
    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the input of the function.
    /// This input is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    [TerraformPropertyName("input_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputSchema { get; set; }

    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the output of the function.
    /// This output is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    [TerraformPropertyName("output_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutputSchema { get; set; }

}

/// <summary>
/// Block type for open_api_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxToolOpenApiSpecBlock
{
    /// <summary>
    /// The OpenAPI schema specified as a text.
    /// This field is part of a union field &#39;schema&#39;: only one of &#39;textSchema&#39; may be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextSchema is required")]
    [TerraformPropertyName("text_schema")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TextSchema { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxToolTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_tool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxTool : TerraformResource
{
    public GoogleDialogflowCxTool(string name) : base("google_dialogflow_cx_tool", name)
    {
    }

    /// <summary>
    /// High level description of the Tool and its usage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The human-readable name of the tool, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The agent to create a Tool for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Block for data_store_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSpec block(s) allowed")]
    [TerraformPropertyName("data_store_spec")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxToolDataStoreSpecBlock>>? DataStoreSpec { get; set; }

    /// <summary>
    /// Block for function_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FunctionSpec block(s) allowed")]
    [TerraformPropertyName("function_spec")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxToolFunctionSpecBlock>>? FunctionSpec { get; set; }

    /// <summary>
    /// Block for open_api_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiSpec block(s) allowed")]
    [TerraformPropertyName("open_api_spec")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxToolOpenApiSpecBlock>>? OpenApiSpec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxToolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the Tool.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/tools/&amp;lt;Tool ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The tool type.
    /// </summary>
    [TerraformPropertyName("tool_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ToolType => new TerraformReference(this, "tool_type");

}
