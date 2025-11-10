using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_public_ip.
/// </summary>
public class AzurermPublicIpDataSource : TerraformDataSource
{
    public AzurermPublicIpDataSource(string name) : base("azurerm_public_ip", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocation_method");
        SetOutput("ddos_protection_mode");
        SetOutput("ddos_protection_plan_id");
        SetOutput("domain_name_label");
        SetOutput("fqdn");
        SetOutput("idle_timeout_in_minutes");
        SetOutput("ip_address");
        SetOutput("ip_tags");
        SetOutput("ip_version");
        SetOutput("location");
        SetOutput("reverse_fqdn");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("zones");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPublicIpDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    public TerraformExpression AllocationMethod => this["allocation_method"];

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public TerraformExpression DdosProtectionMode => this["ddos_protection_mode"];

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public TerraformExpression DdosProtectionPlanId => this["ddos_protection_plan_id"];

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformExpression DomainNameLabel => this["domain_name_label"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformExpression IdleTimeoutInMinutes => this["idle_timeout_in_minutes"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public TerraformExpression IpTags => this["ip_tags"];

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public TerraformExpression IpVersion => this["ip_version"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    public TerraformExpression ReverseFqdn => this["reverse_fqdn"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
