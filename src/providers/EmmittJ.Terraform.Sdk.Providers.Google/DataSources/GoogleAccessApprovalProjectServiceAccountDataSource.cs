using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_project_service_account.
/// </summary>
public class GoogleAccessApprovalProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalProjectServiceAccountDataSource(string name) : base("google_access_approval_project_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformPropertyName("project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectId { get; set; }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    [TerraformPropertyName("account_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_email");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
