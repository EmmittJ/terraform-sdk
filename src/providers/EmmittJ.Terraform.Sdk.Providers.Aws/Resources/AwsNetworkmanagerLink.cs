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
        get => new TerraformReference<double>(this, "download_speed");
        set => SetArgument("download_speed", value);
    }

    /// <summary>
    /// The upload_speed attribute.
    /// </summary>
    public TerraformValue<double>? UploadSpeed
    {
        get => new TerraformReference<double>(this, "upload_speed");
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => new TerraformReference<string>(this, "global_network_id");
        set => SetArgument("global_network_id", value);
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
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteId is required")]
    public required TerraformValue<string> SiteId
    {
        get => new TerraformReference<string>(this, "site_id");
        set => SetArgument("site_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
