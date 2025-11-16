using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_data_factory_integration_runtime_azure Terraform resource.
/// Manages a azurerm_data_factory_integration_runtime_azure resource.
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzure(string name) : TerraformResource("azurerm_data_factory_integration_runtime_azure", name)
{
    /// <summary>
    /// The cleanup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CleanupEnabled
    {
        get => new TerraformReference<bool>(this, "cleanup_enabled");
        set => SetArgument("cleanup_enabled", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformValue<string>? ComputeType
    {
        get => new TerraformReference<string>(this, "compute_type");
        set => SetArgument("compute_type", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformValue<double>? CoreCount
    {
        get => new TerraformReference<double>(this, "core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The time_to_live_min attribute.
    /// </summary>
    public TerraformValue<double>? TimeToLiveMin
    {
        get => new TerraformReference<double>(this, "time_to_live_min");
        set => SetArgument("time_to_live_min", value);
    }

    /// <summary>
    /// The virtual_network_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualNetworkEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_enabled");
        set => SetArgument("virtual_network_enabled", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
