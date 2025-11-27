using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boolean_policy in GoogleFolderOrganizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleFolderOrganizationPolicyBooleanPolicyBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enforced");
        set => SetArgument("enforced", value);
    }

}


/// <summary>
/// Block type for list_policy in GoogleFolderOrganizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleFolderOrganizationPolicyListPolicyBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "inherit_from_parent");
        set => SetArgument("inherit_from_parent", value);
    }

    /// <summary>
    /// The Google Cloud Console will try to default to a configuration that matches the value specified in this field.
    /// </summary>
    public TerraformValue<string> SuggestedValue
    {
        get => new TerraformReference<string>(this, "suggested_value");
        set => SetArgument("suggested_value", value);
    }

    /// <summary>
    /// Allow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Allow block(s) allowed")]
    public TerraformList<GoogleFolderOrganizationPolicyListPolicyBlockAllowBlock>? Allow
    {
        get => GetArgument<TerraformList<GoogleFolderOrganizationPolicyListPolicyBlockAllowBlock>>("allow");
        set => SetArgument("allow", value);
    }

    /// <summary>
    /// Deny block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deny block(s) allowed")]
    public TerraformList<GoogleFolderOrganizationPolicyListPolicyBlockDenyBlock>? Deny
    {
        get => GetArgument<TerraformList<GoogleFolderOrganizationPolicyListPolicyBlockDenyBlock>>("deny");
        set => SetArgument("deny", value);
    }

}

/// <summary>
/// Block type for allow in GoogleFolderOrganizationPolicyListPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFolderOrganizationPolicyListPolicyBlockAllowBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// The policy can define specific values that are allowed or denied.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for deny in GoogleFolderOrganizationPolicyListPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFolderOrganizationPolicyListPolicyBlockDenyBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// The policy can define specific values that are allowed or denied.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for restore_policy in GoogleFolderOrganizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleFolderOrganizationPolicyRestorePolicyBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "default");
        set => SetArgument("default", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFolderOrganizationPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleFolderOrganizationPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a google_folder_organization_policy Terraform resource.
/// Manages a google_folder_organization_policy resource.
/// </summary>
public partial class GoogleFolderOrganizationPolicy(string name) : TerraformResource("google_folder_organization_policy", name)
{
    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    public required TerraformValue<string> Constraint
    {
        get => new TerraformReference<string>(this, "constraint");
        set => SetArgument("constraint", value);
    }

    /// <summary>
    /// The resource name of the folder to set the policy for. Its format is folders/{folder_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformValue<string> Folder
    {
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
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
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// BooleanPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BooleanPolicy block(s) allowed")]
    public TerraformList<GoogleFolderOrganizationPolicyBooleanPolicyBlock>? BooleanPolicy
    {
        get => GetArgument<TerraformList<GoogleFolderOrganizationPolicyBooleanPolicyBlock>>("boolean_policy");
        set => SetArgument("boolean_policy", value);
    }

    /// <summary>
    /// ListPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ListPolicy block(s) allowed")]
    public TerraformList<GoogleFolderOrganizationPolicyListPolicyBlock>? ListPolicy
    {
        get => GetArgument<TerraformList<GoogleFolderOrganizationPolicyListPolicyBlock>>("list_policy");
        set => SetArgument("list_policy", value);
    }

    /// <summary>
    /// RestorePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestorePolicy block(s) allowed")]
    public TerraformList<GoogleFolderOrganizationPolicyRestorePolicyBlock>? RestorePolicy
    {
        get => GetArgument<TerraformList<GoogleFolderOrganizationPolicyRestorePolicyBlock>>("restore_policy");
        set => SetArgument("restore_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFolderOrganizationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFolderOrganizationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
