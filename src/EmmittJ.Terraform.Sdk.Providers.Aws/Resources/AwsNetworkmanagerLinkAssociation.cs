using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_link_association resource.
/// </summary>
public class AwsNetworkmanagerLinkAssociation : TerraformResource
{
    public AwsNetworkmanagerLinkAssociation(string name) : base("aws_networkmanager_link_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceId
    {
        get => GetProperty<TerraformProperty<string>>("device_id");
        set => this.WithProperty("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("global_network_id");
        set => this.WithProperty("global_network_id", value);
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
    /// The link_id attribute.
    /// </summary>
    public TerraformProperty<string>? LinkId
    {
        get => GetProperty<TerraformProperty<string>>("link_id");
        set => this.WithProperty("link_id", value);
    }

}
