using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipfx_emission in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock : TerraformBlock
{
    /// <summary>
    /// The destination_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTypes is required")]
    public List<TerraformProperty<string>>? DestinationTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("destination_types");
        set => WithProperty("destination_types", value);
    }

}

/// <summary>
/// Block type for ipfx_ingestion in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock : TerraformBlock
{
    /// <summary>
    /// The source_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceIds is required")]
    public HashSet<TerraformProperty<string>>? SourceResourceIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_resource_ids");
        set => WithProperty("source_resource_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkFunctionCollectorPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_function_collector_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkFunctionCollectorPolicy : TerraformResource
{
    public AzurermNetworkFunctionCollectorPolicy(string name) : base("azurerm_network_function_collector_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The traffic_collector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficCollectorId is required")]
    public required TerraformProperty<string> TrafficCollectorId
    {
        get => GetProperty<TerraformProperty<string>>("traffic_collector_id");
        set => this.WithProperty("traffic_collector_id", value);
    }

    /// <summary>
    /// Block for ipfx_emission.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpfxEmission block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpfxEmission block(s) allowed")]
    public List<AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock>? IpfxEmission
    {
        get => GetProperty<List<AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock>>("ipfx_emission");
        set => this.WithProperty("ipfx_emission", value);
    }

    /// <summary>
    /// Block for ipfx_ingestion.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpfxIngestion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpfxIngestion block(s) allowed")]
    public List<AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock>? IpfxIngestion
    {
        get => GetProperty<List<AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock>>("ipfx_ingestion");
        set => this.WithProperty("ipfx_ingestion", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkFunctionCollectorPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkFunctionCollectorPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
