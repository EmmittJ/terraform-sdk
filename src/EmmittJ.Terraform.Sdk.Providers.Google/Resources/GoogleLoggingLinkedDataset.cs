using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_linked_dataset resource.
/// </summary>
public class GoogleLoggingLinkedDataset : TerraformResource
{
    public GoogleLoggingLinkedDataset(string name) : base("google_logging_linked_dataset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The bucket to which the linked dataset is attached.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Describes this link. The maximum length of the description is 8000 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The id of the linked dataset.
    /// </summary>
    public TerraformProperty<string>? LinkId
    {
        get => GetProperty<TerraformProperty<string>>("link_id");
        set => this.WithProperty("link_id", value);
    }

    /// <summary>
    /// The location of the linked dataset.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The parent of the linked dataset.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of the link. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;
    /// and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. The linked dataset lifecycle state.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The resource name of the linked dataset. The name can have up to 100 characters. A valid link id
    /// (at the end of the link name) must only have alphanumeric characters and underscores within it.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
