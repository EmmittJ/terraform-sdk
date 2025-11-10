using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AzurermRouteMapRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The next_step_if_matched attribute.
    /// </summary>
    public TerraformProperty<string>? NextStepIfMatched
    {
        get => GetProperty<TerraformProperty<string>>("next_step_if_matched");
        set => WithProperty("next_step_if_matched", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRouteMapTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_route_map resource.
/// </summary>
public class AzurermRouteMap : TerraformResource
{
    public AzurermRouteMap(string name) : base("azurerm_route_map", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermRouteMapRuleBlock>? Rule
    {
        get => GetProperty<List<AzurermRouteMapRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRouteMapTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRouteMapTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
