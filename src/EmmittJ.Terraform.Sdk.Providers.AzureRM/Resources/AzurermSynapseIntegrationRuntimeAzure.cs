using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_integration_runtime_azure resource.
/// </summary>
public class AzurermSynapseIntegrationRuntimeAzure : TerraformResource
{
    public AzurermSynapseIntegrationRuntimeAzure(string name) : base("azurerm_synapse_integration_runtime_azure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public string? ComputeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_type")?.Value;
        set => this.WithProperty("compute_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public double? CoreCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("core_count")?.Value;
        set => this.WithProperty("core_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The synapse_workspace_id attribute.
    /// </summary>
    public string? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id")?.Value;
        set => this.WithProperty("synapse_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_to_live_min attribute.
    /// </summary>
    public double? TimeToLiveMin
    {
        get => GetProperty<TerraformLiteralProperty<double>>("time_to_live_min")?.Value;
        set => this.WithProperty("time_to_live_min", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
