using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_desktop_host_pool resource.
/// </summary>
public class AzurermVirtualDesktopHostPool : TerraformResource
{
    public AzurermVirtualDesktopHostPool(string name) : base("azurerm_virtual_desktop_host_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    public string? CustomRdpProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_rdp_properties")?.Value;
        set => this.WithProperty("custom_rdp_properties", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public string? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name")?.Value;
        set => this.WithProperty("friendly_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The load_balancer_type attribute.
    /// </summary>
    public string? LoadBalancerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_type")?.Value;
        set => this.WithProperty("load_balancer_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public double? MaximumSessionsAllowed
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_sessions_allowed")?.Value;
        set => this.WithProperty("maximum_sessions_allowed", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public string? PersonalDesktopAssignmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("personal_desktop_assignment_type")?.Value;
        set => this.WithProperty("personal_desktop_assignment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    public string? PreferredAppGroupType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_app_group_type")?.Value;
        set => this.WithProperty("preferred_app_group_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public string? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access")?.Value;
        set => this.WithProperty("public_network_access", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The start_vm_on_connect attribute.
    /// </summary>
    public bool? StartVmOnConnect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_vm_on_connect")?.Value;
        set => this.WithProperty("start_vm_on_connect", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public bool? ValidateEnvironment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("validate_environment")?.Value;
        set => this.WithProperty("validate_environment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    public string? VmTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_template")?.Value;
        set => this.WithProperty("vm_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
