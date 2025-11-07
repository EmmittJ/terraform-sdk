using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_networking_connection resource.
/// </summary>
public class GoogleServiceNetworkingConnection : TerraformResource
{
    public GoogleServiceNetworkingConnection(string name) : base("google_service_networking_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("peering");
    }

    /// <summary>
    /// When set to ABANDON, terraform will abandon management of the resource instead of deleting it. Prevents terraform apply failures with CloudSQL. Note: The resource will still exist.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
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
    /// Name of VPC network connected with service producers using VPC peering.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// Named IP address range(s) of PEERING type reserved for this service provider. Note that invoking this method with a different range when connection is already established will not reallocate already provisioned service producer subnetworks.
    /// </summary>
    public TerraformProperty<List<string>>? ReservedPeeringRanges
    {
        get => GetProperty<TerraformProperty<List<string>>>("reserved_peering_ranges");
        set => this.WithProperty("reserved_peering_ranges", value);
    }

    /// <summary>
    /// Provider peering service that is managing peering connectivity for a service provider organization. For Google services that support this functionality it is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// When set to true, enforce an update of the reserved peering ranges on the existing service networking connection in case of a new connection creation failure.
    /// </summary>
    public TerraformProperty<bool>? UpdateOnCreationFail
    {
        get => GetProperty<TerraformProperty<bool>>("update_on_creation_fail");
        set => this.WithProperty("update_on_creation_fail", value);
    }

    /// <summary>
    /// The peering attribute.
    /// </summary>
    public TerraformExpression Peering => this["peering"];

}
