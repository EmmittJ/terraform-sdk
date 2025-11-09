using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_dps resource.
/// </summary>
public class AzurermIothubDps : TerraformResource
{
    public AzurermIothubDps(string name) : base("azurerm_iothub_dps", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("device_provisioning_host_name");
        this.DeclareOutput("id_scope");
        this.DeclareOutput("service_operations_host_name");
    }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("allocation_policy");
        set => this.WithProperty("allocation_policy", value);
    }

    /// <summary>
    /// The data_residency_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataResidencyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_residency_enabled");
        set => this.WithProperty("data_residency_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    public TerraformExpression DeviceProvisioningHostName => this["device_provisioning_host_name"];

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    public TerraformExpression IdScope => this["id_scope"];

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    public TerraformExpression ServiceOperationsHostName => this["service_operations_host_name"];

}
