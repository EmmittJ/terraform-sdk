using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleActiveDirectoryDomain.
/// Nesting mode: single
/// </summary>
public class GoogleActiveDirectoryDomainTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_active_directory_domain Terraform resource.
/// Manages a google_active_directory_domain resource.
/// </summary>
public partial class GoogleActiveDirectoryDomain(string name) : TerraformResource("google_active_directory_domain", name)
{
    /// <summary>
    /// The name of delegated administrator account used to perform Active Directory operations.
    /// If not specified, setupadmin will be used.
    /// </summary>
    public TerraformValue<string>? Admin
    {
        get => GetArgument<TerraformValue<string>>("admin");
        set => SetArgument("admin", value);
    }

    /// <summary>
    /// The full names of the Google Compute Engine networks the domain instance is connected to. The domain is only available on networks listed in authorizedNetworks.
    /// If CIDR subnets overlap between networks, domain creation will fail.
    /// </summary>
    public TerraformSet<string>? AuthorizedNetworks
    {
        get => GetArgument<TerraformSet<string>>("authorized_networks");
        set => SetArgument("authorized_networks", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the domain. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the domain,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the domain will fail.
    /// When the field is set to false, deleting the domain is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
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
    /// Resource labels that can contain user-provided metadata
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Locations where domain needs to be provisioned. [regions][compute/docs/regions-zones/]
    /// e.g. us-west1 or us-east4 Service supports up to 4 locations at once. Each location will use a /26 block.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this domain. Reserved networks must be /24 or larger.
    /// Ranges must be unique and non-overlapping with existing subnets in authorizedNetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedIpRange is required")]
    public required TerraformValue<string> ReservedIpRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("reserved_ip_range");
        set => SetArgument("reserved_ip_range", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The fully-qualified domain name of the exposed domain used by clients to connect to the service.
    /// Similar to what would be chosen for an Active Directory set up on an internal network.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The unique name of the domain using the format: &#39;projects/{project}/locations/global/domains/{domainName}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleActiveDirectoryDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleActiveDirectoryDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
