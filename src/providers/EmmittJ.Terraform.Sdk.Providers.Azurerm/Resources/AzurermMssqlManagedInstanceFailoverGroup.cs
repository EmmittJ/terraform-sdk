using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for read_write_endpoint_failover_policy in AzurermMssqlManagedInstanceFailoverGroup.
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
    public TerraformValue<double>? GraceMinutes
    {
        get => new TerraformReference<double>(this, "grace_minutes");
        set => SetArgument("grace_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlManagedInstanceFailoverGroup.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_mssql_managed_instance_failover_group Terraform resource.
/// Manages a azurerm_mssql_managed_instance_failover_group resource.
/// </summary>
public partial class AzurermMssqlManagedInstanceFailoverGroup(string name) : TerraformResource("azurerm_mssql_managed_instance_failover_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partner_managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerManagedInstanceId is required")]
    public required TerraformValue<string> PartnerManagedInstanceId
    {
        get => new TerraformReference<string>(this, "partner_managed_instance_id");
        set => SetArgument("partner_managed_instance_id", value);
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ReadonlyEndpointFailoverPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "readonly_endpoint_failover_policy_enabled");
        set => SetArgument("readonly_endpoint_failover_policy_enabled", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformValue<string>? SecondaryType
    {
        get => new TerraformReference<string>(this, "secondary_type");
        set => SetArgument("secondary_type", value);
    }

    /// <summary>
    /// The partner_region attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartnerRegion
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "partner_region").ResolveNodes(ctx));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
    }

    /// <summary>
    /// ReadWriteEndpointFailoverPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadWriteEndpointFailoverPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadWriteEndpointFailoverPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadWriteEndpointFailoverPolicy block(s) allowed")]
    public required TerraformList<AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock> ReadWriteEndpointFailoverPolicy
    {
        get => GetRequiredArgument<TerraformList<AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock>>("read_write_endpoint_failover_policy");
        set => SetArgument("read_write_endpoint_failover_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
