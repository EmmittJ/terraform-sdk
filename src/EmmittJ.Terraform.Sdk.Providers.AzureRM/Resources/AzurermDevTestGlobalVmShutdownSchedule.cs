using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_test_global_vm_shutdown_schedule resource.
/// </summary>
public class AzurermDevTestGlobalVmShutdownSchedule : TerraformResource
{
    public AzurermDevTestGlobalVmShutdownSchedule(string name) : base("azurerm_dev_test_global_vm_shutdown_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The daily_recurrence_time attribute.
    /// </summary>
    public string? DailyRecurrenceTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("daily_recurrence_time")?.Value;
        set => this.WithProperty("daily_recurrence_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public string? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone")?.Value;
        set => this.WithProperty("timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
