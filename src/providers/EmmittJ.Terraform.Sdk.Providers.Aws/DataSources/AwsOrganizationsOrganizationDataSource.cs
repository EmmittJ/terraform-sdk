using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organization.
/// </summary>
public partial class AwsOrganizationsOrganizationDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationDataSource(string name) : base("aws_organizations_organization", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Accounts { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    [TerraformProperty("aws_service_access_principals")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AwsServiceAccessPrincipals { get; }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    [TerraformProperty("enabled_policy_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> EnabledPolicyTypes { get; }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    [TerraformProperty("feature_set")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FeatureSet { get; }

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    [TerraformProperty("master_account_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterAccountArn { get; }

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    [TerraformProperty("master_account_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterAccountEmail { get; }

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformProperty("master_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterAccountId { get; }

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    [TerraformProperty("master_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterAccountName { get; }

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    [TerraformProperty("non_master_accounts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NonMasterAccounts { get; }

    /// <summary>
    /// The roots attribute.
    /// </summary>
    [TerraformProperty("roots")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Roots { get; }

}
