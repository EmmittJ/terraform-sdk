using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirestoreDocumentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_firestore_document resource.
/// </summary>
public partial class GoogleFirestoreDocument : TerraformResource
{
    public GoogleFirestoreDocument(string name) : base("google_firestore_document", name)
    {
    }

    /// <summary>
    /// The collection ID, relative to database. For example: chatrooms or chatrooms/my-document/private-messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    [TerraformProperty("collection")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Collection { get; set; }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    [TerraformProperty("database")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Database { get; set; }

    /// <summary>
    /// The client-assigned document ID to use for this document during creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentId is required")]
    [TerraformProperty("document_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DocumentId { get; set; }

    /// <summary>
    /// The document&#39;s [fields](https://cloud.google.com/firestore/docs/reference/rest/v1/projects.databases.documents) formated as a json string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [TerraformProperty("fields")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Fields { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirestoreDocumentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// A server defined name for this document. Format:
    /// &#39;projects/{{project_id}}/databases/{{database_id}}/documents/{{path}}/{{document_id}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// A relative path to the collection this document exists within
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Path { get; }

    /// <summary>
    /// Last update timestamp in RFC3339 format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
