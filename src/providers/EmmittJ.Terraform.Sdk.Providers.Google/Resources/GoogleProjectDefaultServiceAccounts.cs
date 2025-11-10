using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleProjectDefaultServiceAccountsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a google_project_default_service_accounts resource.
/// </summary>
public class GoogleProjectDefaultServiceAccounts : TerraformResource
{
    public GoogleProjectDefaultServiceAccounts(string name) : base("google_project_default_service_accounts", name)
    {
    }

    /// <summary>
    /// The action to be performed in the default service accounts. Valid values are: DEPRIVILEGE, DELETE, DISABLE.
    /// 				Note that DEPRIVILEGE action will ignore the REVERT configuration in the restore_policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project ID where service accounts are created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

    /// <summary>
    /// The action to be performed in the default service accounts on the resource destroy.
    /// 				Valid values are NONE, REVERT and REVERT_AND_IGNORE_FAILURE. It is applied for any action but in the DEPRIVILEGE.
    /// </summary>
    [TerraformPropertyName("restore_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestorePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleProjectDefaultServiceAccountsTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The Service Accounts changed by this resource. It is used for revert the action on the destroy.
    /// </summary>
    [TerraformPropertyName("service_accounts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ServiceAccounts => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "service_accounts");

}
