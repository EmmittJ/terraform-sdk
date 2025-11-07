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
    public TerraformProperty<string>? CustomRdpProperties
    {
        get => GetProperty<TerraformProperty<string>>("custom_rdp_properties");
        set => this.WithProperty("custom_rdp_properties", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
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
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerType
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_type");
        set => this.WithProperty("load_balancer_type", value);
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
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumSessionsAllowed
    {
        get => GetProperty<TerraformProperty<double>>("maximum_sessions_allowed");
        set => this.WithProperty("maximum_sessions_allowed", value);
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
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformProperty<string>? PersonalDesktopAssignmentType
    {
        get => GetProperty<TerraformProperty<string>>("personal_desktop_assignment_type");
        set => this.WithProperty("personal_desktop_assignment_type", value);
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    public TerraformProperty<string>? PreferredAppGroupType
    {
        get => GetProperty<TerraformProperty<string>>("preferred_app_group_type");
        set => this.WithProperty("preferred_app_group_type", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformProperty<bool>? StartVmOnConnect
    {
        get => GetProperty<TerraformProperty<bool>>("start_vm_on_connect");
        set => this.WithProperty("start_vm_on_connect", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateEnvironment
    {
        get => GetProperty<TerraformProperty<bool>>("validate_environment");
        set => this.WithProperty("validate_environment", value);
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    public TerraformProperty<string>? VmTemplate
    {
        get => GetProperty<TerraformProperty<string>>("vm_template");
        set => this.WithProperty("vm_template", value);
    }

}
