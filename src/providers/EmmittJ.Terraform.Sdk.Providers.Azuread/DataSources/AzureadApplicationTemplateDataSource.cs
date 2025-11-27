using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationTemplateDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTemplateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_application_template Terraform data source.
/// Retrieves information about a azuread_application_template.
/// </summary>
public partial class AzureadApplicationTemplateDataSource(string name) : TerraformDataSource("azuread_application_template", name)
{
    /// <summary>
    /// The display name for the application template
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The application template&#39;s ID
    /// </summary>
    public TerraformValue<string> TemplateId
    {
        get => new TerraformReference<string>(this, "template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// List of categories for this templated application
    /// </summary>
    public TerraformList<string> Categories
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "categories").ResolveNodes(ctx));
    }

    /// <summary>
    /// Home page URL of the templated application
    /// </summary>
    public TerraformValue<string> HomepageUrl
    {
        get => new TerraformReference<string>(this, "homepage_url");
    }

    /// <summary>
    /// URL to retrieve the logo for this templated application
    /// </summary>
    public TerraformValue<string> LogoUrl
    {
        get => new TerraformReference<string>(this, "logo_url");
    }

    /// <summary>
    /// Name of the publisher for this templated application
    /// </summary>
    public TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
    }

    /// <summary>
    /// The provisioning modes supported by this templated application
    /// </summary>
    public TerraformList<string> SupportedProvisioningTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_provisioning_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The single sign on modes supported by this templated application
    /// </summary>
    public TerraformList<string> SupportedSingleSignOnModes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_single_sign_on_modes").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationTemplateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationTemplateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
