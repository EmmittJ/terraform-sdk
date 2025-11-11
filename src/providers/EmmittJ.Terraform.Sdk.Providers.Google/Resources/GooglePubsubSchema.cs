using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePubsubSchemaTimeoutsBlock
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
/// Manages a google_pubsub_schema resource.
/// </summary>
public class GooglePubsubSchema : TerraformResource
{
    public GooglePubsubSchema(string name) : base("google_pubsub_schema", name)
    {
    }

    /// <summary>
    /// The definition of the schema.
    /// This should contain a string representing the full definition of the schema
    /// that is a valid schema definition of the type specified in type. Changes
    /// to the definition commit new [schema revisions](https://cloud.google.com/pubsub/docs/commit-schema-revision).
    /// A schema can only have up to 20 revisions, so updates that fail with an
    /// error indicating that the limit has been reached require manually
    /// [deleting old revisions](https://cloud.google.com/pubsub/docs/delete-schema-revision).
    /// </summary>
    [TerraformPropertyName("definition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Definition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID to use for the schema, which will become the final component of the schema&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The type of the schema definition Default value: &amp;quot;TYPE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROTOCOL_BUFFER&amp;quot;, &amp;quot;AVRO&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GooglePubsubSchemaTimeoutsBlock>? Timeouts { get; set; }

}
