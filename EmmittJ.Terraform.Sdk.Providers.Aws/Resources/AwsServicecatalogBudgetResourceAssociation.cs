using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_budget_resource_association resource.
/// </summary>
public class AwsServicecatalogBudgetResourceAssociation : TerraformResource
{
    public AwsServicecatalogBudgetResourceAssociation(string name) : base("aws_servicecatalog_budget_resource_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The budget_name attribute.
    /// </summary>
    public string? BudgetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("budget_name")?.Value;
        set => this.WithProperty("budget_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
