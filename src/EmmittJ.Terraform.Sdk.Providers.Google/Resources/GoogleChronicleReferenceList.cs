using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entries in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleReferenceListEntriesBlock : TerraformBlock
{
    /// <summary>
    /// Required. The value of the entry. Maximum length is 512 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for scope_info in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleReferenceListScopeInfoBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleReferenceListTimeoutsBlock : TerraformBlock
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
/// Manages a google_chronicle_reference_list resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleChronicleReferenceList : TerraformResource
{
    public GoogleChronicleReferenceList(string name) : base("google_chronicle_reference_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
        this.DeclareOutput("name");
        this.DeclareOutput("revision_create_time");
        this.DeclareOutput("rule_associations_count");
        this.DeclareOutput("rules");
    }

    /// <summary>
    /// Required. A user-provided description of the reference list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Required. The ID to use for the reference list. This is also the display name for
    /// the reference list. It must satisfy the following requirements:
    /// - Starts with letter.
    /// - Contains only letters, numbers and underscore.
    /// - Has length &amp;lt; 256.
    /// - Must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceListId is required")]
    public required TerraformProperty<string> ReferenceListId
    {
        get => GetProperty<TerraformProperty<string>>("reference_list_id");
        set => this.WithProperty("reference_list_id", value);
    }

    /// <summary>
    /// Possible values:
    /// REFERENCE_LIST_SYNTAX_TYPE_PLAIN_TEXT_STRING
    /// REFERENCE_LIST_SYNTAX_TYPE_REGEX
    /// REFERENCE_LIST_SYNTAX_TYPE_CIDR
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyntaxType is required")]
    public required TerraformProperty<string> SyntaxType
    {
        get => GetProperty<TerraformProperty<string>>("syntax_type");
        set => this.WithProperty("syntax_type", value);
    }

    /// <summary>
    /// Block for entries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entries block(s) required")]
    public List<GoogleChronicleReferenceListEntriesBlock>? Entries
    {
        get => GetProperty<List<GoogleChronicleReferenceListEntriesBlock>>("entries");
        set => this.WithProperty("entries", value);
    }

    /// <summary>
    /// Block for scope_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeInfo block(s) allowed")]
    public List<GoogleChronicleReferenceListScopeInfoBlock>? ScopeInfo
    {
        get => GetProperty<List<GoogleChronicleReferenceListScopeInfoBlock>>("scope_info");
        set => this.WithProperty("scope_info", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleReferenceListTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleChronicleReferenceListTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The unique display name of the reference list.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. The resource name of the reference list.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The timestamp when the reference list was last updated.
    /// </summary>
    public TerraformExpression RevisionCreateTime => this["revision_create_time"];

    /// <summary>
    /// Output only. The count of self-authored rules using the reference list.
    /// </summary>
    public TerraformExpression RuleAssociationsCount => this["rule_associations_count"];

    /// <summary>
    /// Output only. The resource names for the associated self-authored Rules that use this
    /// reference list.
    /// This is returned only when the view is REFERENCE_LIST_VIEW_FULL.
    /// </summary>
    public TerraformExpression Rules => this["rules"];

}
