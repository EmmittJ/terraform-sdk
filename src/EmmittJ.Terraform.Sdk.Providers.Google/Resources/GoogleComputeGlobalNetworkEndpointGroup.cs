using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_global_network_endpoint_group resource.
/// </summary>
public class GoogleComputeGlobalNetworkEndpointGroup : TerraformResource
{
    public GoogleComputeGlobalNetworkEndpointGroup(string name) : base("google_compute_global_network_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// The default port used if the port number is not specified in the
    /// network endpoint.
    /// </summary>
    public double? DefaultPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_port")?.Value;
        set => this.WithProperty("default_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Possible values: [&amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;]
    /// </summary>
    public string? NetworkEndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_endpoint_type")?.Value;
        set => this.WithProperty("network_endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
