using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for proto_schema in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableSchemaBundleProtoSchemaBlock() : TerraformBlock("proto_schema")
{
    /// <summary>
    /// Base64 encoded content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoDescriptors is required")]
    [TerraformProperty("proto_descriptors")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtoDescriptors { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigtableSchemaBundleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_bigtable_schema_bundle resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigtableSchemaBundle : TerraformResource
{
    public GoogleBigtableSchemaBundle(string name) : base("google_bigtable_schema_bundle", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If true, allow backwards incompatible changes.
    /// </summary>
    [TerraformProperty("ignore_warnings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreWarnings { get; set; }

    /// <summary>
    /// The name of the instance to create the schema bundle within.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The unique name of the schema bundle in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaBundleId is required")]
    [TerraformProperty("schema_bundle_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SchemaBundleId { get; set; }

    /// <summary>
    /// The name of the table to create the schema bundle within.
    /// </summary>
    [TerraformProperty("table")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Table { get; set; }

    /// <summary>
    /// Block for proto_schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProtoSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtoSchema block(s) allowed")]
    [TerraformProperty("proto_schema")]
    public required TerraformList<GoogleBigtableSchemaBundleProtoSchemaBlock> ProtoSchema { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigtableSchemaBundleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique name of the requested schema bundle. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;/schemaBundles/&amp;lt;schemaBundleId&amp;gt;&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
