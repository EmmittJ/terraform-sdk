using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_network.
/// </summary>
public class GoogleVmwareengineNetworkDataSource : TerraformDataSource
{
    public GoogleVmwareengineNetworkDataSource(string name) : base("google_vmwareengine_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("description");
        this.WithOutput("etag");
        this.WithOutput("state");
        this.WithOutput("type");
        this.WithOutput("uid");
        this.WithOutput("update_time");
        this.WithOutput("vpc_networks");
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
    /// The location where the VMwareEngineNetwork should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the VMwareEngineNetwork.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// User-provided description for this VMware Engine network.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Checksum that may be sent on update and delete requests to ensure that the user-provided value is up to date befor
    /// The server computes checksums based on the value of other fields in the request.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// State of the VMware Engine network.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// VMware Engine network type. Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Last update time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// VMware Engine service VPC networks that provide connectivity from a private cloud to customer projects,
    /// the internet, and other Google Cloud services.
    /// </summary>
    public TerraformExpression VpcNetworks => this["vpc_networks"];

}
