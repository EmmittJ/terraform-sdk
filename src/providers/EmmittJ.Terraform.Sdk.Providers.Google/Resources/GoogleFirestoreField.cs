using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for index_config in GoogleFirestoreField.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreFieldIndexConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index_config";

    /// <summary>
    /// Indexes block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleFirestoreFieldIndexConfigBlockIndexesBlock>? Indexes
    {
        get => GetArgument<TerraformSet<GoogleFirestoreFieldIndexConfigBlockIndexesBlock>>("indexes");
        set => SetArgument("indexes", value);
    }

}

/// <summary>
/// Block type for indexes in GoogleFirestoreFieldIndexConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleFirestoreFieldIndexConfigBlockIndexesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "indexes";

    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of &#39;order&#39; and &#39;arrayConfig&#39; can
    /// be specified. Possible values: [&amp;quot;CONTAINS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ArrayConfig
    {
        get => new TerraformReference<string>(this, "array_config");
        set => SetArgument("array_config", value);
    }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &amp;lt;, &amp;lt;=, &amp;gt;, &amp;gt;=, !=.
    /// Only one of &#39;order&#39; and &#39;arrayConfig&#39; can be specified. Possible values: [&amp;quot;ASCENDING&amp;quot;, &amp;quot;DESCENDING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Order
    {
        get => new TerraformReference<string>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The scope at which a query is run. Collection scoped queries require you specify
    /// the collection at query time. Collection group scope allows queries across all
    /// collections with the same id. Default value: &amp;quot;COLLECTION&amp;quot; Possible values: [&amp;quot;COLLECTION&amp;quot;, &amp;quot;COLLECTION_GROUP&amp;quot;]
    /// </summary>
    public TerraformValue<string>? QueryScope
    {
        get => new TerraformReference<string>(this, "query_scope");
        set => SetArgument("query_scope", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFirestoreField.
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreFieldTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for ttl_config in GoogleFirestoreField.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreFieldTtlConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttl_config";

    /// <summary>
    /// The state of TTL (time-to-live) configuration for documents that have this Field set.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}


/// <summary>
/// Represents a google_firestore_field Terraform resource.
/// Manages a google_firestore_field resource.
/// </summary>
public partial class GoogleFirestoreField(string name) : TerraformResource("google_firestore_field", name)
{
    /// <summary>
    /// The id of the collection group to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformValue<string> Collection
    {
        get => new TerraformReference<string>(this, "collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => new TerraformReference<string>(this, "database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The id of the field to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of this field. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/fields/{{field}}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// IndexConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexConfig block(s) allowed")]
    public TerraformList<GoogleFirestoreFieldIndexConfigBlock>? IndexConfig
    {
        get => GetArgument<TerraformList<GoogleFirestoreFieldIndexConfigBlock>>("index_config");
        set => SetArgument("index_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirestoreFieldTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirestoreFieldTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TtlConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtlConfig block(s) allowed")]
    public TerraformList<GoogleFirestoreFieldTtlConfigBlock>? TtlConfig
    {
        get => GetArgument<TerraformList<GoogleFirestoreFieldTtlConfigBlock>>("ttl_config");
        set => SetArgument("ttl_config", value);
    }

}
