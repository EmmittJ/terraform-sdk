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
        set => SetProperty("gke_cluster_name", value);
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
        set => SetProperty("network_url", value);
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
        SetOutput("description");
        SetOutput("id");
        SetOutput("project");
        SetOutput("response_policy_name");
    }

    /// <summary>
    /// The description of the response policy, such as &#39;My new response policy&#39;.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicyName is required")]
    public required TerraformProperty<string> ResponsePolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("response_policy_name");
        set => SetProperty("response_policy_name", value);
    }

    /// <summary>
    /// Block for gke_clusters.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDnsResponsePolicyGkeClustersBlock>? GkeClusters
    {
        set => SetProperty("gke_clusters", value);
    }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDnsResponsePolicyNetworksBlock>? Networks
    {
        set => SetProperty("networks", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDnsResponsePolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
