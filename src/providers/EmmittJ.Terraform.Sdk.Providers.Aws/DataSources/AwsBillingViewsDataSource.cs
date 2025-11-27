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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "billing_view_types").ResolveNodes(ctx));
        set => SetArgument("billing_view_types", value);
    }

    /// <summary>
    /// The billing_view attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BillingView
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "billing_view").ResolveNodes(ctx));
    }

}
