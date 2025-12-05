using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementGatewayCertificateAuthority.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayCertificateAuthorityTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_gateway_certificate_authority Terraform resource.
/// Manages a azurerm_api_management_gateway_certificate_authority resource.
/// </summary>
public partial class AzurermApiManagementGatewayCertificateAuthority(string name) : TerraformResource("azurerm_api_management_gateway_certificate_authority", name)
{
    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformValue<string> ApiManagementId
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_management_id");
        set => SetArgument("api_management_id", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateName is required")]
    public required TerraformValue<string> CertificateName
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_name");
        set => SetArgument("certificate_name", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformValue<string> GatewayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_name");
        set => SetArgument("gateway_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_trusted attribute.
    /// </summary>
    public TerraformValue<bool>? IsTrusted
    {
        get => GetArgument<TerraformValue<bool>>("is_trusted");
        set => SetArgument("is_trusted", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementGatewayCertificateAuthorityTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementGatewayCertificateAuthorityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
