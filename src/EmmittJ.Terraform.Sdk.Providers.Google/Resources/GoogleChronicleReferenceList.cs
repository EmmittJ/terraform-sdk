using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_chronicle_reference_list resource.
/// </summary>
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
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
    public TerraformProperty<string>? ReferenceListId
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
    public TerraformProperty<string>? SyntaxType
    {
        get => GetProperty<TerraformProperty<string>>("syntax_type");
        set => this.WithProperty("syntax_type", value);
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
