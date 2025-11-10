using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleActiveDirectoryDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_active_directory_domain resource.
/// </summary>
public class GoogleActiveDirectoryDomain : TerraformResource
{
    public GoogleActiveDirectoryDomain(string name) : base("google_active_directory_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("fqdn");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("admin");
        SetOutput("authorized_networks");
        SetOutput("deletion_protection");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("locations");
        SetOutput("project");
        SetOutput("reserved_ip_range");
    }

    /// <summary>
    /// The name of delegated administrator account used to perform Active Directory operations.
    /// If not specified, setupadmin will be used.
    /// </summary>
    public TerraformProperty<string> Admin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin");
        set => SetProperty("admin", value);
    }

    /// <summary>
    /// The full names of the Google Compute Engine networks the domain instance is connected to. The domain is only available on networks listed in authorizedNetworks.
    /// If CIDR subnets overlap between networks, domain creation will fail.
    /// </summary>
    public HashSet<TerraformProperty<string>> AuthorizedNetworks
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("authorized_networks");
        set => SetProperty("authorized_networks", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the domain. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the domain,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the domain will fail.
    /// When the field is set to false, deleting the domain is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
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
    /// Resource labels that can contain user-provided metadata
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Locations where domain needs to be provisioned. [regions][compute/docs/regions-zones/]
    /// e.g. us-west1 or us-east4 Service supports up to 4 locations at once. Each location will use a /26 block.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public List<TerraformProperty<string>> Locations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("locations");
        set => SetProperty("locations", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this domain. Reserved networks must be /24 or larger.
    /// Ranges must be unique and non-overlapping with existing subnets in authorizedNetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedIpRange is required")]
    public required TerraformProperty<string> ReservedIpRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reserved_ip_range");
        set => SetProperty("reserved_ip_range", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleActiveDirectoryDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fully-qualified domain name of the exposed domain used by clients to connect to the service.
    /// Similar to what would be chosen for an Active Directory set up on an internal network.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The unique name of the domain using the format: &#39;projects/{project}/locations/global/domains/{domainName}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
