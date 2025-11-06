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
    /// The managed_instance_id attribute.
    /// </summary>
    public string? ManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_instance_id")?.Value;
        set => this.WithProperty("managed_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partner_managed_instance_id attribute.
    /// </summary>
    public string? PartnerManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partner_managed_instance_id")?.Value;
        set => this.WithProperty("partner_managed_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public bool? ReadonlyEndpointFailoverPolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("readonly_endpoint_failover_policy_enabled")?.Value;
        set => this.WithProperty("readonly_endpoint_failover_policy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public string? SecondaryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secondary_type")?.Value;
        set => this.WithProperty("secondary_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
