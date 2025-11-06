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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recommendation_id attribute.
    /// </summary>
    public string? RecommendationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recommendation_id")?.Value;
        set => this.WithProperty("recommendation_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public string? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ttl")?.Value;
        set => this.WithProperty("ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The suppression_id attribute.
    /// </summary>
    public TerraformExpression SuppressionId => this["suppression_id"];

}
