using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for proto_schema in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableSchemaBundleProtoSchemaBlock : ITerraformBlock
{
    /// <summary>
    /// Base64 encoded content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoDescriptors is required")]
    [TerraformPropertyName("proto_descriptors")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProtoDescriptors { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableSchemaBundleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_schema_bundle resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableSchemaBundle : TerraformResource
{
    public GoogleBigtableSchemaBundle(string name) : base("google_bigtable_schema_bundle", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// If true, allow backwards incompatible changes.
    /// </summary>
    [TerraformPropertyName("ignore_warnings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreWarnings { get; set; }

    /// <summary>
    /// The name of the instance to create the schema bundle within.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The unique name of the schema bundle in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaBundleId is required")]
    [TerraformPropertyName("schema_bundle_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SchemaBundleId { get; set; }

    /// <summary>
    /// The name of the table to create the schema bundle within.
    /// </summary>
    [TerraformPropertyName("table")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Table { get; set; }

    /// <summary>
    /// Block for proto_schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProtoSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtoSchema block(s) allowed")]
    [TerraformPropertyName("proto_schema")]
    public TerraformList<TerraformBlock<GoogleBigtableSchemaBundleProtoSchemaBlock>>? ProtoSchema { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigtableSchemaBundleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique name of the requested schema bundle. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;/schemaBundles/&amp;lt;schemaBundleId&amp;gt;&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
