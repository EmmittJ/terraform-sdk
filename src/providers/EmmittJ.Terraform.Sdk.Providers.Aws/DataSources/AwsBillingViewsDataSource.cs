using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_billing_views.
/// </summary>
public class AwsBillingViewsDataSource : TerraformDataSource
{
    public AwsBillingViewsDataSource(string name) : base("aws_billing_views", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("billing_view");
        SetOutput("billing_view_types");
    }

    /// <summary>
    /// The billing_view_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> BillingViewTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("billing_view_types");
        set => SetProperty("billing_view_types", value);
    }

    /// <summary>
    /// The billing_view attribute.
    /// </summary>
    public TerraformExpression BillingView => this["billing_view"];

}
