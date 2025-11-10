using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boolean_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyBooleanPolicyBlock : TerraformBlock
{
    /// <summary>
    /// If true, then the Policy is enforced. If false, then any configuration is acceptable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforced is required")]
    public required TerraformProperty<bool> Enforced
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enforced");
        set => WithProperty("enforced", value);
    }

}

/// <summary>
/// Block type for list_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyListPolicyBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, the values from the effective Policy of the parent resource are inherited, meaning the values set in this Policy are added to the values inherited up the hierarchy.
    /// </summary>
    public TerraformProperty<bool>? InheritFromParent
    {
        get => GetProperty<TerraformProperty<bool>>("inherit_from_parent");
        set => WithProperty("inherit_from_parent", value);
    }

    /// <summary>
    /// The Google Cloud Console will try to default to a configuration that matches the value specified in this field.
    /// </summary>
    public TerraformProperty<string>? SuggestedValue
    {
        get => GetProperty<TerraformProperty<string>>("suggested_value");
        set => WithProperty("suggested_value", value);
    }

}

/// <summary>
/// Block type for restore_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyRestorePolicyBlock : TerraformBlock
{
    /// <summary>
    /// May only be set to true. If set, then the default Policy is restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Default is required")]
    public required TerraformProperty<bool> Default
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("default");
        set => WithProperty("default", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleProjectOrganizationPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a google_project_organization_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleProjectOrganizationPolicy : TerraformResource
{
    public GoogleProjectOrganizationPolicy(string name) : base("google_project_organization_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("etag");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    public required TerraformProperty<string> Constraint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("constraint");
        set => this.WithProperty("constraint", value);
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
    /// The project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformProperty<string> Project
    {
        get => GetRequiredProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public TerraformProperty<double>? Version
    {
        get => GetProperty<TerraformProperty<double>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for boolean_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BooleanPolicy block(s) allowed")]
    public List<GoogleProjectOrganizationPolicyBooleanPolicyBlock>? BooleanPolicy
    {
        get => GetProperty<List<GoogleProjectOrganizationPolicyBooleanPolicyBlock>>("boolean_policy");
        set => this.WithProperty("boolean_policy", value);
    }

    /// <summary>
    /// Block for list_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ListPolicy block(s) allowed")]
    public List<GoogleProjectOrganizationPolicyListPolicyBlock>? ListPolicy
    {
        get => GetProperty<List<GoogleProjectOrganizationPolicyListPolicyBlock>>("list_policy");
        set => this.WithProperty("list_policy", value);
    }

    /// <summary>
    /// Block for restore_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestorePolicy block(s) allowed")]
    public List<GoogleProjectOrganizationPolicyRestorePolicyBlock>? RestorePolicy
    {
        get => GetProperty<List<GoogleProjectOrganizationPolicyRestorePolicyBlock>>("restore_policy");
        set => this.WithProperty("restore_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleProjectOrganizationPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleProjectOrganizationPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
