using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_test_schedule resource.
/// </summary>
public class AzurermDevTestSchedule : TerraformResource
{
    public AzurermDevTestSchedule(string name) : base("azurerm_dev_test_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The lab_name attribute.
    /// </summary>
    public string? LabName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_name")?.Value;
        set => this.WithProperty("lab_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The task_type attribute.
    /// </summary>
    public string? TaskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_type")?.Value;
        set => this.WithProperty("task_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    public string? TimeZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone_id")?.Value;
        set => this.WithProperty("time_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
