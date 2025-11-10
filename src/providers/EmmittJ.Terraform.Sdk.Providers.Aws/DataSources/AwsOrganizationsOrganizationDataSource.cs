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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Accounts => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "accounts");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    [TerraformPropertyName("aws_service_access_principals")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AwsServiceAccessPrincipals => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "aws_service_access_principals");

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_policy_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> EnabledPolicyTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "enabled_policy_types");

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    [TerraformPropertyName("feature_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FeatureSet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "feature_set");

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    [TerraformPropertyName("master_account_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterAccountArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_account_arn");

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    [TerraformPropertyName("master_account_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterAccountEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_account_email");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformPropertyName("master_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_account_id");

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    [TerraformPropertyName("master_account_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterAccountName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_account_name");

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    [TerraformPropertyName("non_master_accounts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NonMasterAccounts => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "non_master_accounts");

    /// <summary>
    /// The roots attribute.
    /// </summary>
    [TerraformPropertyName("roots")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Roots => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "roots");

}
