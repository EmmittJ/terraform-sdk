using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for index_config in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreFieldIndexConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreFieldTimeoutsBlock : TerraformBlock
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
/// Block type for ttl_config in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreFieldTtlConfigBlock : TerraformBlock
{
    /// <summary>
    /// The state of TTL (time-to-live) configuration for documents that have this Field set.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Manages a google_firestore_field resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirestoreField : TerraformResource
{
    public GoogleFirestoreField(string name) : base("google_firestore_field", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("collection");
        SetOutput("database");
        SetOutput("field");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The id of the collection group to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformProperty<string> Collection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collection");
        set => SetProperty("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The id of the field to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformProperty<string> Field
    {
        get => GetRequiredOutput<TerraformProperty<string>>("field");
        set => SetProperty("field", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for index_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexConfig block(s) allowed")]
    public List<GoogleFirestoreFieldIndexConfigBlock>? IndexConfig
    {
        set => SetProperty("index_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirestoreFieldTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for ttl_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtlConfig block(s) allowed")]
    public List<GoogleFirestoreFieldTtlConfigBlock>? TtlConfig
    {
        set => SetProperty("ttl_config", value);
    }

    /// <summary>
    /// The name of this field. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/fields/{{field}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
