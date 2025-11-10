using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_delegated_administrator resource.
/// </summary>
public class AwsOrganizationsDelegatedAdministrator : TerraformResource
{
    public AwsOrganizationsDelegatedAdministrator(string name) : base("aws_organizations_delegated_administrator", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    [TerraformPropertyName("service_principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePrincipal { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The delegation_enabled_date attribute.
    /// </summary>
    [TerraformPropertyName("delegation_enabled_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DelegationEnabledDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delegation_enabled_date");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    [TerraformPropertyName("joined_method")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JoinedMethod => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "joined_method");

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("joined_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JoinedTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "joined_timestamp");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
