using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? AuthorizationExpirationTimeInUtc
    {
        get => new TerraformReference<string>(this, "authorization_expiration_time_in_utc");
        set => SetArgument("authorization_expiration_time_in_utc", value);
    }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerName is required")]
    public required TerraformValue<string> PartnerName
    {
        get => new TerraformReference<string>(this, "partner_name");
        set => SetArgument("partner_name", value);
    }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerRegistrationId is required")]
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
/// Represents a azurerm_eventgrid_partner_configuration Terraform resource.
/// Manages a azurerm_eventgrid_partner_configuration resource.
/// </summary>
public partial class AzurermEventgridPartnerConfiguration(string name) : TerraformResource("azurerm_eventgrid_partner_configuration", name)
{
    /// <summary>
    /// The default_maximum_expiration_time_in_days attribute.
    /// </summary>
    public TerraformValue<double>? DefaultMaximumExpirationTimeInDays
    {
        get => new TerraformReference<double>(this, "default_maximum_expiration_time_in_days");
        set => SetArgument("default_maximum_expiration_time_in_days", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// PartnerAuthorization block (nesting mode: list).
    /// </summary>
    public AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock? PartnerAuthorization
    {
        get => GetArgument<AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock>("partner_authorization");
        set => SetArgument("partner_authorization", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridPartnerConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridPartnerConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
