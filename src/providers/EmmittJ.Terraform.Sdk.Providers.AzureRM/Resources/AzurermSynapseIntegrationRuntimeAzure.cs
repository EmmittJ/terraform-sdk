using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseIntegrationRuntimeAzureTimeoutsBlock : TerraformBlock
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
        SetOutput("compute_type");
        SetOutput("core_count");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("synapse_workspace_id");
        SetOutput("time_to_live_min");
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformProperty<string> ComputeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_type");
        set => SetProperty("compute_type", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformProperty<double> CoreCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("core_count");
        set => SetProperty("core_count", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synapse_workspace_id");
        set => SetProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The time_to_live_min attribute.
    /// </summary>
    public TerraformProperty<double> TimeToLiveMin
    {
        get => GetRequiredOutput<TerraformProperty<double>>("time_to_live_min");
        set => SetProperty("time_to_live_min", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseIntegrationRuntimeAzureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
