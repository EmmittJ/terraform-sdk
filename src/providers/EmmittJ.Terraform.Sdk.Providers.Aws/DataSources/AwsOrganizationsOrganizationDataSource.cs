using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organization.
/// </summary>
public class AwsOrganizationsOrganizationDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationDataSource(string name) : base("aws_organizations_organization", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Accounts => new TerraformReference(this, "accounts");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    [TerraformPropertyName("aws_service_access_principals")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AwsServiceAccessPrincipals => new TerraformReference(this, "aws_service_access_principals");

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_policy_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> EnabledPolicyTypes => new TerraformReference(this, "enabled_policy_types");

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    [TerraformPropertyName("feature_set")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FeatureSet => new TerraformReference(this, "feature_set");

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    [TerraformPropertyName("master_account_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterAccountArn => new TerraformReference(this, "master_account_arn");

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    [TerraformPropertyName("master_account_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterAccountEmail => new TerraformReference(this, "master_account_email");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformPropertyName("master_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterAccountId => new TerraformReference(this, "master_account_id");

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    [TerraformPropertyName("master_account_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterAccountName => new TerraformReference(this, "master_account_name");

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    [TerraformPropertyName("non_master_accounts")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NonMasterAccounts => new TerraformReference(this, "non_master_accounts");

    /// <summary>
    /// The roots attribute.
    /// </summary>
    [TerraformPropertyName("roots")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Roots => new TerraformReference(this, "roots");

}
