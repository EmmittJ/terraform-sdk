using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_networkmanager_links Terraform data source.
/// Retrieves information about a aws_networkmanager_links.
/// </summary>
public partial class AwsNetworkmanagerLinksDataSource(string name) : TerraformDataSource("aws_networkmanager_links", name)
{
    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => GetArgument<TerraformValue<string>>("global_network_id");
        set => SetArgument("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => GetArgument<TerraformValue<string>>("provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string>? SiteId
    {
        get => GetArgument<TerraformValue<string>>("site_id");
        set => SetArgument("site_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
        => AsReference("ids");

}
