using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GooglePubsubSchema.
/// Nesting mode: single
/// </summary>
public class GooglePubsubSchemaTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_pubsub_schema Terraform resource.
/// Manages a google_pubsub_schema resource.
/// </summary>
public partial class GooglePubsubSchema(string name) : TerraformResource("google_pubsub_schema", name)
{
    /// <summary>
    /// The definition of the schema.
    /// This should contain a string representing the full definition of the schema
    /// that is a valid schema definition of the type specified in type. Changes
    /// to the definition commit new [schema revisions](https://cloud.google.com/pubsub/docs/commit-schema-revision).
    /// A schema can only have up to 20 revisions, so updates that fail with an
    /// error indicating that the limit has been reached require manually
    /// [deleting old revisions](https://cloud.google.com/pubsub/docs/delete-schema-revision).
    /// </summary>
    public TerraformValue<string>? Definition
    {
        get => GetArgument<TerraformValue<string>>("definition");
        set => SetArgument("definition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID to use for the schema, which will become the final component of the schema&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The type of the schema definition Default value: &amp;quot;TYPE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROTOCOL_BUFFER&amp;quot;, &amp;quot;AVRO&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePubsubSchemaTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePubsubSchemaTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
