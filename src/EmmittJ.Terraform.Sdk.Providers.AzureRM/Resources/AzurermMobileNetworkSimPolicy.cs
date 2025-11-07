using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network_sim_policy resource.
/// </summary>
public class AzurermMobileNetworkSimPolicy : TerraformResource
{
    public AzurermMobileNetworkSimPolicy(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultSliceId
    {
        get => GetProperty<TerraformProperty<string>>("default_slice_id");
        set => this.WithProperty("default_slice_id", value);
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
    /// The mobile_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? MobileNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
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
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformProperty<double>? RatFrequencySelectionPriorityIndex
    {
        get => GetProperty<TerraformProperty<double>>("rat_frequency_selection_priority_index");
        set => this.WithProperty("rat_frequency_selection_priority_index", value);
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RegistrationTimerInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("registration_timer_in_seconds");
        set => this.WithProperty("registration_timer_in_seconds", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
