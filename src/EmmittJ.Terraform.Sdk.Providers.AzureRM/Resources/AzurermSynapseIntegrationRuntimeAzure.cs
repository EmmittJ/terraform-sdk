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
    public TerraformLiteralProperty<string>? ComputeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_type");
        set => this.WithProperty("compute_type", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CoreCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("core_count");
        set => this.WithProperty("core_count", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The time_to_live_min attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TimeToLiveMin
    {
        get => GetProperty<TerraformLiteralProperty<double>>("time_to_live_min");
        set => this.WithProperty("time_to_live_min", value);
    }

}
