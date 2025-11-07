using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firestore_field resource.
/// </summary>
public class GoogleFirestoreField : TerraformResource
{
    public GoogleFirestoreField(string name) : base("google_firestore_field", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The id of the collection group to configure.
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
    /// The id of the field to configure.
    /// </summary>
    public TerraformProperty<string>? Field
    {
        get => GetProperty<TerraformProperty<string>>("field");
        set => this.WithProperty("field", value);
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
    /// The name of this field. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/fields/{{field}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
