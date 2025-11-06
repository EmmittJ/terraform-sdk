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
    public string? HyperVGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyper_v_generation")?.Value;
        set => this.WithProperty("hyper_v_generation", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_virtual_machine_id attribute.
    /// </summary>
    public string? SourceVirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_virtual_machine_id")?.Value;
        set => this.WithProperty("source_virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    public bool? ZoneResilient
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_resilient")?.Value;
        set => this.WithProperty("zone_resilient", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
