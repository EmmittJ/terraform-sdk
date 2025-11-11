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
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    [TerraformPropertyName("service_principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServicePrincipal { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The delegation_enabled_date attribute.
    /// </summary>
    [TerraformPropertyName("delegation_enabled_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DelegationEnabledDate => new TerraformReference(this, "delegation_enabled_date");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Email => new TerraformReference(this, "email");

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    [TerraformPropertyName("joined_method")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JoinedMethod => new TerraformReference(this, "joined_method");

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("joined_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JoinedTimestamp => new TerraformReference(this, "joined_timestamp");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
