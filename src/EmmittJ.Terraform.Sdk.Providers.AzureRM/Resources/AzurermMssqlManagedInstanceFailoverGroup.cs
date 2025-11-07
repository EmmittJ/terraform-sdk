using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_managed_instance_failover_group resource.
/// </summary>
public class AzurermMssqlManagedInstanceFailoverGroup : TerraformResource
{
    public AzurermMssqlManagedInstanceFailoverGroup(string name) : base("azurerm_mssql_managed_instance_failover_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("partner_region");
        this.DeclareOutput("role");
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
    /// The managed_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
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
    /// The partner_managed_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? PartnerManagedInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("partner_managed_instance_id");
        set => this.WithProperty("partner_managed_instance_id", value);
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadonlyEndpointFailoverPolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("readonly_endpoint_failover_policy_enabled");
        set => this.WithProperty("readonly_endpoint_failover_policy_enabled", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryType
    {
        get => GetProperty<TerraformProperty<string>>("secondary_type");
        set => this.WithProperty("secondary_type", value);
    }

    /// <summary>
    /// The partner_region attribute.
    /// </summary>
    public TerraformExpression PartnerRegion => this["partner_region"];

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformExpression Role => this["role"];

}
