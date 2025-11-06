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
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Name of VPC network connected with service producers using VPC peering.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Named IP address range(s) of PEERING type reserved for this service provider. Note that invoking this method with a different range when connection is already established will not reallocate already provisioned service producer subnetworks.
    /// </summary>
    public List<string>? ReservedPeeringRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("reserved_peering_ranges")?.Value;
        set => this.WithProperty("reserved_peering_ranges", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Provider peering service that is managing peering connectivity for a service provider organization. For Google services that support this functionality it is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// When set to true, enforce an update of the reserved peering ranges on the existing service networking connection in case of a new connection creation failure.
    /// </summary>
    public bool? UpdateOnCreationFail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("update_on_creation_fail")?.Value;
        set => this.WithProperty("update_on_creation_fail", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The peering attribute.
    /// </summary>
    public TerraformExpression Peering => this["peering"];

}
