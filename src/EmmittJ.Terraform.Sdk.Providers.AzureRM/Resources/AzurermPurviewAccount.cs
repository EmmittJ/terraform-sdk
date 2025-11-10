using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPurviewAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPurviewAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_purview_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPurviewAccount : TerraformResource
{
    public AzurermPurviewAccount(string name) : base("azurerm_purview_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("atlas_kafka_endpoint_primary_connection_string");
        this.DeclareOutput("atlas_kafka_endpoint_secondary_connection_string");
        this.DeclareOutput("aws_external_id");
        this.DeclareOutput("catalog_endpoint");
        this.DeclareOutput("guardian_endpoint");
        this.DeclareOutput("managed_resources");
        this.DeclareOutput("scan_endpoint");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ManagedEventHubEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("managed_event_hub_enabled");
        set => this.WithProperty("managed_event_hub_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_enabled");
        set => this.WithProperty("public_network_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermPurviewAccountIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermPurviewAccountIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPurviewAccountTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPurviewAccountTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The atlas_kafka_endpoint_primary_connection_string attribute.
    /// </summary>
    public TerraformExpression AtlasKafkaEndpointPrimaryConnectionString => this["atlas_kafka_endpoint_primary_connection_string"];

    /// <summary>
    /// The atlas_kafka_endpoint_secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression AtlasKafkaEndpointSecondaryConnectionString => this["atlas_kafka_endpoint_secondary_connection_string"];

    /// <summary>
    /// The aws_external_id attribute.
    /// </summary>
    public TerraformExpression AwsExternalId => this["aws_external_id"];

    /// <summary>
    /// The catalog_endpoint attribute.
    /// </summary>
    public TerraformExpression CatalogEndpoint => this["catalog_endpoint"];

    /// <summary>
    /// The guardian_endpoint attribute.
    /// </summary>
    public TerraformExpression GuardianEndpoint => this["guardian_endpoint"];

    /// <summary>
    /// The managed_resources attribute.
    /// </summary>
    public TerraformExpression ManagedResources => this["managed_resources"];

    /// <summary>
    /// The scan_endpoint attribute.
    /// </summary>
    public TerraformExpression ScanEndpoint => this["scan_endpoint"];

}
