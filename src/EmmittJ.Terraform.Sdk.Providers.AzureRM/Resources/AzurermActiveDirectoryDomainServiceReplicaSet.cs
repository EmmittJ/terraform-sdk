using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_active_directory_domain_service_replica_set resource.
/// </summary>
public class AzurermActiveDirectoryDomainServiceReplicaSet : TerraformResource
{
    public AzurermActiveDirectoryDomainServiceReplicaSet(string name) : base("azurerm_active_directory_domain_service_replica_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("domain_controller_ip_addresses");
        this.DeclareOutput("external_access_ip_address");
        this.DeclareOutput("service_status");
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? DomainServiceId
    {
        get => GetProperty<TerraformProperty<string>>("domain_service_id");
        set => this.WithProperty("domain_service_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    public TerraformExpression DomainControllerIpAddresses => this["domain_controller_ip_addresses"];

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    public TerraformExpression ExternalAccessIpAddress => this["external_access_ip_address"];

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformExpression ServiceStatus => this["service_status"];

}
