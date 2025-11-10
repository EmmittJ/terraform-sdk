using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_caller_identity.
/// </summary>
public class AwsCallerIdentityDataSource : TerraformDataSource
{
    public AwsCallerIdentityDataSource(string name) : base("aws_caller_identity", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_id");

}
