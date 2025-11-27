using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entries in GoogleChronicleReferenceList.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleReferenceListEntriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entries";

    /// <summary>
    /// Required. The value of the entry. Maximum length is 512 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for scope_info in GoogleChronicleReferenceList.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleReferenceListScopeInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope_info";

    /// <summary>
    /// ReferenceListScope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceListScope block(s) allowed")]
    public TerraformList<GoogleChronicleReferenceListScopeInfoBlockReferenceListScopeBlock>? ReferenceListScope
    {
        get => GetArgument<TerraformList<GoogleChronicleReferenceListScopeInfoBlockReferenceListScopeBlock>>("reference_list_scope");
        set => SetArgument("reference_list_scope", value);
    }

}

/// <summary>
/// Block type for reference_list_scope in GoogleChronicleReferenceListScopeInfoBlock.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleReferenceListScopeInfoBlockReferenceListScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reference_list_scope";

    /// <summary>
    /// Optional. The list of scope names of the reference list. The scope names should be
    /// full resource names and should be of the format:
    /// &amp;quot;projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{scope_name}&amp;quot;.
    /// </summary>
    public TerraformList<string>? ScopeNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scope_names").ResolveNodes(ctx));
        set => SetArgument("scope_names", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleChronicleReferenceList.
/// Nesting mode: single
/// </summary>
public class GoogleChronicleReferenceListTimeoutsBlock : TerraformBlock
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
/// Represents a google_chronicle_reference_list Terraform resource.
/// Manages a google_chronicle_reference_list resource.
/// </summary>
public partial class GoogleChronicleReferenceList(string name) : TerraformResource("google_chronicle_reference_list", name)
{
    /// <summary>
    /// Required. A user-provided description of the reference list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// Required. The ID to use for the reference list. This is also the display name for
    /// the reference list. It must satisfy the following requirements:
    /// - Starts with letter.
    /// - Contains only letters, numbers and underscore.
    /// - Has length &amp;lt; 256.
    /// - Must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceListId is required")]
    public required TerraformValue<string> ReferenceListId
    {
        get => new TerraformReference<string>(this, "reference_list_id");
        set => SetArgument("reference_list_id", value);
    }

    /// <summary>
    /// Possible values:
    /// REFERENCE_LIST_SYNTAX_TYPE_PLAIN_TEXT_STRING
    /// REFERENCE_LIST_SYNTAX_TYPE_REGEX
    /// REFERENCE_LIST_SYNTAX_TYPE_CIDR
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyntaxType is required")]
    public required TerraformValue<string> SyntaxType
    {
        get => new TerraformReference<string>(this, "syntax_type");
        set => SetArgument("syntax_type", value);
    }

    /// <summary>
    /// Output only. The unique display name of the reference list.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// Output only. The resource name of the reference list.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The timestamp when the reference list was last updated.
    /// </summary>
    public TerraformValue<string> RevisionCreateTime
    {
        get => new TerraformReference<string>(this, "revision_create_time");
    }

    /// <summary>
    /// Output only. The count of self-authored rules using the reference list.
    /// </summary>
    public TerraformValue<double> RuleAssociationsCount
    {
        get => new TerraformReference<double>(this, "rule_associations_count");
    }

    /// <summary>
    /// Output only. The resource names for the associated self-authored Rules that use this
    /// reference list.
    /// This is returned only when the view is REFERENCE_LIST_VIEW_FULL.
    /// </summary>
    public TerraformList<string> Rules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// Entries block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entries block(s) required")]
    public required TerraformList<GoogleChronicleReferenceListEntriesBlock> Entries
    {
        get => GetRequiredArgument<TerraformList<GoogleChronicleReferenceListEntriesBlock>>("entries");
        set => SetArgument("entries", value);
    }

    /// <summary>
    /// ScopeInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeInfo block(s) allowed")]
    public TerraformList<GoogleChronicleReferenceListScopeInfoBlock>? ScopeInfo
    {
        get => GetArgument<TerraformList<GoogleChronicleReferenceListScopeInfoBlock>>("scope_info");
        set => SetArgument("scope_info", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleChronicleReferenceListTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleChronicleReferenceListTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
