using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_billing_views.
/// </summary>
public partial class AwsBillingViewsDataSource : TerraformDataSource
{
    public AwsBillingViewsDataSource(string name) : base("aws_billing_views", name)
    {
    }

    /// <summary>
    /// The billing_view_types attribute.
    /// </summary>
    [TerraformProperty("billing_view_types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? BillingViewTypes { get; set; }

    /// <summary>
    /// The billing_view attribute.
    /// </summary>
    [TerraformProperty("billing_view")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BillingView { get; }

}
