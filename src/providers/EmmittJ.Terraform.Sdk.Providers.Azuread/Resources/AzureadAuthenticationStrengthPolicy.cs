using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAuthenticationStrengthPolicy.
/// Nesting mode: single
/// </summary>
public class AzureadAuthenticationStrengthPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_authentication_strength_policy Terraform resource.
/// Manages a azuread_authentication_strength_policy resource.
/// </summary>
public partial class AzureadAuthenticationStrengthPolicy(string name) : TerraformResource("azuread_authentication_strength_policy", name)
{
    /// <summary>
    /// The allowed MFA methods for this policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedCombinations is required")]
    public required TerraformSet<string> AllowedCombinations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_combinations").ResolveNodes(ctx));
        set => SetArgument("allowed_combinations", value);
    }

    /// <summary>
    /// The description for the authentication strength policy
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name for the authentication strength policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAuthenticationStrengthPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAuthenticationStrengthPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
