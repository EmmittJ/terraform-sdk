using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerAzureEndpointCustomHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_header";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerAzureEndpointSubnetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet";

    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    [TerraformArgument("first")]
    public required TerraformValue<string> First
    {
        get => new TerraformReference<string>(this, "first");
        set => SetArgument("first", value);
    }

    /// <summary>
    /// The last attribute.
    /// </summary>
    [TerraformArgument("last")]
    public TerraformValue<string>? Last
    {
        get => new TerraformReference<string>(this, "last");
        set => SetArgument("last", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformArgument("scope")]
    public TerraformValue<double>? Scope
    {
        get => new TerraformReference<double>(this, "scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerAzureEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_traffic_manager_azure_endpoint resource.
/// </summary>
public class AzurermTrafficManagerAzureEndpoint : TerraformResource
{
    public AzurermTrafficManagerAzureEndpoint(string name) : base("azurerm_traffic_manager_azure_endpoint", name)
    {
    }

    /// <summary>
    /// The always_serve_enabled attribute.
    /// </summary>
    [TerraformArgument("always_serve_enabled")]
    public TerraformValue<bool>? AlwaysServeEnabled
    {
        get => new TerraformReference<bool>(this, "always_serve_enabled");
        set => SetArgument("always_serve_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    [TerraformArgument("geo_mappings")]
    public TerraformList<string>? GeoMappings
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "geo_mappings").ResolveNodes(ctx));
        set => SetArgument("geo_mappings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    [TerraformArgument("profile_id")]
    public required TerraformValue<string> ProfileId
    {
        get => new TerraformReference<string>(this, "profile_id");
        set => SetArgument("profile_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformArgument("target_resource_id")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformArgument("weight")]
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// Block for custom_header.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("custom_header")]
    public TerraformList<AzurermTrafficManagerAzureEndpointCustomHeaderBlock> CustomHeader { get; set; } = new();

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("subnet")]
    public TerraformList<AzurermTrafficManagerAzureEndpointSubnetBlock> Subnet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermTrafficManagerAzureEndpointTimeoutsBlock Timeouts { get; set; } = new();

}
