using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePubsubSchemaTimeoutsBlock : TerraformBlock
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
/// Manages a google_pubsub_schema resource.
/// </summary>
public class GooglePubsubSchema : TerraformResource
{
    public GooglePubsubSchema(string name) : base("google_pubsub_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
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
    public TerraformProperty<string>? Definition
    {
        get => GetProperty<TerraformProperty<string>>("definition");
        set => this.WithProperty("definition", value);
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
    /// The ID to use for the schema, which will become the final component of the schema&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The type of the schema definition Default value: &amp;quot;TYPE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROTOCOL_BUFFER&amp;quot;, &amp;quot;AVRO&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePubsubSchemaTimeoutsBlock? Timeouts
    {
        get => GetProperty<GooglePubsubSchemaTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
