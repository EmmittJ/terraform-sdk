using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_store_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxToolDataStoreSpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for function_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxToolFunctionSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the input of the function.
    /// This input is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    [TerraformProperty("input_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputSchema { get; set; }

    /// <summary>
    /// Optional. The JSON schema is encapsulated in a [google.protobuf.Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct) to describe the output of the function.
    /// This output is a JSON object that contains the function&#39;s parameters as properties of the object
    /// </summary>
    [TerraformProperty("output_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutputSchema { get; set; }

}

/// <summary>
/// Block type for open_api_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxToolOpenApiSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The OpenAPI schema specified as a text.
    /// This field is part of a union field &#39;schema&#39;: only one of &#39;textSchema&#39; may be set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextSchema is required")]
    [TerraformProperty("text_schema")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TextSchema { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxToolTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_tool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxTool : TerraformResource
{
    public GoogleDialogflowCxTool(string name) : base("google_dialogflow_cx_tool", name)
    {
    }

    /// <summary>
    /// High level description of the Tool and its usage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The human-readable name of the tool, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The agent to create a Tool for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Block for data_store_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSpec block(s) allowed")]
    [TerraformProperty("data_store_spec")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxToolDataStoreSpecBlock>>? DataStoreSpec { get; set; }

    /// <summary>
    /// Block for function_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FunctionSpec block(s) allowed")]
    [TerraformProperty("function_spec")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxToolFunctionSpecBlock>>? FunctionSpec { get; set; }

    /// <summary>
    /// Block for open_api_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiSpec block(s) allowed")]
    [TerraformProperty("open_api_spec")]
    public partial TerraformList<TerraformBlock<GoogleDialogflowCxToolOpenApiSpecBlock>>? OpenApiSpec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDialogflowCxToolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the Tool.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/tools/&amp;lt;Tool ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The tool type.
    /// </summary>
    [TerraformProperty("tool_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ToolType { get; }

}
