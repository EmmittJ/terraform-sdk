using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirestoreDocument.
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreDocumentTimeoutsBlock : TerraformBlock
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
/// Represents a google_firestore_document Terraform resource.
/// Manages a google_firestore_document resource.
/// </summary>
public partial class GoogleFirestoreDocument(string name) : TerraformResource("google_firestore_document", name)
{
    /// <summary>
    /// The collection ID, relative to database. For example: chatrooms or chatrooms/my-document/private-messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformValue<string> Collection
    {
        get => GetRequiredArgument<TerraformValue<string>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The client-assigned document ID to use for this document during creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentId is required")]
    public required TerraformValue<string> DocumentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("document_id");
        set => SetArgument("document_id", value);
    }

    /// <summary>
    /// The document&#39;s [fields](https://cloud.google.com/firestore/docs/reference/rest/v1/projects.databases.documents) formated as a json string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    public required TerraformValue<string> Fields
    {
        get => GetRequiredArgument<TerraformValue<string>>("fields");
        set => SetArgument("fields", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 format.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// A server defined name for this document. Format:
    /// &#39;projects/{{project_id}}/databases/{{database_id}}/documents/{{path}}/{{document_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// A relative path to the collection this document exists within
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// Last update timestamp in RFC3339 format.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirestoreDocumentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirestoreDocumentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
