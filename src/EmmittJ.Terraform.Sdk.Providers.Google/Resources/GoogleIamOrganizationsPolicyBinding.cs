using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class GoogleIamOrganizationsPolicyBindingConditionBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    public TerraformProperty<string>? Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

    /// <summary>
    /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class GoogleIamOrganizationsPolicyBindingTargetBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. Full Resource Name of the principal set used for principal access boundary policy bindings.
    /// Examples for each one of the following supported principal set types:
    /// * Organization &#39;//cloudresourcemanager.googleapis.com/organizations/ORGANIZATION_ID&#39;
    /// * Workforce Identity: &#39;//iam.googleapis.com/locations/global/workforcePools/WORKFORCE_POOL_ID&#39;
    /// * Workspace Identity: &#39;//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID&#39;
    /// It must be parent by the policy binding&#39;s parent (the organization).
    /// </summary>
    public TerraformProperty<string>? PrincipalSet
    {
        get => GetProperty<TerraformProperty<string>>("principal_set");
        set => WithProperty("principal_set", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamOrganizationsPolicyBindingTimeoutsBlock : TerraformBlock
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
/// Manages a google_iam_organizations_policy_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIamOrganizationsPolicyBinding : TerraformResource
{
    public GoogleIamOrganizationsPolicyBinding(string name) : base("google_iam_organizations_policy_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("policy_uid");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. User defined annotations. See https://google.aip.dev/148#annotations for more details such as format and size limitations
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Optional. The description of the policy binding. Must be less than or equal to 63 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location of the Policy Binding
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The parent organization of the Policy Binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformProperty<string> Organization
    {
        get => GetProperty<TerraformProperty<string>>("organization");
        set => this.WithProperty("organization", value);
    }

    /// <summary>
    /// Required. Immutable. The resource name of the policy to be bound. The binding parent and policy must belong to the same Organization (or Project).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// The Policy Binding ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyBindingId is required")]
    public required TerraformProperty<string> PolicyBindingId
    {
        get => GetProperty<TerraformProperty<string>>("policy_binding_id");
        set => this.WithProperty("policy_binding_id", value);
    }

    /// <summary>
    /// Immutable. The kind of the policy to attach in this binding. This
    /// field must be one of the following:  - Left empty (will be automatically set
    /// to the policy kind) - The input policy kind   Possible values:  POLICY_KIND_UNSPECIFIED PRINCIPAL_ACCESS_BOUNDARY ACCESS
    /// </summary>
    public TerraformProperty<string>? PolicyKind
    {
        get => GetProperty<TerraformProperty<string>>("policy_kind");
        set => this.WithProperty("policy_kind", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public List<GoogleIamOrganizationsPolicyBindingConditionBlock>? Condition
    {
        get => GetProperty<List<GoogleIamOrganizationsPolicyBindingConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<GoogleIamOrganizationsPolicyBindingTargetBlock>? Target
    {
        get => GetProperty<List<GoogleIamOrganizationsPolicyBindingTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamOrganizationsPolicyBindingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIamOrganizationsPolicyBindingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time when the policy binding was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// Optional. The etag for the policy binding. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The name of the policy binding in the format &#39;{binding_parent/locations/{location}/policyBindings/{policy_binding_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The globally unique ID of the policy to be bound.
    /// </summary>
    public TerraformExpression PolicyUid => this["policy_uid"];

    /// <summary>
    /// Output only. The globally unique ID of the policy binding. Assigned when the policy binding is created.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the policy binding was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
