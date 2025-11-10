using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerAdminRuleDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    public required TerraformProperty<string> AddressPrefix
    {
        set => SetProperty("address_prefix", value);
    }

    /// <summary>
    /// The address_prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixType is required")]
    public required TerraformProperty<string> AddressPrefixType
    {
        set => SetProperty("address_prefix_type", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerAdminRuleSourceBlock : TerraformBlock
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    public required TerraformProperty<string> AddressPrefix
    {
        set => SetProperty("address_prefix", value);
    }

    /// <summary>
    /// The address_prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixType is required")]
    public required TerraformProperty<string> AddressPrefixType
    {
        set => SetProperty("address_prefix_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerAdminRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_manager_admin_rule resource.
/// </summary>
public class AzurermNetworkManagerAdminRule : TerraformResource
{
    public AzurermNetworkManagerAdminRule(string name) : base("azurerm_network_manager_admin_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("admin_rule_collection_id");
        SetOutput("description");
        SetOutput("destination_port_ranges");
        SetOutput("direction");
        SetOutput("id");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("protocol");
        SetOutput("source_port_ranges");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The admin_rule_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminRuleCollectionId is required")]
    public required TerraformProperty<string> AdminRuleCollectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_rule_collection_id");
        set => SetProperty("admin_rule_collection_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>> DestinationPortRanges
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("destination_port_ranges");
        set => SetProperty("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformProperty<string> Direction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("direction");
        set => SetProperty("direction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>> SourcePortRanges
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("source_port_ranges");
        set => SetProperty("source_port_ranges", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNetworkManagerAdminRuleDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNetworkManagerAdminRuleSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerAdminRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
