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
        this.DeclareOutput("billing_view");
    }

    /// <summary>
    /// The billing_view_types attribute.
    /// </summary>
    public List<string>? BillingViewTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("billing_view_types")?.Value;
        set => this.WithProperty("billing_view_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The billing_view attribute.
    /// </summary>
    public TerraformExpression BillingView => this["billing_view"];

}
