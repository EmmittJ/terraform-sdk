using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_image resource.
/// </summary>
public class AzurermImage : TerraformResource
{
    public AzurermImage(string name) : base("azurerm_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string>? HyperVGeneration
    {
        get => GetProperty<TerraformProperty<string>>("hyper_v_generation");
        set => this.WithProperty("hyper_v_generation", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("source_virtual_machine_id");
        set => this.WithProperty("source_virtual_machine_id", value);
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
    /// The zone_resilient attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneResilient
    {
        get => GetProperty<TerraformProperty<bool>>("zone_resilient");
        set => this.WithProperty("zone_resilient", value);
    }

}
