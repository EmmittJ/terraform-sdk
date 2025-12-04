using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermActiveDirectoryDomainServiceTrust.
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_active_directory_domain_service_trust Terraform resource.
/// Manages a azurerm_active_directory_domain_service_trust resource.
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceTrust(string name) : TerraformResource("azurerm_active_directory_domain_service_trust", name)
{
    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    public required TerraformValue<string> DomainServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_service_id");
        set => SetArgument("domain_service_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The trusted_domain_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainDnsIps is required")]
    public TerraformList<string>? TrustedDomainDnsIps
    {
        get => GetArgument<TerraformList<string>>("trusted_domain_dns_ips");
        set => SetArgument("trusted_domain_dns_ips", value);
    }

    /// <summary>
    /// The trusted_domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainFqdn is required")]
    public required TerraformValue<string> TrustedDomainFqdn
    {
        get => GetRequiredArgument<TerraformValue<string>>("trusted_domain_fqdn");
        set => SetArgument("trusted_domain_fqdn", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
