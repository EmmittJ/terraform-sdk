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
    public string? DomainServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_service_id")?.Value;
        set => this.WithProperty("domain_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
