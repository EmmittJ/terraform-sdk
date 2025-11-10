using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudtrail_organization_delegated_admin_account resource.
/// </summary>
public class AwsCloudtrailOrganizationDelegatedAdminAccount : TerraformResource
{
    public AwsCloudtrailOrganizationDelegatedAdminAccount(string name) : base("aws_cloudtrail_organization_delegated_admin_account", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformPropertyName("account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformPropertyName("service_principal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServicePrincipal => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_principal");

}
