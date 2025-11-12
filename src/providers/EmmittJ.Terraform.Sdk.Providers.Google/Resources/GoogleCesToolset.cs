using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for open_api_toolset in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesToolsetOpenApiToolsetBlock() : TerraformBlock("open_api_toolset")
{
    /// <summary>
    /// If true, the agent will ignore unknown fields in the API response for all
    /// operations defined in the OpenAPI schema.
    /// </summary>
    [TerraformProperty("ignore_unknown_fields")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreUnknownFields { get; set; }

    /// <summary>
    /// The OpenAPI schema of the toolset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenApiSchema is required")]
    [TerraformProperty("open_api_schema")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OpenApiSchema { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCesToolsetTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_ces_toolset resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCesToolset : TerraformResource
{
    public GoogleCesToolset(string name) : base("google_ces_toolset", name)
    {
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    [TerraformProperty("app")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> App { get; set; }

    /// <summary>
    /// The description of the toolset.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the toolset. Must be unique within the same app.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Possible values:
    /// SYNCHRONOUS
    /// ASYNCHRONOUS
    /// </summary>
    [TerraformProperty("execution_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The ID to use for the toolset, which will become the final component of
    /// the toolset&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the toolset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToolsetId is required")]
    [TerraformProperty("toolset_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ToolsetId { get; set; }

    /// <summary>
    /// Block for open_api_toolset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApiToolset block(s) allowed")]
    [TerraformProperty("open_api_toolset")]
    public TerraformList<GoogleCesToolsetOpenApiToolsetBlock> OpenApiToolset { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleCesToolsetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Timestamp when the toolset was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// ETag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Identifier. The unique identifier of the toolset.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Timestamp when the toolset was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
