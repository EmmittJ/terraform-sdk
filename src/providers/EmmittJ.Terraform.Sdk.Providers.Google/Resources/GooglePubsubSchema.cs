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
        SetOutput("definition");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("type");
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
    public TerraformProperty<string> Definition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("definition");
        set => SetProperty("definition", value);
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
    /// The ID to use for the schema, which will become the final component of the schema&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The type of the schema definition Default value: &amp;quot;TYPE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROTOCOL_BUFFER&amp;quot;, &amp;quot;AVRO&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePubsubSchemaTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
