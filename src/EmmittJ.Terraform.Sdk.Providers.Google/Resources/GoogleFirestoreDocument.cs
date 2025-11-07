using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firestore_document resource.
/// </summary>
public class GoogleFirestoreDocument : TerraformResource
{
    public GoogleFirestoreDocument(string name) : base("google_firestore_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("path");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The collection ID, relative to database. For example: chatrooms or chatrooms/my-document/private-messages.
    /// </summary>
    public TerraformProperty<string>? Collection
    {
        get => GetProperty<TerraformProperty<string>>("collection");
        set => this.WithProperty("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The client-assigned document ID to use for this document during creation.
    /// </summary>
    public TerraformProperty<string>? DocumentId
    {
        get => GetProperty<TerraformProperty<string>>("document_id");
        set => this.WithProperty("document_id", value);
    }

    /// <summary>
    /// The document&#39;s [fields](https://cloud.google.com/firestore/docs/reference/rest/v1/projects.databases.documents) formated as a json string.
    /// </summary>
    public TerraformProperty<string>? Fields
    {
        get => GetProperty<TerraformProperty<string>>("fields");
        set => this.WithProperty("fields", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// A server defined name for this document. Format:
    /// &#39;projects/{{project_id}}/databases/{{database_id}}/documents/{{path}}/{{document_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// A relative path to the collection this document exists within
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// Last update timestamp in RFC3339 format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
