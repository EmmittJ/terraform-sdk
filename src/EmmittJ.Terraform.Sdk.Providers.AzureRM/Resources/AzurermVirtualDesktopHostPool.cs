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
    public TerraformLiteralProperty<string>? CustomRdpProperties
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_rdp_properties");
        set => this.WithProperty("custom_rdp_properties", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
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
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_type");
        set => this.WithProperty("load_balancer_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaximumSessionsAllowed
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_sessions_allowed");
        set => this.WithProperty("maximum_sessions_allowed", value);
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
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PersonalDesktopAssignmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("personal_desktop_assignment_type");
        set => this.WithProperty("personal_desktop_assignment_type", value);
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    public TerraformLiteralProperty<string>? PreferredAppGroupType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_app_group_type");
        set => this.WithProperty("preferred_app_group_type", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StartVmOnConnect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_vm_on_connect");
        set => this.WithProperty("start_vm_on_connect", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ValidateEnvironment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("validate_environment");
        set => this.WithProperty("validate_environment", value);
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_template");
        set => this.WithProperty("vm_template", value);
    }

}
