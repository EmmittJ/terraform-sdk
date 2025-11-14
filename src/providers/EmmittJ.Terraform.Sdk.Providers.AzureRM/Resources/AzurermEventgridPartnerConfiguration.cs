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
/// Block type for partner_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partner_authorization";

    /// <summary>
    /// The authorization_expiration_time_in_utc attribute.
    /// </summary>
    [TerraformArgument("authorization_expiration_time_in_utc")]
    public TerraformValue<string>? AuthorizationExpirationTimeInUtc
    {
        get => new TerraformReference<string>(this, "authorization_expiration_time_in_utc");
        set => SetArgument("authorization_expiration_time_in_utc", value);
    }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerName is required")]
    [TerraformArgument("partner_name")]
    public required TerraformValue<string> PartnerName
    {
        get => new TerraformReference<string>(this, "partner_name");
        set => SetArgument("partner_name", value);
    }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerRegistrationId is required")]
    [TerraformArgument("partner_registration_id")]
    public required TerraformValue<string> PartnerRegistrationId
    {
        get => new TerraformReference<string>(this, "partner_registration_id");
        set => SetArgument("partner_registration_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridPartnerConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_eventgrid_partner_configuration resource.
/// </summary>
public class AzurermEventgridPartnerConfiguration : TerraformResource
{
    public AzurermEventgridPartnerConfiguration(string name) : base("azurerm_eventgrid_partner_configuration", name)
    {
    }

    /// <summary>
    /// The default_maximum_expiration_time_in_days attribute.
    /// </summary>
    [TerraformArgument("default_maximum_expiration_time_in_days")]
    public TerraformValue<double>? DefaultMaximumExpirationTimeInDays
    {
        get => new TerraformReference<double>(this, "default_maximum_expiration_time_in_days");
        set => SetArgument("default_maximum_expiration_time_in_days", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for partner_authorization.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("partner_authorization")]
    public TerraformList<AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock> PartnerAuthorization { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventgridPartnerConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
