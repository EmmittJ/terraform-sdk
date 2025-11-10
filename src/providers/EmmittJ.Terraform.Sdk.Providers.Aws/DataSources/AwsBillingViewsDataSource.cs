using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_billing_views.
/// </summary>
public class AwsBillingViewsDataSource : TerraformDataSource
{
    public AwsBillingViewsDataSource(string name) : base("aws_billing_views", name)
    {
    }

    /// <summary>
    /// The billing_view_types attribute.
    /// </summary>
    [TerraformPropertyName("billing_view_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? BillingViewTypes { get; set; }

    /// <summary>
    /// The billing_view attribute.
    /// </summary>
    [TerraformPropertyName("billing_view")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BillingView => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "billing_view");

}
