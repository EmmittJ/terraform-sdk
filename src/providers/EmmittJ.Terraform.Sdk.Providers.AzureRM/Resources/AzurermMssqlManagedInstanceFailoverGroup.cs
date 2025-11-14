using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for read_write_endpoint_failover_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_write_endpoint_failover_policy";

    /// <summary>
    /// The grace_minutes attribute.
    /// </summary>
    [TerraformArgument("grace_minutes")]
    public TerraformValue<double>? GraceMinutes
    {
        get => new TerraformReference<double>(this, "grace_minutes");
        set => SetArgument("grace_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformArgument("mode")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance_failover_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedInstanceFailoverGroup : TerraformResource
{
    public AzurermMssqlManagedInstanceFailoverGroup(string name) : base("azurerm_mssql_managed_instance_failover_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformArgument("managed_instance_id")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partner_managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerManagedInstanceId is required")]
    [TerraformArgument("partner_managed_instance_id")]
    public required TerraformValue<string> PartnerManagedInstanceId
    {
        get => new TerraformReference<string>(this, "partner_managed_instance_id");
        set => SetArgument("partner_managed_instance_id", value);
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("readonly_endpoint_failover_policy_enabled")]
    public TerraformValue<bool>? ReadonlyEndpointFailoverPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "readonly_endpoint_failover_policy_enabled");
        set => SetArgument("readonly_endpoint_failover_policy_enabled", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    [TerraformArgument("secondary_type")]
    public TerraformValue<string>? SecondaryType
    {
        get => new TerraformReference<string>(this, "secondary_type");
        set => SetArgument("secondary_type", value);
    }

    /// <summary>
    /// Block for read_write_endpoint_failover_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadWriteEndpointFailoverPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadWriteEndpointFailoverPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadWriteEndpointFailoverPolicy block(s) allowed")]
    [TerraformArgument("read_write_endpoint_failover_policy")]
    public required TerraformList<AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock> ReadWriteEndpointFailoverPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The partner_region attribute.
    /// </summary>
    [TerraformArgument("partner_region")]
    public TerraformList<object> PartnerRegion
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "partner_region").ResolveNodes(ctx));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformArgument("role")]
    public TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
    }

}
