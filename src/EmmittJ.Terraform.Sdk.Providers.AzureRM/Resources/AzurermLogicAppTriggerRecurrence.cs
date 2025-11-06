using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_trigger_recurrence resource.
/// </summary>
public class AzurermLogicAppTriggerRecurrence : TerraformResource
{
    public AzurermLogicAppTriggerRecurrence(string name) : base("azurerm_logic_app_trigger_recurrence", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public string? Frequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frequency")?.Value;
        set => this.WithProperty("frequency", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The interval attribute.
    /// </summary>
    public double? Interval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("interval")?.Value;
        set => this.WithProperty("interval", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    public string? LogicAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logic_app_id")?.Value;
        set => this.WithProperty("logic_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The start_time attribute.
    /// </summary>
    public string? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time")?.Value;
        set => this.WithProperty("start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
