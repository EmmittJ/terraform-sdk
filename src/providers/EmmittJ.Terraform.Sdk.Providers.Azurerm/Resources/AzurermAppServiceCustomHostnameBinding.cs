using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceCustomHostnameBinding.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCustomHostnameBindingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_custom_hostname_binding Terraform resource.
/// Manages a azurerm_app_service_custom_hostname_binding resource.
/// </summary>
public partial class AzurermAppServiceCustomHostnameBinding(string name) : TerraformResource("azurerm_app_service_custom_hostname_binding", name)
{
    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformValue<string> AppServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_service_name");
        set => SetArgument("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    public TerraformValue<string> SslState
    {
        get => GetArgument<TerraformValue<string>>("ssl_state") ?? AsReference("ssl_state");
        set => SetArgument("ssl_state", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => GetArgument<TerraformValue<string>>("thumbprint") ?? AsReference("thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformValue<string> VirtualIp
        => AsReference("virtual_ip");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCustomHostnameBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCustomHostnameBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
