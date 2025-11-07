using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_advisor_suppression resource.
/// </summary>
public class AzurermAdvisorSuppression : TerraformResource
{
    public AzurermAdvisorSuppression(string name) : base("azurerm_advisor_suppression", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("suppression_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recommendation_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecommendationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recommendation_id");
        set => this.WithProperty("recommendation_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The suppression_id attribute.
    /// </summary>
    public TerraformExpression SuppressionId => this["suppression_id"];

}
