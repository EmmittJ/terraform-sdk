using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mobile_network_sim_policy.
/// </summary>
public class AzurermMobileNetworkSimPolicyDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimPolicyDataSource(string name) : base("azurerm_mobile_network_sim_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_slice_id");
        this.DeclareOutput("location");
        this.DeclareOutput("rat_frequency_selection_priority_index");
        this.DeclareOutput("registration_timer_in_seconds");
        this.DeclareOutput("slice");
        this.DeclareOutput("tags");
        this.DeclareOutput("user_equipment_aggregate_maximum_bit_rate");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MobileNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The default_slice_id attribute.
    /// </summary>
    public TerraformExpression DefaultSliceId => this["default_slice_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The rat_frequency_selection_priority_index attribute.
    /// </summary>
    public TerraformExpression RatFrequencySelectionPriorityIndex => this["rat_frequency_selection_priority_index"];

    /// <summary>
    /// The registration_timer_in_seconds attribute.
    /// </summary>
    public TerraformExpression RegistrationTimerInSeconds => this["registration_timer_in_seconds"];

    /// <summary>
    /// The slice attribute.
    /// </summary>
    public TerraformExpression Slice => this["slice"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user_equipment_aggregate_maximum_bit_rate attribute.
    /// </summary>
    public TerraformExpression UserEquipmentAggregateMaximumBitRate => this["user_equipment_aggregate_maximum_bit_rate"];

}
