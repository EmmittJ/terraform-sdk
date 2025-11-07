using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_arc_kubernetes_flux_configuration resource.
/// </summary>
public class AzurermArcKubernetesFluxConfiguration : TerraformResource
{
    public AzurermArcKubernetesFluxConfiguration(string name) : base("azurerm_arc_kubernetes_flux_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ContinuousReconciliationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("continuous_reconciliation_enabled");
        set => this.WithProperty("continuous_reconciliation_enabled", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

}
