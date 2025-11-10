using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("domain_controller_ip_addresses");
        SetOutput("external_access_ip_address");
        SetOutput("service_status");
        SetOutput("domain_service_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("subnet_id");
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    public required TerraformProperty<string> DomainServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_service_id");
        set => SetProperty("domain_service_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
