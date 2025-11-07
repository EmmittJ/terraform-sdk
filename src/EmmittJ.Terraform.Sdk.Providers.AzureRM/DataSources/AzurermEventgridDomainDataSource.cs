using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_eventgrid_domain.
/// </summary>
public class AzurermEventgridDomainDataSource : TerraformDataSource
{
    public AzurermEventgridDomainDataSource(string name) : base("azurerm_eventgrid_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("identity");
        this.DeclareOutput("inbound_ip_rule");
        this.DeclareOutput("input_mapping_default_values");
        this.DeclareOutput("input_mapping_fields");
        this.DeclareOutput("input_schema");
        this.DeclareOutput("location");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    public TerraformExpression InboundIpRule => this["inbound_ip_rule"];

    /// <summary>
    /// The input_mapping_default_values attribute.
    /// </summary>
    public TerraformExpression InputMappingDefaultValues => this["input_mapping_default_values"];

    /// <summary>
    /// The input_mapping_fields attribute.
    /// </summary>
    public TerraformExpression InputMappingFields => this["input_mapping_fields"];

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    public TerraformExpression InputSchema => this["input_schema"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
