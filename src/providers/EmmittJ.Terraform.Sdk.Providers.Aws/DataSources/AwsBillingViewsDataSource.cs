using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_billing_views Terraform data source.
/// Retrieves information about a aws_billing_views.
/// </summary>
public partial class AwsBillingViewsDataSource(string name) : TerraformDataSource("aws_billing_views", name)
{
    /// <summary>
    /// The billing_view_types attribute.
    /// </summary>
    public TerraformList<string>? BillingViewTypes
    {
        get => GetArgument<TerraformList<string>>("billing_view_types");
        set => SetArgument("billing_view_types", value);
    }

    /// <summary>
    /// The billing_view attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BillingView
        => AsReference("billing_view");

}
