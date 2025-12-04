using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleServiceNetworkingPeeredDnsDomain.
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock : TerraformBlock
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
/// Represents a google_service_networking_peered_dns_domain Terraform resource.
/// Manages a google_service_networking_peered_dns_domain resource.
/// </summary>
public partial class GoogleServiceNetworkingPeeredDnsDomain(string name) : TerraformResource("google_service_networking_peered_dns_domain", name)
{
    /// <summary>
    /// The DNS domain name suffix of the peered DNS domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsSuffix is required")]
    public required TerraformValue<string> DnsSuffix
    {
        get => GetArgument<TerraformValue<string>>("dns_suffix");
        set => SetArgument("dns_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the peered DNS domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Network in the consumer project to peer with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the service to create a peered DNS domain for, e.g. servicenetworking.googleapis.com
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformValue<string> Parent
        => AsReference("parent");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
