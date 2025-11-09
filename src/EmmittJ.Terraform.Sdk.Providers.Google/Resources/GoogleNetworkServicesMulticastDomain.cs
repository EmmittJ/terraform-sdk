using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_services_multicast_domain resource.
/// </summary>
public class GoogleNetworkServicesMulticastDomain : TerraformResource
{
    public GoogleNetworkServicesMulticastDomain(string name) : base("google_network_services_multicast_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("unique_id");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The resource name of the multicast admin VPC network.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/networks/{network}&#39;.
    /// </summary>
    public TerraformProperty<string>? AdminNetwork
    {
        get => GetProperty<TerraformProperty<string>>("admin_network");
        set => this.WithProperty("admin_network", value);
    }

    /// <summary>
    /// An optional text description of the multicast domain.
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
    /// Labels as key-value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The multicast domain group this domain should be associated with.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/multicastDomainGroups/{multicast_domain_group}&#39;.
    /// </summary>
    public TerraformProperty<string>? MulticastDomainGroup
    {
        get => GetProperty<TerraformProperty<string>>("multicast_domain_group");
        set => this.WithProperty("multicast_domain_group", value);
    }

    /// <summary>
    /// A unique name for the multicast domain.
    /// The name is restricted to letters, numbers, and hyphen, with the first
    /// character a letter, and the last a letter or a number. The name must not
    /// exceed 48 characters.
    /// </summary>
    public TerraformProperty<string>? MulticastDomainId
    {
        get => GetProperty<TerraformProperty<string>>("multicast_domain_id");
        set => this.WithProperty("multicast_domain_id", value);
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
    /// [Output only] The timestamp when the multicast domain was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. The resource name of the multicast domain.
    /// Use the following format:
    /// &#39;projects/*/locations/global/multicastDomains/*&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// [Output only] The Google-generated UUID for the resource. This value is
    /// unique across all multicast domain resources. If a domain is deleted and
    /// another with the same name is created, the new domain is assigned a
    /// different unique_id.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

    /// <summary>
    /// [Output only] The timestamp when the multicast domain was most recently
    /// updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
