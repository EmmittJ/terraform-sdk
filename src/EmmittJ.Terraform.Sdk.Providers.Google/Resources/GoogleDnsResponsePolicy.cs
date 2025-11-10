using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gke_clusters in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyGkeClustersBlock : TerraformBlock
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// &#39;projects/*/locations/*/clusters/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GkeClusterName is required")]
    public required TerraformProperty<string> GkeClusterName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("gke_cluster_name");
        set => WithProperty("gke_cluster_name", value);
    }

}

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyNetworksBlock : TerraformBlock
{
    /// <summary>
    /// The fully qualified URL of the VPC network to bind to.
    /// This should be formatted like
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformProperty<string> NetworkUrl
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network_url");
        set => WithProperty("network_url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsResponsePolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dns_response_policy resource.
/// </summary>
public class GoogleDnsResponsePolicy : TerraformResource
{
    public GoogleDnsResponsePolicy(string name) : base("google_dns_response_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description of the response policy, such as &#39;My new response policy&#39;.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicyName is required")]
    public required TerraformProperty<string> ResponsePolicyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("response_policy_name");
        set => this.WithProperty("response_policy_name", value);
    }

    /// <summary>
    /// Block for gke_clusters.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDnsResponsePolicyGkeClustersBlock>? GkeClusters
    {
        get => GetProperty<List<GoogleDnsResponsePolicyGkeClustersBlock>>("gke_clusters");
        set => this.WithProperty("gke_clusters", value);
    }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDnsResponsePolicyNetworksBlock>? Networks
    {
        get => GetProperty<List<GoogleDnsResponsePolicyNetworksBlock>>("networks");
        set => this.WithProperty("networks", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDnsResponsePolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDnsResponsePolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
