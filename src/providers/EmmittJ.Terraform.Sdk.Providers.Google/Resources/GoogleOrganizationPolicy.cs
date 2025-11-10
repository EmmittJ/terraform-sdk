using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boolean_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleOrganizationPolicyBooleanPolicyBlock : TerraformBlock
{
    /// <summary>
    /// If true, then the Policy is enforced. If false, then any configuration is acceptable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforced is required")]
    public required TerraformProperty<bool> Enforced
    {
        set => SetProperty("enforced", value);
    }

}

/// <summary>
/// Block type for list_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleOrganizationPolicyListPolicyBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, the values from the effective Policy of the parent resource are inherited, meaning the values set in this Policy are added to the values inherited up the hierarchy.
    /// </summary>
    public TerraformProperty<bool>? InheritFromParent
    {
        set => SetProperty("inherit_from_parent", value);
    }

    /// <summary>
    /// The Google Cloud Console will try to default to a configuration that matches the value specified in this field.
    /// </summary>
    public TerraformProperty<string>? SuggestedValue
    {
        set => SetProperty("suggested_value", value);
    }

}

/// <summary>
/// Block type for restore_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleOrganizationPolicyRestorePolicyBlock : TerraformBlock
{
    /// <summary>
    /// May only be set to true. If set, then the default Policy is restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Default is required")]
    public required TerraformProperty<bool> Default
    {
        set => SetProperty("default", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOrganizationPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a google_organization_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOrganizationPolicy : TerraformResource
{
    public GoogleOrganizationPolicy(string name) : base("google_organization_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("update_time");
        SetOutput("constraint");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("version");
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    public required TerraformProperty<string> Constraint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("constraint");
        set => SetProperty("constraint", value);
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
    /// The org_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public TerraformProperty<double> Version
    {
        get => GetRequiredOutput<TerraformProperty<double>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for boolean_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BooleanPolicy block(s) allowed")]
    public List<GoogleOrganizationPolicyBooleanPolicyBlock>? BooleanPolicy
    {
        set => SetProperty("boolean_policy", value);
    }

    /// <summary>
    /// Block for list_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ListPolicy block(s) allowed")]
    public List<GoogleOrganizationPolicyListPolicyBlock>? ListPolicy
    {
        set => SetProperty("list_policy", value);
    }

    /// <summary>
    /// Block for restore_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestorePolicy block(s) allowed")]
    public List<GoogleOrganizationPolicyRestorePolicyBlock>? RestorePolicy
    {
        set => SetProperty("restore_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOrganizationPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
