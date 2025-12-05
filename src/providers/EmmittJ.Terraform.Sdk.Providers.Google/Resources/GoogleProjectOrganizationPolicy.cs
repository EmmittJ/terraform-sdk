using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boolean_policy in GoogleProjectOrganizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyBooleanPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boolean_policy";

    /// <summary>
    /// If true, then the Policy is enforced. If false, then any configuration is acceptable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforced is required")]
    public required TerraformValue<bool> Enforced
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enforced");
        set => SetArgument("enforced", value);
    }

}


/// <summary>
/// Block type for list_policy in GoogleProjectOrganizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyListPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "list_policy";

    /// <summary>
    /// If set to true, the values from the effective Policy of the parent resource are inherited, meaning the values set in this Policy are added to the values inherited up the hierarchy.
    /// </summary>
    public TerraformValue<bool>? InheritFromParent
    {
        get => GetArgument<TerraformValue<bool>>("inherit_from_parent");
        set => SetArgument("inherit_from_parent", value);
    }

    /// <summary>
    /// The Google Cloud Console will try to default to a configuration that matches the value specified in this field.
    /// </summary>
    public TerraformValue<string> SuggestedValue
    {
        get => GetArgument<TerraformValue<string>>("suggested_value") ?? CreateReference("suggested_value");
        set => SetArgument("suggested_value", value);
    }

    /// <summary>
    /// Allow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Allow block(s) allowed")]
    public TerraformList<GoogleProjectOrganizationPolicyListPolicyBlockAllowBlock>? Allow
    {
        get => GetArgument<TerraformList<GoogleProjectOrganizationPolicyListPolicyBlockAllowBlock>>("allow");
        set => SetArgument("allow", value);
    }

    /// <summary>
    /// Deny block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deny block(s) allowed")]
    public TerraformList<GoogleProjectOrganizationPolicyListPolicyBlockDenyBlock>? Deny
    {
        get => GetArgument<TerraformList<GoogleProjectOrganizationPolicyListPolicyBlockDenyBlock>>("deny");
        set => SetArgument("deny", value);
    }

}

/// <summary>
/// Block type for allow in GoogleProjectOrganizationPolicyListPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyListPolicyBlockAllowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow";

    /// <summary>
    /// The policy allows or denies all values.
    /// </summary>
    public TerraformValue<bool>? All
    {
        get => GetArgument<TerraformValue<bool>>("all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// The policy can define specific values that are allowed or denied.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for deny in GoogleProjectOrganizationPolicyListPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyListPolicyBlockDenyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deny";

    /// <summary>
    /// The policy allows or denies all values.
    /// </summary>
    public TerraformValue<bool>? All
    {
        get => GetArgument<TerraformValue<bool>>("all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// The policy can define specific values that are allowed or denied.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for restore_policy in GoogleProjectOrganizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleProjectOrganizationPolicyRestorePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_policy";

    /// <summary>
    /// May only be set to true. If set, then the default Policy is restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAttribute is required")]
    public required TerraformValue<bool> DefaultAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("default");
        set => SetArgument("default", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleProjectOrganizationPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleProjectOrganizationPolicyTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_project_organization_policy Terraform resource.
/// Manages a google_project_organization_policy resource.
/// </summary>
public partial class GoogleProjectOrganizationPolicy(string name) : TerraformResource("google_project_organization_policy", name)
{
    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    public required TerraformValue<string> Constraint
    {
        get => GetRequiredArgument<TerraformValue<string>>("constraint");
        set => SetArgument("constraint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => GetArgument<TerraformValue<double>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// BooleanPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BooleanPolicy block(s) allowed")]
    public TerraformList<GoogleProjectOrganizationPolicyBooleanPolicyBlock>? BooleanPolicy
    {
        get => GetArgument<TerraformList<GoogleProjectOrganizationPolicyBooleanPolicyBlock>>("boolean_policy");
        set => SetArgument("boolean_policy", value);
    }

    /// <summary>
    /// ListPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ListPolicy block(s) allowed")]
    public TerraformList<GoogleProjectOrganizationPolicyListPolicyBlock>? ListPolicy
    {
        get => GetArgument<TerraformList<GoogleProjectOrganizationPolicyListPolicyBlock>>("list_policy");
        set => SetArgument("list_policy", value);
    }

    /// <summary>
    /// RestorePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestorePolicy block(s) allowed")]
    public TerraformList<GoogleProjectOrganizationPolicyRestorePolicyBlock>? RestorePolicy
    {
        get => GetArgument<TerraformList<GoogleProjectOrganizationPolicyRestorePolicyBlock>>("restore_policy");
        set => SetArgument("restore_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleProjectOrganizationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleProjectOrganizationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
