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
    public string? DefaultSliceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_slice_id")?.Value;
        set => this.WithProperty("default_slice_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The mobile_network_id attribute.
    /// </summary>
    public string? MobileNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_id")?.Value;
        set => this.WithProperty("mobile_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public double? RatFrequencySelectionPriorityIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rat_frequency_selection_priority_index")?.Value;
        set => this.WithProperty("rat_frequency_selection_priority_index", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public double? RegistrationTimerInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("registration_timer_in_seconds")?.Value;
        set => this.WithProperty("registration_timer_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
