using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleProjectDefaultServiceAccounts.
/// Nesting mode: single
/// </summary>
public class GoogleProjectDefaultServiceAccountsTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_project_default_service_accounts Terraform resource.
/// Manages a google_project_default_service_accounts resource.
/// </summary>
public partial class GoogleProjectDefaultServiceAccounts(string name) : TerraformResource("google_project_default_service_accounts", name)
{
    /// <summary>
    /// The action to be performed in the default service accounts. Valid values are: DEPRIVILEGE, DELETE, DISABLE.
    /// 				Note that DEPRIVILEGE action will ignore the REVERT configuration in the restore_policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The project ID where service accounts are created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The action to be performed in the default service accounts on the resource destroy.
    /// 				Valid values are NONE, REVERT and REVERT_AND_IGNORE_FAILURE. It is applied for any action but in the DEPRIVILEGE.
    /// </summary>
    public TerraformValue<string>? RestorePolicy
    {
        get => new TerraformReference<string>(this, "restore_policy");
        set => SetArgument("restore_policy", value);
    }

    /// <summary>
    /// The Service Accounts changed by this resource. It is used for revert the action on the destroy.
    /// </summary>
    public TerraformMap<string> ServiceAccounts
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "service_accounts").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleProjectDefaultServiceAccountsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleProjectDefaultServiceAccountsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
