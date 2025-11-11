using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_organization resource.
/// </summary>
public partial class AwsOrganizationsOrganization : TerraformResource
{
    public AwsOrganizationsOrganization(string name) : base("aws_organizations_organization", name)
    {
    }

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    [TerraformProperty("aws_service_access_principals")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AwsServiceAccessPrincipals { get; set; }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    [TerraformProperty("enabled_policy_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EnabledPolicyTypes { get; set; }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    [TerraformProperty("feature_set")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FeatureSet { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Accounts { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    [TerraformProperty("master_account_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterAccountArn { get; }

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    [TerraformProperty("master_account_email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterAccountEmail { get; }

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformProperty("master_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterAccountId { get; }

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    [TerraformProperty("master_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterAccountName { get; }

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    [TerraformProperty("non_master_accounts")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NonMasterAccounts { get; }

    /// <summary>
    /// The roots attribute.
    /// </summary>
    [TerraformProperty("roots")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Roots { get; }

}
