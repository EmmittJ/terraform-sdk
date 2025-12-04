using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bandwidth in AwsNetworkmanagerLink.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerLinkBandwidthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bandwidth";

    /// <summary>
    /// The download_speed attribute.
    /// </summary>
    public TerraformValue<double>? DownloadSpeed
    {
        get => GetArgument<TerraformValue<double>>("download_speed");
        set => SetArgument("download_speed", value);
    }

    /// <summary>
    /// The upload_speed attribute.
    /// </summary>
    public TerraformValue<double>? UploadSpeed
    {
        get => GetArgument<TerraformValue<double>>("upload_speed");
        set => SetArgument("upload_speed", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkmanagerLink.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerLinkTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_link Terraform resource.
/// Manages a aws_networkmanager_link resource.
/// </summary>
public partial class AwsNetworkmanagerLink(string name) : TerraformResource("aws_networkmanager_link", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteId is required")]
    public required TerraformValue<string> SiteId
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Bandwidth block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Bandwidth block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bandwidth block(s) allowed")]
    public required TerraformList<AwsNetworkmanagerLinkBandwidthBlock> Bandwidth
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerLinkBandwidthBlock>>("bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerLinkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerLinkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
