using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dynatrace_tag_rules resource.
/// </summary>
public class AzurermDynatraceTagRules : TerraformResource
{
    public AzurermDynatraceTagRules(string name) : base("azurerm_dynatrace_tag_rules", name)
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
    /// The monitor_id attribute.
    /// </summary>
    public TerraformProperty<string>? MonitorId
    {
        get => GetProperty<TerraformProperty<string>>("monitor_id");
        set => this.WithProperty("monitor_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
