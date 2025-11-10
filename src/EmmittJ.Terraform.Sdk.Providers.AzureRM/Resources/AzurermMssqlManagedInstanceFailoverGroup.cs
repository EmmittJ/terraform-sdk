using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for read_write_endpoint_failover_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The grace_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? GraceMinutes
    {
        get => GetProperty<TerraformProperty<double>>("grace_minutes");
        set => WithProperty("grace_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformProperty<string> ManagedInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
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
    /// The partner_managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerManagedInstanceId is required")]
    public required TerraformProperty<string> PartnerManagedInstanceId
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
    /// Block for read_write_endpoint_failover_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadWriteEndpointFailoverPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadWriteEndpointFailoverPolicy block(s) allowed")]
    public List<AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock>? ReadWriteEndpointFailoverPolicy
    {
        get => GetProperty<List<AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock>>("read_write_endpoint_failover_policy");
        set => this.WithProperty("read_write_endpoint_failover_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
