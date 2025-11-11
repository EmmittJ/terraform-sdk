using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_delegated_administrator resource.
/// </summary>
public partial class AwsOrganizationsDelegatedAdministrator : TerraformResource
{
    public AwsOrganizationsDelegatedAdministrator(string name) : base("aws_organizations_delegated_administrator", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    [TerraformProperty("service_principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePrincipal { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The delegation_enabled_date attribute.
    /// </summary>
    [TerraformProperty("delegation_enabled_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DelegationEnabledDate { get; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Email { get; }

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    [TerraformProperty("joined_method")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> JoinedMethod { get; }

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    [TerraformProperty("joined_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> JoinedTimestamp { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
